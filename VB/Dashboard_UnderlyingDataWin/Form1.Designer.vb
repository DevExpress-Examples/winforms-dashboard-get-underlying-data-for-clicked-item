﻿Namespace Dashboard_UnderlyingDataWin
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
			Me.components = New System.ComponentModel.Container()
			Me.dashboardViewer1 = New DevExpress.DashboardWin.DashboardViewer(Me.components)
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' dashboardViewer1
			' 
			Me.dashboardViewer1.Appearance.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(160)))), (CInt((CByte(160)))), (CInt((CByte(160)))))
			Me.dashboardViewer1.Appearance.Options.UseBackColor = True
			Me.dashboardViewer1.DashboardSource = "Dashboard_UnderlyingDataWin.SalesDashboard"
			Me.dashboardViewer1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.dashboardViewer1.Location = New System.Drawing.Point(0, 0)
			Me.dashboardViewer1.Name = "dashboardViewer1"
			Me.dashboardViewer1.Size = New System.Drawing.Size(804, 472)
			Me.dashboardViewer1.TabIndex = 0
'INSTANT VB NOTE: The following InitializeComponent event wireup was converted to a 'Handles' clause:
'ORIGINAL LINE: this.dashboardViewer1.DashboardItemDoubleClick += new DevExpress.DashboardWin.DashboardItemMouseActionEventHandler(this.dashboardViewer1_DashboardItemDoubleClick);
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(804, 472)
			Me.Controls.Add(Me.dashboardViewer1)
			Me.Name = "Form1"
			Me.Text = "Dashboard Viewer"
			DirectCast(Me.dashboardViewer1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private WithEvents dashboardViewer1 As DevExpress.DashboardWin.DashboardViewer
	End Class
End Namespace

