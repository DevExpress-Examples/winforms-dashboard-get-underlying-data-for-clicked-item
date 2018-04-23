Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.DashboardWin
Imports DevExpress.DashboardCommon

Namespace Dashboard_UnderlyingDataWin
    Partial Public Class Form1
        Inherits XtraForm

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub dashboardViewer1_DashboardItemDoubleClick(ByVal sender As Object, _
                    ByVal e As DashboardItemMouseActionEventArgs) _
                Handles dashboardViewer1.DashboardItemDoubleClick
            Dim form As New XtraForm()
            form.Text = "Underlying Data"
            Dim underlyingData As DashboardUnderlyingDataSet = e.GetUnderlyingData()

            Dim grid As New DataGrid()
            grid.Parent = form
            grid.Dock = DockStyle.Fill
            If underlyingData IsNot Nothing Then
                grid.DataSource = underlyingData
            Else
                grid.CaptionText = "The grid has no data"
            End If
            form.ShowDialog()
            form.Dispose()
        End Sub
    End Class
End Namespace
