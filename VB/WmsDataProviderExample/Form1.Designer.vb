Namespace WmsDataProviderExample
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim imageLayer1 As New DevExpress.XtraMap.ImageLayer()
            Dim wmsDataProvider1 As New DevExpress.XtraMap.WmsDataProvider()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.tlLayers = New DevExpress.XtraTreeList.TreeList()
            Me.tlcName = New DevExpress.XtraTreeList.Columns.TreeListColumn()
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.tlLayers, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl
            ' 
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            imageLayer1.DataProvider = wmsDataProvider1
            imageLayer1.Name = "WmsLayer"
            Me.mapControl.Layers.Add(imageLayer1)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(582, 601)
            Me.mapControl.TabIndex = 0
            ' 
            ' tlLayers
            ' 
            Me.tlLayers.Columns.AddRange(New DevExpress.XtraTreeList.Columns.TreeListColumn() { Me.tlcName})
            Me.tlLayers.Cursor = System.Windows.Forms.Cursors.Default
            Me.tlLayers.Dock = System.Windows.Forms.DockStyle.Right
            Me.tlLayers.Location = New System.Drawing.Point(582, 0)
            Me.tlLayers.Name = "tlLayers"
            Me.tlLayers.OptionsBehavior.Editable = False
            Me.tlLayers.OptionsView.ShowColumns = False
            Me.tlLayers.Size = New System.Drawing.Size(173, 601)
            Me.tlLayers.TabIndex = 3
            ' 
            ' tlcName
            ' 
            Me.tlcName.Caption = "Layer Name"
            Me.tlcName.FieldName = "LayerName"
            Me.tlcName.Name = "tlcName"
            Me.tlcName.Visible = True
            Me.tlcName.VisibleIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(755, 601)
            Me.Controls.Add(Me.mapControl)
            Me.Controls.Add(Me.tlLayers)
            Me.Name = "Form1"
            Me.Text = "WmsDataProvider"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.tlLayers, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private WithEvents tlLayers As DevExpress.XtraTreeList.TreeList
        Private tlcName As DevExpress.XtraTreeList.Columns.TreeListColumn
    End Class
End Namespace

