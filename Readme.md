<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_UnderlyingDataWin/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_UnderlyingDataWin/Form1.vb))
<!-- default file list end -->
# WinViewer - How to Display the Underlying Data for a Dashboard Item


This example demonstrates how to display the underlying data when an end-user double-clicks a dashboard item.

![screenshot](/images/screenshot.png)


Handle the [DashboardItem.DoubleClick](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemDoubleClick) event. Call the [e.GetUnderlyingData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardItemMouseHitTestEventArgs.GetUnderlyingData) method to retrieve records from the dashboard item's data source. Invoke a form with the Grid control that displays the data.
