# Color Points by Their Arguments

In this example, the bar chart displays monthly values colored based on the season. For a complete description, refer to the following help topic: [Series Point Colorizers](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers). 

To paint bars by seasons, assign a [custom colorizer](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers#custom-point-colorizers) to a [bar series](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries)' [PointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries.PointColorizer) property. In this example, the custom colorizer selects a color depending on the month serial number.

![Apply a custom coloring rule to bars](./img/chart-custom-point.png)

<!-- default file list -->
## Files to Review
* [MainPage.xaml](./MainPage.xaml)
* [ViewModel.cs](./ViewModel.cs)
<!-- default file list end -->

## Documentation

* [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView)
* [ICustomPointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ICustomPointColorizer)
* [Series Point Colorizers](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers)