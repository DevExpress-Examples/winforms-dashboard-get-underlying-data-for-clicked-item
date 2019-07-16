Namespace Dashboard_UnderlyingDataWin
	Partial Public Class SalesDashboard
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

		#Region "Component Designer generated code"

		''' <summary> 
		''' Required method for Designer support - do not modify 
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim dimension1 As New DevExpress.DashboardCommon.Dimension()
			Dim gridDimensionColumn1 As New DevExpress.DashboardCommon.GridDimensionColumn()
			Dim measure1 As New DevExpress.DashboardCommon.Measure()
			Dim gridMeasureColumn1 As New DevExpress.DashboardCommon.GridMeasureColumn()
			Dim dimension2 As New DevExpress.DashboardCommon.Dimension()
			Dim measure2 As New DevExpress.DashboardCommon.Measure()
			Dim chartPane1 As New DevExpress.DashboardCommon.ChartPane()
			Dim simpleSeries1 As New DevExpress.DashboardCommon.SimpleSeries()
			Dim dimension3 As New DevExpress.DashboardCommon.Dimension()
			Dim measure3 As New DevExpress.DashboardCommon.Measure()
			Dim dimension4 As New DevExpress.DashboardCommon.Dimension()
			Dim dimension5 As New DevExpress.DashboardCommon.Dimension()
			Dim dashboardLayoutGroup1 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutGroup2 As New DevExpress.DashboardCommon.DashboardLayoutGroup()
			Dim dashboardLayoutItem1 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem2 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Dim dashboardLayoutItem3 As New DevExpress.DashboardCommon.DashboardLayoutItem()
			Me.gridDashboardItem1 = New DevExpress.DashboardCommon.GridDashboardItem()
			Me.nwindDataSet1 = New Dashboard_UnderlyingDataWin.nwindDataSet()
			Me.chartDashboardItem1 = New DevExpress.DashboardCommon.ChartDashboardItem()
			Me.pivotDashboardItem1 = New DevExpress.DashboardCommon.PivotDashboardItem()
			Me.nwindDataSet2 = New Dashboard_UnderlyingDataWin.nwindDataSet()
			Me.dashboardObjectDataSource1 = New DevExpress.DashboardCommon.DashboardObjectDataSource()
			Me.nwindDataSet3 = New Dashboard_UnderlyingDataWin.nwindDataSet()
			Me.salesPersonTableAdapter1 = New Dashboard_UnderlyingDataWin.nwindDataSetTableAdapters.SalesPersonTableAdapter()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(measure3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension4, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(dimension5, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me.nwindDataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
			' 
			' gridDashboardItem1
			' 
			dimension1.DataMember = "Sales Person"
			gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridDimensionColumn1.AddDataItem("Dimension", dimension1)
			measure1.DataMember = "Extended Price"
			gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight
			gridMeasureColumn1.AddDataItem("Measure", measure1)
			Me.gridDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.GridColumnBase() { gridDimensionColumn1, gridMeasureColumn1})
			Me.gridDashboardItem1.ComponentName = "gridDashboardItem1"
			Me.gridDashboardItem1.DataItemRepository.Clear()
			Me.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0")
			Me.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1")
			Me.gridDashboardItem1.DataSource = Me.dashboardObjectDataSource1
			Me.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.gridDashboardItem1.Name = "Grid 1"
			Me.gridDashboardItem1.ShowCaption = False
			' 
			' nwindDataSet1
			' 
			Me.nwindDataSet1.DataSetName = "nwindDataSet"
			Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' chartDashboardItem1
			' 
			dimension2.DataMember = "OrderDate"
			dimension2.Name = "Order Date"
			Me.chartDashboardItem1.Arguments.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension2})
			Me.chartDashboardItem1.AxisX.TitleVisible = False
			Me.chartDashboardItem1.ComponentName = "chartDashboardItem1"
			measure2.DataMember = "Extended Price"
			measure2.Name = "Extended Price"
			Me.chartDashboardItem1.DataItemRepository.Clear()
			Me.chartDashboardItem1.DataItemRepository.Add(measure2, "DataItem0")
			Me.chartDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1")
			Me.chartDashboardItem1.DataSource = Me.dashboardObjectDataSource1
			Me.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.chartDashboardItem1.Name = "Chart 1"
			chartPane1.Name = "Pane 1"
			chartPane1.PrimaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.PrimaryAxisY.ShowGridLines = True
			chartPane1.PrimaryAxisY.TitleVisible = True
			chartPane1.SecondaryAxisY.AlwaysShowZeroLevel = True
			chartPane1.SecondaryAxisY.ShowGridLines = False
			chartPane1.SecondaryAxisY.TitleVisible = True
			simpleSeries1.AddDataItem("Value", measure2)
			chartPane1.Series.AddRange(New DevExpress.DashboardCommon.ChartSeries() { simpleSeries1})
			Me.chartDashboardItem1.Panes.AddRange(New DevExpress.DashboardCommon.ChartPane() { chartPane1})
			Me.chartDashboardItem1.ShowCaption = False
			' 
			' pivotDashboardItem1
			' 
			Me.pivotDashboardItem1.AutoExpandRowGroups = True
			dimension3.DataMember = "OrderDate"
			Me.pivotDashboardItem1.Columns.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension3})
			Me.pivotDashboardItem1.ComponentName = "pivotDashboardItem1"
			measure3.DataMember = "Extended Price"
			dimension4.DataMember = "CategoryName"
			dimension5.DataMember = "ProductName"
			Me.pivotDashboardItem1.DataItemRepository.Clear()
			Me.pivotDashboardItem1.DataItemRepository.Add(measure3, "DataItem0")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem1")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem2")
			Me.pivotDashboardItem1.DataItemRepository.Add(dimension5, "DataItem3")
			Me.pivotDashboardItem1.DataSource = Me.dashboardObjectDataSource1
			Me.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = False
			Me.pivotDashboardItem1.LayoutType = DevExpress.DashboardCommon.PivotLayoutType.Compact
			Me.pivotDashboardItem1.Name = "Pivot 1"
			Me.pivotDashboardItem1.Rows.AddRange(New DevExpress.DashboardCommon.Dimension() { dimension4, dimension5})
			Me.pivotDashboardItem1.ShowCaption = False
			Me.pivotDashboardItem1.Values.AddRange(New DevExpress.DashboardCommon.Measure() { measure3})
			' 
			' nwindDataSet2
			' 
			Me.nwindDataSet2.DataSetName = "nwindDataSet"
			Me.nwindDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' dashboardObjectDataSource1
			' 
			Me.dashboardObjectDataSource1.ComponentName = "dashboardObjectDataSource1"
			Me.dashboardObjectDataSource1.DataMember = "SalesPerson"
			Me.dashboardObjectDataSource1.DataSource = Me.nwindDataSet3
			Me.dashboardObjectDataSource1.Name = "Object Data Source 1"
			' 
			' nwindDataSet3
			' 
			Me.nwindDataSet3.DataSetName = "nwindDataSet"
			Me.nwindDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' salesPersonTableAdapter1
			' 
			Me.salesPersonTableAdapter1.ClearBeforeFill = True
			' 
			' SalesDashboard
			' 
			Me.DataSources.AddRange(New DevExpress.DashboardCommon.IDashboardDataSource() { Me.dashboardObjectDataSource1})
			Me.Items.AddRange(New DevExpress.DashboardCommon.DashboardItem() { Me.gridDashboardItem1, Me.pivotDashboardItem1, Me.chartDashboardItem1})
			dashboardLayoutItem1.DashboardItem = Me.gridDashboardItem1
			dashboardLayoutItem1.Weight = 45.811965811965813R
			dashboardLayoutItem2.DashboardItem = Me.chartDashboardItem1
			dashboardLayoutItem2.Weight = 54.188034188034187R
			dashboardLayoutGroup2.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutItem1, dashboardLayoutItem2})
			dashboardLayoutGroup2.DashboardItem = Nothing
			dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical
			dashboardLayoutGroup2.Weight = 31.432973805855163R
			dashboardLayoutItem3.DashboardItem = Me.pivotDashboardItem1
			dashboardLayoutItem3.Weight = 68.567026194144844R
			dashboardLayoutGroup1.ChildNodes.AddRange(New DevExpress.DashboardCommon.DashboardLayoutNode() { dashboardLayoutGroup2, dashboardLayoutItem3})
			dashboardLayoutGroup1.DashboardItem = Nothing
			Me.LayoutRoot = dashboardLayoutGroup1
			Me.Title.Text = "Dashboard"
			Me.Title.Visible = False
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.DashboardLoading += new System.EventHandler(this.SalesDashboard_DashboardLoading);
			DirectCast(dimension1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.gridDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.chartDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(measure3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension4, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(dimension5, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.pivotDashboardItem1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.dashboardObjectDataSource1, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me.nwindDataSet3, System.ComponentModel.ISupportInitialize).EndInit()
			DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

		End Sub

		#End Region

		Private nwindDataSet1 As nwindDataSet
		Private nwindDataSet2 As nwindDataSet
		Private pivotDashboardItem1 As DevExpress.DashboardCommon.PivotDashboardItem
		Private gridDashboardItem1 As DevExpress.DashboardCommon.GridDashboardItem
		Private chartDashboardItem1 As DevExpress.DashboardCommon.ChartDashboardItem
		Private dashboardObjectDataSource1 As DevExpress.DashboardCommon.DashboardObjectDataSource
		Private nwindDataSet3 As nwindDataSet
		Private salesPersonTableAdapter1 As nwindDataSetTableAdapters.SalesPersonTableAdapter
	End Class
End Namespace
