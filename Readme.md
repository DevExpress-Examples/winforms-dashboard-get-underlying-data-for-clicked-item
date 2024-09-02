<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128581468/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T129135)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Dashboard for WinForms - How to Display the Underlying Data for a Dashboard Item

This example demonstrates how to display the underlying data when an end-user double-clicks a dashboard item.

![screenshot](/images/screenshot.png)

The example handles the [DashboardItem.DoubleClick](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardViewer.DashboardItemDoubleClick) event, calls the [e.GetUnderlyingData](https://docs.devexpress.com/Dashboard/DevExpress.DashboardWin.DashboardItemMouseHitTestEventArgs.GetUnderlyingData) method to retrieve records from the dashboard item's data source and invokes a form with the Grid control that displays the data.

> Starting with v19.2 you can use the built-in [Data Inspector](https://docs.devexpress.com/Dashboard/401194/common-features/underlying-and-displayed-data/data-inspector) to display the underlying data.

## Files to Review

* [Form1.cs](./CS/Dashboard_UnderlyingDataWin/Form1.cs) (VB: [Form1.vb](./VB/Dashboard_UnderlyingDataWin/Form1.vb))

## Documentation

- [Obtain Underlying and Displayed Data](https://docs.devexpress.com/Dashboard/17269/winforms-dashboard/winforms-viewer/obtaining-underlying-and-displayed-data)
- [Data Inspector](https://docs.devexpress.com/Dashboard/401194/common-features/underlying-and-displayed-data/data-inspector)

## More Examples

- [Dashboard for WinForms - How to Get and Process the Dashboard Item's Underlying Data](https://github.com/DevExpress-Examples/how-to-obtain-a-dashboard-items-client-data-in-the-winforms-viewer-t140553)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-get-underlying-data-for-clicked-item&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-dashboard-get-underlying-data-for-clicked-item&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
