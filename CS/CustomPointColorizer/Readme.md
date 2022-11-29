# Color Points by Their Arguments

In this example, the bar chart displays monthly values colored based on the season. For a complete description, refer to the following help topic: [Series Point Colorizers](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers). 

![Apply a custom coloring rule to bars](./img/chart-custom-point.png)

To paint bars according to the season, assign a [custom colorizer](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers#custom-point-colorizers) to a [bar series](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries)' [PointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries.PointColorizer) property. In this example, the custom colorizer selects a color depending on the month's serial number.

```xaml
<dxc:BarSeries PointColorizer="{local:CustomColorizer}">
    <!--...-->
</dxc:BarSeries>
```

```cs
public class CustomColorizer : ICustomPointColorizer {
    Color ICustomPointColorizer.GetColor(ColoredPointInfo info
        switch (info.DateTimeArgument.Month) {
            case 12:
            case 1:
            case 2:
            default:
                return Color.FromHex("#5982db");
            case 3:
            case 4:
            case 5:
                return Color.FromHex("#755dd9");
            case 6:
            case 7:
            case 8:
                return Color.FromHex("#9b57d3");
            case 9:
            case 10:
            case 11:
                return Color.FromHex("#92278f");
        }
    }
    public ILegendItemProvider GetLegendItemProvider() {
        return null;
    }
}
```


<!-- default file list -->
## Files to Review
* [MainPage.xaml](./MainPage.xaml)
* [ViewModel.cs](./ViewModel.cs)
<!-- default file list end -->

## Documentation

* [ChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartView)
* [ICustomPointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ICustomPointColorizer)
* [Series Point Colorizers](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers)
