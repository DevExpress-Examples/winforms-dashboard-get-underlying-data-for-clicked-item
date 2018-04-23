﻿Imports System
Imports Dashboard_UnderlyingDataWin.nwindDataSetTableAdapters

Namespace Dashboard_UnderlyingDataWin
    Partial Public Class SalesDashboard
        Inherits DevExpress.DashboardCommon.Dashboard

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub SalesDashboard_DashboardLoading(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.DashboardLoading
            Dim categories As New SalesPersonTableAdapter()
            categories.Fill(Me.nwindDataSet1.SalesPerson)
        End Sub
    End Class
End Namespace
