using ClearCache.Model;

namespace ClearCache
{
    partial class ClearUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cbRestServer = new System.Windows.Forms.ComboBox();
            this.restServerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClearCache = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbHostAdd = new System.Windows.Forms.TextBox();
            this.tbTokenAdd = new System.Windows.Forms.TextBox();
            this.cbSchemeAdd = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lnkToken = new System.Windows.Forms.LinkLabel();
            this.tbNameAdd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.restServerBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbRestServer
            // 
            this.cbRestServer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.cbRestServer.DataSource = this.restServerBindingSource;
            this.cbRestServer.DisplayMember = "Name";
            this.cbRestServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRestServer.FormattingEnabled = true;
            this.cbRestServer.Location = new System.Drawing.Point(114, 3);
            this.cbRestServer.Name = "cbRestServer";
            this.cbRestServer.Size = new System.Drawing.Size(187, 21);
            this.cbRestServer.TabIndex = 1;
            // 
            // restServerBindingSource
            // 
            this.restServerBindingSource.DataSource = typeof(ClearCache.Model.RestServer);
            // 
            // btnAdd
            // 
            this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAdd.Enabled = false;
            this.btnAdd.Location = new System.Drawing.Point(349, 148);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(112, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add Configuration";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnClearCache
            // 
            this.btnClearCache.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClearCache.Enabled = false;
            this.btnClearCache.Location = new System.Drawing.Point(307, 1);
            this.btnClearCache.Name = "btnClearCache";
            this.btnClearCache.Size = new System.Drawing.Size(75, 23);
            this.btnClearCache.TabIndex = 2;
            this.btnClearCache.Text = "Clear Cache";
            this.toolTip.SetToolTip(this.btnClearCache, "Calls the clear cache method at the REST admin endpoint");
            this.btnClearCache.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Select Configuration";
            // 
            // tbHostAdd
            // 
            this.tbHostAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbHostAdd.Location = new System.Drawing.Point(74, 91);
            this.tbHostAdd.MaxLength = 100;
            this.tbHostAdd.Name = "tbHostAdd";
            this.tbHostAdd.Size = new System.Drawing.Size(387, 20);
            this.tbHostAdd.TabIndex = 7;
            this.toolTip.SetToolTip(this.tbHostAdd, "The name of the ArcGIS Server host. Must be unique.");
            // 
            // tbTokenAdd
            // 
            this.tbTokenAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTokenAdd.Location = new System.Drawing.Point(74, 125);
            this.tbTokenAdd.MaxLength = 100;
            this.tbTokenAdd.Name = "tbTokenAdd";
            this.tbTokenAdd.Size = new System.Drawing.Size(387, 20);
            this.tbTokenAdd.TabIndex = 8;
            this.toolTip.SetToolTip(this.tbTokenAdd, "Token to be used to authenticate the REST call to clear the cache. Should be vali" +
                    "d for the duration of the configuration.");
            // 
            // cbSchemeAdd
            // 
            this.cbSchemeAdd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSchemeAdd.FormattingEnabled = true;
            this.cbSchemeAdd.Location = new System.Drawing.Point(74, 56);
            this.cbSchemeAdd.Name = "cbSchemeAdd";
            this.cbSchemeAdd.Size = new System.Drawing.Size(121, 21);
            this.cbSchemeAdd.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Token";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Host";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Scheme";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lnkToken);
            this.groupBox1.Controls.Add(this.tbNameAdd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tbTokenAdd);
            this.groupBox1.Controls.Add(this.cbSchemeAdd);
            this.groupBox1.Controls.Add(this.tbHostAdd);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Location = new System.Drawing.Point(9, 49);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(467, 178);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Configuration";
            // 
            // lnkToken
            // 
            this.lnkToken.AutoSize = true;
            this.lnkToken.Location = new System.Drawing.Point(74, 152);
            this.lnkToken.Name = "lnkToken";
            this.lnkToken.Size = new System.Drawing.Size(141, 13);
            this.lnkToken.TabIndex = 12;
            this.lnkToken.TabStop = true;
            this.lnkToken.Text = "Go to Generate Token page";
            this.lnkToken.Visible = false;
            // 
            // tbNameAdd
            // 
            this.tbNameAdd.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbNameAdd.Location = new System.Drawing.Point(74, 22);
            this.tbNameAdd.MaxLength = 100;
            this.tbNameAdd.Name = "tbNameAdd";
            this.tbNameAdd.Size = new System.Drawing.Size(387, 20);
            this.tbNameAdd.TabIndex = 5;
            this.toolTip.SetToolTip(this.tbNameAdd, "The name used to identify this configuration");
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDelete.Enabled = false;
            this.btnDelete.Image = global::ClearCache.Properties.Resources._1293053567_delete;
            this.btnDelete.Location = new System.Drawing.Point(443, 3);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(27, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Tag = "SelectedItem ";
            this.toolTip.SetToolTip(this.btnDelete, "Delete configuration");
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = global::ClearCache.Properties.Resources._1293053613_gtk_edit;
            this.btnEdit.Location = new System.Drawing.Point(410, 3);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(27, 23);
            this.btnEdit.TabIndex = 3;
            this.btnEdit.Tag = "SelectedItem ";
            this.toolTip.SetToolTip(this.btnEdit, "Edit configuration");
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // ClearUI
            // 
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClearCache);
            this.Controls.Add(this.cbRestServer);
            this.Name = "ClearUI";
            this.Size = new System.Drawing.Size(479, 233);
            ((System.ComponentModel.ISupportInitialize)(this.restServerBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbRestServer;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClearCache;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbHostAdd;
        private System.Windows.Forms.TextBox tbTokenAdd;
        private System.Windows.Forms.ComboBox cbSchemeAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbNameAdd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.BindingSource restServerBindingSource;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.LinkLabel lnkToken;

    }
}
