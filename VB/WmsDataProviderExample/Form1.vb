Imports DevExpress.XtraMap
Imports DevExpress.XtraTreeList
Imports System
Imports System.Linq
Imports System.Windows.Forms

Namespace WmsDataProviderExample
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property WmsLayer() As ImageLayer
            Get
                Return TryCast(mapControl.Layers("WmsLayer"), ImageLayer)
            End Get
        End Property
        Private ReadOnly Property Provider() As WmsDataProvider
            Get
                Return TryCast(WmsLayer.DataProvider, WmsDataProvider)
            End Get
        End Property

        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Specify a server URI.
            Provider.ServerUri = "http://INSERT_YOUR_SERVER_URI"
            ' Handle the ResponseCapabilities event.
            AddHandler Provider.ResponseCapabilities, AddressOf OnResponseCapabalities
        End Sub

        Private Sub OnResponseCapabalities(ByVal sender As Object, ByVal e As CapabilitiesResponsedEventArgs)
            tlLayers.DataSource = e.Layers
        End Sub

        Private Sub OnGetCellValue(ByVal sender As Object, ByVal e As VirtualTreeGetCellValueInfo) Handles tlLayers.VirtualTreeGetCellValue
            Dim layer As WmsLayer = TryCast(e.Node, WmsLayer)
            If layer Is Nothing Then
                Return
            End If

            If e.Column.FieldName = "LayerName" Then
                e.CellData = layer.Title
            End If
        End Sub

        Private Sub OnGetChildNodes(ByVal sender As Object, ByVal e As VirtualTreeGetChildNodesInfo) Handles tlLayers.VirtualTreeGetChildNodes
            Dim layers As WmsLayerCollection = TryCast(e.Node, WmsLayerCollection)
            If layers IsNot Nothing Then
                e.Children = layers.ToList()
            End If
            Dim layer As WmsLayer = TryCast(e.Node, WmsLayer)
            If layer IsNot Nothing Then
                e.Children = layer.Children.ToList()
            End If
        End Sub

        Private Sub OnFocusedNodeChanged(ByVal sender As Object, ByVal e As FocusedNodeChangedEventArgs) Handles tlLayers.FocusedNodeChanged
            Dim layer As WmsLayer = TryCast(tlLayers.GetDataRecordByNode(e.Node), WmsLayer)
            If layer Is Nothing Then
                Return
            End If
            Provider.ActiveLayerName = layer.Name
            mapControl.ZoomToRegion(layer.LeftTop, layer.RightBottom, 0.15)
        End Sub
    End Class
End Namespace
