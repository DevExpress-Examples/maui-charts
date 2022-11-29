# Fill Area Series by Segments

In this example, the area chart visualizes the visible light spectrum.

<img src="./img/area-series-segment-colorizer.png" width="85%" alt="Area series with custom fill"/>

Follow the steps below to show such a chart:

* Add an [Area Series](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.AreaSeries) object to the [ChartView.Series](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView.Series) collection, and set its [Data](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.XYSeries.Data) property to bind the series to a data source.

* Set the series' [FillColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.AreaSeries.FillColorizer) property to a [SegmentBasedFillColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.SegmentBasedFillColorizer) object and configure its options to define area fill settings.

<!-- default file list -->
## Files to Review

* [MainPage.xaml](./MainPage.xaml)
* [ViewModel.cs](./ViewModel.cs)
<!-- default file list end -->

## Documentation

* [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView)
* [SegmentBasedFillColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.SegmentBasedFillColorizer)