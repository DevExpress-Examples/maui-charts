# Interactive Chart: Bar Selection

<img src="https://github.com/DevExpress-Examples/maui-charts/assets/12169834/b7f4f8ea-b25f-4dde-98a9-c643d03f3bbb" width="20%"/>

* Follow the steps below to implement an interactive chart. Users can select bars and see additional information associated with them.
  1. Subscribe to the [SelectionChanged](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartBaseView.SelectionChanged) event. In the event handler, update the view model's properties.
  2. Implement [INotifyPropertyChanged](https://learn.microsoft.com/en-us/dotnet/api/system.componentmodel.inotifypropertychanged?view=net-7.0) in the view model to update the view's data.
* Use the [SeriesDataAdapter.DataSource](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.DataSourceAdapterBase.DataSource) property to bind the chart to data. 

    ```<dxc:SeriesDataAdapter DataSource="{Binding Path=ComponentReplyInfos}"```
    
    Refer to the following topics for more information: [Data Adapters](https://docs.devexpress.com/MAUI/403336/charts/data-adapters).
    
* Use the [ColorEachPointColorizer](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ColorEachPointColorizer?p=netframework) to colorize each point in the bar chart. 

    Refer to the following topics for more information: [Series Point Colorizers](https://docs.devexpress.com/MAUI/403339/charts/series-point-colorizers).


## Files to Look At

* [MainPage.xaml](MainPage.xaml)
* [MainPage.xaml.cs](MainPage.xaml.cs)
* [InfoIconElement.xaml](InfoIconElement.xaml)
* [InfoIconElement.xaml.cs](InfoIconElement.xaml.cs)

## Documentation

* [Featured Scenario: Show Details of the Selected Bar in a Chart](https://docs.devexpress.com/MAUI/404470)
* [Featured Scenarios](https://docs.devexpress.com/MAUI/404291)
* [DevExpress Charts for .NET MAUI](https://docs.devexpress.com/MAUI/403300)

## More Examples

* [DevExpress Mobile UI for .NET MAUI](https://github.com/DevExpress-Examples/maui-demo-app/)
