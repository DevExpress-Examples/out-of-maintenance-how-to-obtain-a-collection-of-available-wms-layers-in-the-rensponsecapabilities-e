using DevExpress.XtraMap;
using DevExpress.XtraTreeList;
using System;
using System.Linq;
using System.Windows.Forms;

namespace WmsDataProviderExample {
    public partial class Form1 : Form {
        ImageLayer WmsLayer { get { return mapControl.Layers["WmsLayer"] as ImageLayer; } }
        WmsDataProvider Provider { get { return WmsLayer.DataProvider as WmsDataProvider; } }

        public Form1() {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e) {
            // Specify a server URI.
            Provider.ServerUri = "http://INSERT_YOUR_SERVER_URI";
            // Handle the ResponseCapabilities event.
            Provider.ResponseCapabilities += OnResponseCapabalities;
        }

        void OnResponseCapabalities(object sender, CapabilitiesRespondedEventArgs e) {
            tlLayers.DataSource = e.Layers;
        }

        private void OnGetCellValue(object sender, VirtualTreeGetCellValueInfo e) {
            WmsLayer layer = e.Node as WmsLayer;
            if (layer == null) return;

            if (e.Column.FieldName == "LayerName") {
                e.CellData = layer.Title;
            }
        }

        private void OnGetChildNodes(object sender, VirtualTreeGetChildNodesInfo e) {
            WmsLayerCollection layers = e.Node as WmsLayerCollection;
            if (layers != null) {
                e.Children = layers.ToList();
            }
            WmsLayer layer = e.Node as WmsLayer;
            if (layer != null) {
                e.Children = layer.Children.ToList();
            }
        }

        private void OnFocusedNodeChanged(object sender, FocusedNodeChangedEventArgs e) {
            WmsLayer layer = tlLayers.GetDataRecordByNode(e.Node) as WmsLayer;
            if (layer == null) return;
            Provider.ActiveLayerName = layer.Name;
            mapControl.ZoomToRegion(layer.LeftTop, layer.RightBottom, 0.15);
        }
    }
}
