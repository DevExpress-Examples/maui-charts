# Color Points Based on String Data Source Values

In this example, the bar chart visualizes GDP values for the G20 and colors data points according to which part of the world the country belongs. 

![DevExpress Chart View for MAUI - Chart points are colored based on their values](./img/chart-color-point-by-source-values.png)

Follow the steps below to show such a chart:

* Add a [BarSeries](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries) object to the [ChartView.Series](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView.Series) collection, and specify its [Data](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.XYSeries.Data) property to bind the series to a data source.

* Initialize the bar series' [PointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries.PointColorizer) property with an object (*ColorizerByRegion* in this example) that implements the [IIndexBasedCustomPointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.IIndexBasedCustomPointColorizer) interface.

<!-- default file list -->
## Files to Review

* [MainPage.xaml](./MainPage.xaml)
* [ViewModel.cs](./ViewModel.cs)
<!-- default file list end -->

## Documentation

* [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView)
* [IIndexBasedCustomPointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.IIndexBasedCustomPointColorizer)
