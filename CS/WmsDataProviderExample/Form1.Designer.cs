namespace WmsDataProviderExample {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.XtraMap.ImageLayer imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.WmsDataProvider wmsDataProvider1 = new DevExpress.XtraMap.WmsDataProvider();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.tlLayers = new DevExpress.XtraTreeList.TreeList();
            this.tlcName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLayers)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            imageLayer1.DataProvider = wmsDataProvider1;
            imageLayer1.Name = "WmsLayer";
            this.mapControl.Layers.Add(imageLayer1);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(582, 601);
            this.mapControl.TabIndex = 0;
            // 
            // tlLayers
            // 
            this.tlLayers.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.tlcName});
            this.tlLayers.Cursor = System.Windows.Forms.Cursors.Default;
            this.tlLayers.Dock = System.Windows.Forms.DockStyle.Right;
            this.tlLayers.Location = new System.Drawing.Point(582, 0);
            this.tlLayers.Name = "tlLayers";
            this.tlLayers.OptionsBehavior.Editable = false;
            this.tlLayers.OptionsView.ShowColumns = false;
            this.tlLayers.Size = new System.Drawing.Size(173, 601);
            this.tlLayers.TabIndex = 3;
            this.tlLayers.FocusedNodeChanged += new DevExpress.XtraTreeList.FocusedNodeChangedEventHandler(this.OnFocusedNodeChanged);
            this.tlLayers.VirtualTreeGetChildNodes += new DevExpress.XtraTreeList.VirtualTreeGetChildNodesEventHandler(this.OnGetChildNodes);
            this.tlLayers.VirtualTreeGetCellValue += new DevExpress.XtraTreeList.VirtualTreeGetCellValueEventHandler(this.OnGetCellValue);
            // 
            // tlcName
            // 
            this.tlcName.Caption = "Layer Name";
            this.tlcName.FieldName = "LayerName";
            this.tlcName.Name = "tlcName";
            this.tlcName.Visible = true;
            this.tlcName.VisibleIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 601);
            this.Controls.Add(this.mapControl);
            this.Controls.Add(this.tlLayers);
            this.Name = "Form1";
            this.Text = "WmsDataProvider";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tlLayers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraTreeList.TreeList tlLayers;
        private DevExpress.XtraTreeList.Columns.TreeListColumn tlcName;
    }
}

