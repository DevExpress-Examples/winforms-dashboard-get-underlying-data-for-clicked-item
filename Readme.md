<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581468/14.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T129135)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Dashboard_UnderlyingDataWin/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_UnderlyingDataWin/Form1.vb))
<!-- default file list end -->
# WinViewer - How to obtain a dashboard item's underlying data for a clicked visual element


<p>The following example demonstrates how to obtain underlying data corresponding to a particular visual element using the DashboardViewer's API.</p>
<p>In this example, the <a href="http://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardViewer_DashboardItemDoubleClicktopic">DashboardItemDoubleClick</a> event is handled to obtain underlying data and display this data in the grid.</p>
<p>In the event handler, the <a href="https://documentation.devexpress.com/#Dashboard/DevExpressDashboardWinDashboardItemMouseHitTestEventArgs_GetUnderlyingDatatopic195">GetUnderlyingData</a> method is called to obtain records from the dashboard's data source.</p>

<br/>


