﻿namespace Dashboard_UnderlyingDataWin {
    partial class SalesDashboard {
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            DevExpress.DashboardCommon.Dimension dimension1 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.GridDimensionColumn gridDimensionColumn1 = new DevExpress.DashboardCommon.GridDimensionColumn();
            DevExpress.DashboardCommon.Measure measure1 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.GridMeasureColumn gridMeasureColumn1 = new DevExpress.DashboardCommon.GridMeasureColumn();
            DevExpress.DashboardCommon.Dimension dimension2 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure2 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.Dimension dimension3 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension4 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Dimension dimension5 = new DevExpress.DashboardCommon.Dimension();
            DevExpress.DashboardCommon.Measure measure3 = new DevExpress.DashboardCommon.Measure();
            DevExpress.DashboardCommon.ChartPane chartPane1 = new DevExpress.DashboardCommon.ChartPane();
            DevExpress.DashboardCommon.SimpleSeries simpleSeries1 = new DevExpress.DashboardCommon.SimpleSeries();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup1 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutGroup dashboardLayoutGroup2 = new DevExpress.DashboardCommon.DashboardLayoutGroup();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem1 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem2 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            DevExpress.DashboardCommon.DashboardLayoutItem dashboardLayoutItem3 = new DevExpress.DashboardCommon.DashboardLayoutItem();
            this.gridDashboardItem1 = new DevExpress.DashboardCommon.GridDashboardItem();
            this.dataSource1 = new DevExpress.DashboardCommon.DataSource();
            this.nwindDataSet1 = new Dashboard_UnderlyingDataWin.nwindDataSet();
            this.pivotDashboardItem1 = new DevExpress.DashboardCommon.PivotDashboardItem();
            this.nwindDataSet2 = new Dashboard_UnderlyingDataWin.nwindDataSet();
            this.chartDashboardItem1 = new DevExpress.DashboardCommon.ChartDashboardItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // gridDashboardItem1
            // 
            dimension1.DataMember = "Sales Person";
            gridDimensionColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridDimensionColumn1.AddDataItem("Dimension", dimension1);
            measure1.DataMember = "Extended Price";
            measure1.Name = "Extended Price";
            gridMeasureColumn1.WidthType = DevExpress.DashboardCommon.GridColumnFixedWidthType.Weight;
            gridMeasureColumn1.AddDataItem("Measure", measure1);
            this.gridDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.GridColumnBase[] {
            gridDimensionColumn1,
            gridMeasureColumn1});
            this.gridDashboardItem1.ComponentName = "gridDashboardItem1";
            this.gridDashboardItem1.DataItemRepository.Clear();
            this.gridDashboardItem1.DataItemRepository.Add(dimension1, "DataItem0");
            this.gridDashboardItem1.DataItemRepository.Add(measure1, "DataItem1");
            this.gridDashboardItem1.DataSource = this.dataSource1;
            this.gridDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.gridDashboardItem1.Name = "Grid 1";
            this.gridDashboardItem1.ShowCaption = false;
            // 
            // dataSource1
            // 
            this.dataSource1.ComponentName = "dataSource1";
            this.dataSource1.Data = this.nwindDataSet1;
            this.dataSource1.DataMember = "SalesPerson";
            this.dataSource1.DataProcessingMode = DevExpress.DashboardCommon.DataProcessingMode.Client;
            this.dataSource1.Name = "Data Source 1";
            // 
            // nwindDataSet1
            // 
            this.nwindDataSet1.DataSetName = "nwindDataSet";
            this.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pivotDashboardItem1
            // 
            this.pivotDashboardItem1.AutoExpandRowGroups = true;
            dimension2.DataMember = "OrderDate";
            this.pivotDashboardItem1.Columns.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension2});
            this.pivotDashboardItem1.ComponentName = "pivotDashboardItem1";
            measure2.DataMember = "Extended Price";
            dimension3.DataMember = "CategoryName";
            dimension4.DataMember = "ProductName";
            this.pivotDashboardItem1.DataItemRepository.Clear();
            this.pivotDashboardItem1.DataItemRepository.Add(measure2, "DataItem0");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension2, "DataItem1");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension3, "DataItem2");
            this.pivotDashboardItem1.DataItemRepository.Add(dimension4, "DataItem3");
            this.pivotDashboardItem1.DataSource = this.dataSource1;
            this.pivotDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.pivotDashboardItem1.Name = "Pivot 1";
            this.pivotDashboardItem1.Rows.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension3,
            dimension4});
            this.pivotDashboardItem1.ShowCaption = false;
            this.pivotDashboardItem1.Values.AddRange(new DevExpress.DashboardCommon.Measure[] {
            measure2});
            // 
            // nwindDataSet2
            // 
            this.nwindDataSet2.DataSetName = "nwindDataSet";
            this.nwindDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // chartDashboardItem1
            // 
            dimension5.DataMember = "OrderDate";
            dimension5.Name = "Order Date";
            this.chartDashboardItem1.Arguments.AddRange(new DevExpress.DashboardCommon.Dimension[] {
            dimension5});
            this.chartDashboardItem1.AxisX.TitleVisible = false;
            this.chartDashboardItem1.ComponentName = "chartDashboardItem1";
            measure3.DataMember = "Extended Price";
            measure3.Name = "Extended Price";
            this.chartDashboardItem1.DataItemRepository.Clear();
            this.chartDashboardItem1.DataItemRepository.Add(measure3, "DataItem0");
            this.chartDashboardItem1.DataItemRepository.Add(dimension5, "DataItem1");
            this.chartDashboardItem1.DataSource = this.dataSource1;
            this.chartDashboardItem1.InteractivityOptions.IgnoreMasterFilters = false;
            this.chartDashboardItem1.Name = "Chart 1";
            chartPane1.Name = "Pane 1";
            chartPane1.PrimaryAxisY.ShowGridLines = true;
            chartPane1.PrimaryAxisY.TitleVisible = true;
            chartPane1.SecondaryAxisY.ShowGridLines = false;
            chartPane1.SecondaryAxisY.TitleVisible = true;
            simpleSeries1.AddDataItem("Value", measure3);
            chartPane1.Series.AddRange(new DevExpress.DashboardCommon.ChartSeries[] {
            simpleSeries1});
            this.chartDashboardItem1.Panes.AddRange(new DevExpress.DashboardCommon.ChartPane[] {
            chartPane1});
            this.chartDashboardItem1.ShowCaption = false;
            // 
            // SalesDashboard
            // 
            this.DataSources.AddRange(new DevExpress.DashboardCommon.DataSource[] {
            this.dataSource1});
            this.Items.AddRange(new DevExpress.DashboardCommon.DashboardItem[] {
            this.gridDashboardItem1,
            this.pivotDashboardItem1,
            this.chartDashboardItem1});
            dashboardLayoutItem1.DashboardItem = this.gridDashboardItem1;
            dashboardLayoutItem1.Weight = 45.811965811965813D;
            dashboardLayoutItem2.DashboardItem = this.chartDashboardItem1;
            dashboardLayoutItem2.Weight = 54.188034188034187D;
            dashboardLayoutGroup2.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutItem1,
            dashboardLayoutItem2});
            dashboardLayoutGroup2.DashboardItem = null;
            dashboardLayoutGroup2.Orientation = DevExpress.DashboardCommon.DashboardLayoutGroupOrientation.Vertical;
            dashboardLayoutGroup2.Weight = 31.432973805855163D;
            dashboardLayoutItem3.DashboardItem = this.pivotDashboardItem1;
            dashboardLayoutItem3.Weight = 68.567026194144844D;
            dashboardLayoutGroup1.ChildNodes.AddRange(new DevExpress.DashboardCommon.DashboardLayoutNode[] {
            dashboardLayoutGroup2,
            dashboardLayoutItem3});
            dashboardLayoutGroup1.DashboardItem = null;
            this.LayoutRoot = dashboardLayoutGroup1;
            this.Title.ImageDataSerializable = "";
            this.Title.Text = "Dashboard";
            this.Title.Visible = false;
            this.DashboardLoading += new System.EventHandler(this.SalesDashboard_DashboardLoading);
            ((System.ComponentModel.ISupportInitialize)(dimension1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pivotDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nwindDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(dimension5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(measure3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartDashboardItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private nwindDataSet nwindDataSet1;
        private DevExpress.DashboardCommon.DataSource dataSource1;
        private nwindDataSet nwindDataSet2;
        private DevExpress.DashboardCommon.PivotDashboardItem pivotDashboardItem1;
        private DevExpress.DashboardCommon.GridDashboardItem gridDashboardItem1;
        private DevExpress.DashboardCommon.ChartDashboardItem chartDashboardItem1;
    }
}
