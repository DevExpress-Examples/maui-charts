# Candlestick Financial Chart with Volume Bars, Indicators and Time Frames

This example demonstrates how to display overlay information on a financial chart: trading volume bars, financial indicators, and time frame selectors.

<img src="https://github.com/DevExpress-Examples/maui-charts/assets/12169834/27c3e4fe-0bfa-47a5-8d75-c0e21e15d6c0" width="30%"/>


## Implementation Details

* This project uses the [CandleStickSeries](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.CandleStickSeries) class to display candlestick charts. Use the [SeriesDataAdapter](https://docs.devexpress.com/MAUI/403336/charts/data-adapters#cartesian-chart-data-adapter) class to bind the chart to data according to the MVVM pattern.
    
    ```xml 
    <dxc:CandleStickSeries.Data>
        <dxc:SeriesDataAdapter DataSource="{Binding StockPrices}" ArgumentDataMember="Timestamp">
            <dxc:ValueDataMember Type="High" Member="High" />
            <dxc:ValueDataMember Type="Low" Member="Low" />
            <dxc:ValueDataMember Type="Open" Member="Open" />
            <dxc:ValueDataMember Type="Close" Member="Close" />
        </dxc:SeriesDataAdapter>
    </dxc:CandleStickSeries.Data>
    ```
* The [BarSeries](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.BarSeries?p=netframework) class gets its data from the view model and displays volume bars in the selected time frame:

    ```xml
    <dxc:SeriesDataAdapter DataSource="{Binding StockPrices}" ArgumentDataMember="Timestamp">
        <dxc:ValueDataMember Type="Value" Member="Volume" />
    </dxc:SeriesDataAdapter>
    ```
* The application allows you to display the following financial indicators on a candlestick chart:
  * [Moving Average (MA)](https://en.wikipedia.org/wiki/Moving_average)
  * [Exponential Moving Average (EMA)](https://en.wikipedia.org/wiki/Moving_average#Exponential_moving_average)
  * [Bollinger Bands (BOLL)](https://en.wikipedia.org/wiki/Bollinger_Bands)
  * [Typical Price (TPA)](https://en.wikipedia.org/wiki/Typical_price)
  
  You can display multiple indicators at the same time or show multiple instances of a single indicator with different time frames. In this project, you can display two Moving Average (MA) indicators with 7- and 25-minute time frames. Refer to the following topic for more information on the available indicators: [CandleStickSeries Indicators](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.CandleStickSeries#indicators).

* You can tap and hold a chart area to display the [Crosshair Cursor](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.CrosshairOptions) and hints. This hint displays the following information:
  * The date and time of the selected point.
  * The high, open, low, and close values of the selected point.
  * The values of the selected indicators.
  * The volume bar value.
  
  <img src="https://github.com/DevExpress-Examples/maui-charts/assets/12169834/9ab20213-076d-41c5-9aa6-a81141bbf373" width="30%"/>
  
  You can use the **HintOptions** property define hint appearance. In the following code snippet, **S** is the indicator's display name, **V** is the indicator's value, and **###.##** is the number format.
    
    ```xml
    <dxc:MovingAverageIndicator.HintOptions>
        <dxc:SeriesCrosshairOptions PointTextPattern="{}{S}: ${V$###.##}"
                                    AxisLineVisible="false"
                                    AxisLabelVisible="false" />
    </dxc:MovingAverageIndicator.HintOptions>
    ```

* This project uses the [ChoiceChipGroup](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.ChoiceChipGroup) control to display time frame selectors. Chip data comes from the collection bound to [ItemsSource](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.ChipGroup.ItemsSource). When you select a chip, the [SelectedItem](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.ChoiceChipGroup.SelectedItem) property passes it to the view model. The view model updates the candlestick chart's data source. This change also affects the chart's visible dates ([DateTimeAxisX.VisualMin](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.DateTimeRange.VisualMin), [DateTimeAxisX.VisualMax](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.DateTimeRange.VisualMax)).
* Use the [FilterChipGroup](https://docs.devexpress.com/MAUI/DevExpress.Maui.Editors.FilterChipGroup) to control the visibility of the financial indicators on the candlestick chart. The Chip.IsSelected property controls visibility of each indicator:

    ```
    <dxc:ExponentialMovingAverageIndicator Visible="{Binding Source={x:Reference emaChip}, Path=IsSelected}">
    ```
