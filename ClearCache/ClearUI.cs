using System;
using System.Net;
using System.Runtime.Serialization;
using System.Windows.Forms;
using ClearCache.Model;
using ClearCache.Properties;

namespace ClearCache
{
    /// <summary>
    /// Designer class of the dockable window add-in. It contains user interfaces that
    /// make up the dockable window.
    /// </summary>
    public partial class ClearUI : UserControl
    {
        private const string TokenUrl = "{0}://{1}/ArcGIS/rest/admin/generateToken";

        public ClearUI(object hook)
        {
            InitializeComponent();
            Hook = hook;

            cbRestServer.SelectedValueChanged += CbRestServerSelectedValueChanged;
            Serializer.DeSerializeRestServers().ForEach(server => restServerBindingSource.Add(server));
            
            btnClearCache.Click += BtnClearCacheClick;   
            btnAdd.Click += BtnAddClick;
            btnDelete.Click += BtnDeleteClick;
            btnEdit.Click += BtnEditClick;

            tbNameAdd.TextChanged += TbTextChanged;
            tbHostAdd.TextChanged += TbTextChanged;
            tbTokenAdd.TextChanged += TbTextChanged;

            tbHostAdd.LostFocus += (sender, e) => { lnkToken.Visible = (!string.IsNullOrEmpty(tbHostAdd.Text.Trim())); };

            lnkToken.Click += LnkTokenClick;

            cbSchemeAdd.DataSource = Enum.GetValues(typeof(Scheme));
        }

        void LnkTokenClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(string.Format(TokenUrl, ((Scheme)cbSchemeAdd.SelectedItem), tbHostAdd.Text.Trim()));
        }

        void CbRestServerSelectedValueChanged(object sender, EventArgs e)
        {
            var restServer = cbRestServer.SelectedItem as RestServer;

            bool enable = (restServer != null);
            
            btnClearCache.Enabled = enable;
            btnDelete.Enabled = enable;
            btnEdit.Enabled = enable;
        }

        void TbTextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNameAdd.Text.Trim()) && !string.IsNullOrEmpty(tbHostAdd.Text.Trim()) && !string.IsNullOrEmpty(tbTokenAdd.Text.Trim()))
                btnAdd.Enabled = true;
            else
                btnAdd.Enabled = false;
        }

        void BtnClearCacheClick(object sender, EventArgs e)
        {
            var restServer = cbRestServer.SelectedItem as RestServer;
            if (restServer == null)
                return;

            btnClearCache.Enabled = false;

            System.Threading.ThreadPool.QueueUserWorkItem(DoClearCache, restServer);
        }

        private void DoClearCache(object restServer)
        {
            var client = new WebClient();

            client.OpenReadCompleted += (sender, e) => Invoke((Action<RestServer, OpenReadCompletedEventArgs>)DoClearCacheCompleted, (RestServer)restServer, e);

            client.OpenReadAsync(new Uri(((RestServer)restServer).ClearEndpoint));
        }

        private void DoClearCacheCompleted(RestServer restServer, OpenReadCompletedEventArgs e)
        {
            btnClearCache.Enabled = true;

            if (e.Cancelled)
                return;

            if (e.Error != null)
            {
                MessageBox.Show(
                    string.Format("REST cache failed to clear for '{0}'\n\n{1}", restServer.Name, e.Error.Message), Resources.REST_Cache_Clear_Failed,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var s = new System.Runtime.Serialization.Json.DataContractJsonSerializer(typeof(ClearResult));
            var success = ((ClearResult)s.ReadObject(e.Result)).Success;

            if (success)
                MessageBox.Show(
                    string.Format("REST cache cleared for '{0}'", restServer.Name), Resources.REST_Cache_Cleared,
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show(
                    string.Format("REST cache failed to clear for '{0}'", restServer.Name), Resources.REST_Cache_Clear_Failed,
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
        void BtnDeleteClick(object sender, EventArgs e)
        {
            var restServer = cbRestServer.SelectedItem as RestServer;
            if (restServer == null)
                return;

            if (MessageBox.Show(string.Format("Are you sure you want to delete the configuration for '{0}'", restServer.Name), Resources.Delete_REST_Configuration, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            restServerBindingSource.Remove(restServer);
            restServer.Delete();
        }

        void BtnEditClick(object sender, EventArgs e)
        {
            var restServer = cbRestServer.SelectedItem as RestServer;
            if (restServer == null)
                return;

            MessageBox.Show("This feature has not been implemented yet.");
        }

        void BtnAddClick(object sender, EventArgs e)
        {
            var restServer = new RestServer(tbNameAdd.Text, (Scheme) cbSchemeAdd.SelectedItem, tbHostAdd.Text, "arcgis", tbTokenAdd.Text);

            restServerBindingSource.Add(restServer);

            Serializer.SerializeRestServer(restServer);

            tbNameAdd.Text = string.Empty;
            cbSchemeAdd.SelectedItem = cbSchemeAdd.Items[0];
            tbHostAdd.Text = string.Empty;
            tbTokenAdd.Text = string.Empty;

            lnkToken.Visible = false;

            btnAdd.Enabled = false;
        }

        /// <summary>
        /// Host object of the dockable window
        /// </summary>
        private object Hook
        {
            get;
            set;
        }

        /// <summary>
        /// Implementation class of the dockable window add-in. It is responsible for 
        /// creating and disposing the user interface class of the dockable window.
        /// </summary>
        internal class AddinImpl : ESRI.ArcGIS.Desktop.AddIns.DockableWindow
        {
            private ClearUI _windowUI;

            protected override IntPtr OnCreateChild()
            {
                _windowUI = new ClearUI(Hook);
                return _windowUI.Handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (_windowUI != null)
                    _windowUI.Dispose(disposing);

                base.Dispose(disposing);
            }
        }

    }

    [DataContract]
    internal class ClearResult
    {
        [DataMember(Name = "success")]
        public bool Success { get; set; }
    }
    
}
