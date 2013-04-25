using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;

namespace ClearCache
{
    /// <summary>
    /// Command to invoke the REST admin clear
    /// </summary>
    public class ClearCommand : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        private IDockableWindow _dockWindow;

        protected override void OnClick()
        {
            // Only get/create the dockable window if they ask for it
            if (_dockWindow == null)
            {
                // Use GetDockableWindow directly instead of FromID as we want the client IDockableWindow not the internal class
                UID dockWinId = new UIDClass { Value = ThisAddIn.IDs.ClearUI };
                _dockWindow = ArcCatalog.DockableWindowManager.GetDockableWindow(dockWinId);
            }
            
            if (_dockWindow == null)
                return;

            _dockWindow.Show(!_dockWindow.IsVisible());
        }
        
    }
}
