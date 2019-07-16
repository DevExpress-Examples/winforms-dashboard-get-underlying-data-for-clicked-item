Imports DevExpress.DashboardCommon
Imports DevExpress.DashboardWin
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports System.Windows.Forms

Namespace Dashboard_UnderlyingDataWin
	Partial Public Class Form1
		Inherits XtraForm

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub dashboardViewer1_DashboardItemDoubleClick(ByVal sender As Object, ByVal e As DashboardItemMouseActionEventArgs) Handles dashboardViewer1.DashboardItemDoubleClick
			Dim form As XtraForm = New XtraForm With {.Text = "Underlying Data"}
			Dim underlyingData As DashboardUnderlyingDataSet = e.GetUnderlyingData()


			If underlyingData IsNot Nothing AndAlso underlyingData.RowCount > 0 Then
				Dim grid As DevExpress.XtraGrid.GridControl = New DevExpress.XtraGrid.GridControl With {.Parent = form, .Dock = DockStyle.Fill, .DataSource = underlyingData}
			Else
				Dim lbl As LabelControl = New LabelControl With {.Text = "No Data", .Parent = form}
				lbl.AutoSizeMode = LabelAutoSizeMode.None
				lbl.Appearance.TextOptions.HAlignment = HorzAlignment.Center
				lbl.Appearance.TextOptions.VAlignment = VertAlignment.Center
				lbl.Dock = DockStyle.Fill
			End If

			form.ShowDialog()
			form.Dispose()
		End Sub
	End Class
End Namespace
