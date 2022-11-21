<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/393342839/22.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T1019971)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# DevExpress Pie Chart for .NET MAUI

The [DevExpress Mobile UI](https://www.devexpress.com/maui/) allows you to use a .NET cross-platform UI toolkit and C# to build native apps for iOS and Android.

![DevExpress Mobile UI for .NET MAUI](../../img/maui.png)

The **DevExpress Mobile UI for Xamarin.Forms and .NET MAUI** is free of charge. To learn more about our offer and to obtain your copy, visit [Free DevExpress Mobile UI for Xamarin.Forms and .NET MAUI](https://www.devexpress.com/xamarin-free).

## Requirements

Please register the DevExpress NuGet Gallery in Visual Studio to restore the NuGet packages used in this solution. See the following topic for more information: [Get Started with DevExpress Mobile UI for .NET MAUI](https://docs.devexpress.com/MAUI/403249/get-started).

You can also refer to the following YouTube video for more information on how to get started with the DevExpress .NET MAUI Controls: [Setting up a .NET MAUI Project](https://www.youtube.com/watch?v=juJvl5UicIQ).

## What's in This Project

The [PieChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartView) component visualizes data as a circle chart divided into slices to illustrate numerical proportion. This example allows you to get started with the **PieChartView** component and explore its basic functionality.

<img src="img/devexpress-maui-pie-chart.png" width="400"/>

### Files to Review

<!-- default file list -->
* [MauiProgram.cs](./MauiProgram.cs)
* [MainPage.xaml](./MainPage.xaml)
* [ViewModel.cs](./ViewModel.cs)
<!-- default file list end -->

## How to Run This Application

1. Install Visual Studio 2022 and the latest .NET MAUI version. See the following topic on docs.microsoft.com for more information: [.NET MAUI Installation](https://docs.microsoft.com/en-gb/dotnet/maui/get-started/installation).
1. Register [your personal NuGet feed](https://nuget.devexpress.com/) in Visual Studio.
    > If you are an active [DevExpress Universal](https://www.devexpress.com/subscriptions/universal.xml) customer, DevExpress Controls for .NET MAUI are available in your [personal NuGet feed](https://nuget.devexpress.com).

## How to Reproduce This Application

The following step-by-step tutorial details how to reproduce this application.

### Create a New Project

1. In Visual Studio 2022, create a new .NET MAUI project. Name it *PieChartGetStarted*.
    > If the wizard does not propose a template for .NET MAUI projects, you can call the following command in a CLI to create a new .NET MAUI project:
    > ```
    > dotnet new maui -n PieChartGetStarted
    > ```
1. Install the **DevExpress.Maui.Charts** package from this feed.

> DevExpress Pie Chart for .NET MAUI supports iOS and Android. The project should contain only these platforms.

### Add a Pie Chart to the Main Page

In the *MauiProgram.cs* file, call the **UseDevExpress** method to register handlers for the `PieChartView` and other DevExpress controls:

```cs
using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using DevExpress.Maui.Charts;
using PieChartGetStarted;

namespace PieChartGetStarted {
    public static class MauiProgram {
        public static MauiApp CreateMauiApp() {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseDevExpress()
                .ConfigureFonts(fonts => {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                });
            return builder.Build();
        }
    }
}
```

In the *MainPage.xaml* file, use the *dxc* prefix to declare the **DevExpress.Maui.Charts** namespace and add a [PieChartView](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartView) instance to the **ContentPage**:
```xaml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PieChartGetStarted.MainPage"
             xmlns:dxc="clr-namespace:DevExpress.Maui.Charts;assembly=DevExpress.Maui.Charts">
        <dxc:PieChartView>
        </dxc:PieChartView>
</ContentPage>
```

### Populate the Pie Chart with Data
In this example, the pie chart compares countries by area. Create a *ViewModel.cs* file with the following classes: 

```cs
using System.Collections.Generic;
using Microsoft.Maui.Graphics;

class ViewModel {
    public IReadOnlyList<LandAreaItem> LandAreas { get; }

    public ViewModel() {
        LandAreas = new List<LandAreaItem>() {
            new LandAreaItem("Russia", 17.098),
            new LandAreaItem("Canada", 9.985),
            new LandAreaItem("People's Republic of China", 9.597),
            new LandAreaItem("United States of America", 9.834),
            new LandAreaItem("Brazil", 8.516),
            new LandAreaItem("Australia", 7.692),
            new LandAreaItem("India", 3.287),
            new LandAreaItem("Others", 81.2)
        };
    }
}

class LandAreaItem {
    public string CountryName { get; }
    public double Area { get; }

    public LandAreaItem(string countryName, double area) {
        this.CountryName = countryName;
        this.Area = area;
    }
}
```

In the *MainPage.xaml* file, add a new [DonutSeries](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.DonutSeries) object to the [PieChartView.Series](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartView.Series) collection. To bind the series to data, set the [DonutSeries.Data](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeries.Data) property to a [PieSeriesDataAdapter](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeriesDataAdapter) object. Use the adapter’s properties to specify the data source and its fields that contain values and labels for series points:

```xaml
<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="PieChartGetStarted.MainPage"
             xmlns:local="clr-namespace:PieChartGetStarted"
             xmlns:dxc="clr-namespace:DevExpress.Maui.Charts;assembly=DevExpress.Maui.Charts">
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <dxc:PieChartView>
        <dxc:PieChartView.Series>
            <dxc:DonutSeries>
                <dxc:DonutSeries.Data>
                    <dxc:PieSeriesDataAdapter DataSource="{Binding LandAreas}"
                                              LabelDataMember="CountryName"
                                              ValueDataMember="Area"/>
                </dxc:DonutSeries.Data>
            </dxc:DonutSeries>
        </dxc:PieChartView.Series>
    </dxc:PieChartView>
</ContentPage>
```

### Add a Legend to the Pie Chart
Create a [Legend](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.Legend) object, change its settings, and assign it to the [PieChartView.Legend](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartBaseView.Legend) property:

```xaml
<dxc:PieChartView>
    <!--...-->
    <dxc:PieChartView.Legend>
        <dxc:Legend Orientation="TopToBottom"
                    HorizontalPosition="Center"
                    VerticalPosition="BottomOutside"/>
    </dxc:PieChartView.Legend>
</dxc:PieChartView>
```

### Enable Series Labels
Set the [DonutSeries.Label](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeries.Label) property to a [PieSeriesLabel](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeriesLabel) object with the specified [TextPattern](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.SeriesLabel.TextPattern), [Position](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeriesLabel.Position), and [Indent](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.SeriesLabel.Indent) settings:
```xaml
<dxc:PieChartView>
    <dxc:PieChartView.Series>
        <dxc:DonutSeries>
            <!--...-->
            <dxc:DonutSeries.Label>
                <dxc:PieSeriesLabel TextPattern="{}{VP}%" Position="TwoColumns" Indent="20"/>
            </dxc:DonutSeries.Label>
        </dxc:DonutSeries>
    </dxc:PieChartView.Series>
</dxc:PieChartView>
```

### Enable Tooltips for Chart Segments
To show hints, set the [PieChartView.Hint](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartView.Hint) property to a [PieHint](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieHint) object with its [Enabled](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.HintBase.Enabled) property set to **True**:

```xaml
<dxc:PieChartView>
    <dxc:PieChartView.Hint>
        <dxc:PieHint Enabled="True"/>
    </dxc:PieChartView.Hint>
    <!--...-->
</dxc:PieChartView>
```

Specify the text pattern for tooltips of donut segments:
```xaml
<dxc:PieChartView>
    <!--...-->
    <dxc:PieChartView.Series>
        <dxc:DonutSeries>
            <!--...-->
            <dxc:DonutSeries.HintOptions>
                <dxc:PieSeriesHintOptions PointTextPattern="{}{L}: {V}M sq km"/>
            </dxc:DonutSeries.HintOptions>
        </dxc:DonutSeries>
    </dxc:PieChartView.Series>
</dxc:PieChartView>
```

### Modify the Pie Chart Appearance

In the view model, define a palette of custom colors for donut segments:
```cs
using Microsoft.Maui.Graphics;
// ...
class ViewModel {
    // ...
    readonly Color[] palette;
    public Color[] Palette => palette;

    public ViewModel() {
        // ...
        palette = PaletteLoader.LoadPalette("#975ba5", "#03bfc1", "#f8c855", "#f45a4e",
                                            "#496cbe", "#f58f35", "#d293fd", "#25a966");}
}

static class PaletteLoader {
    public static Color[] LoadPalette(params string[] values) {
        Color[] colors = new Color[values.Length];
        for (int i = 0; i < values.Length; i++)
            colors[i] = Color.FromArgb(values[i]);
        return colors;
    }
}
```

Set the [PieChartView.ChartStyle](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartView.ChartStyle) property to a [PieChartStyle](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartStyle) object with the specified [Palette](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartStyleBase.Palette) and [BackgroundColor](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.ChartStyleBase.BackgroundColor) properties to change the chart's color scheme:
```xaml
<ContentPage>
    <ContentPage.BindingContext>
        <local:ViewModel/>
    </ContentPage.BindingContext>
    <dxc:PieChartView>
        <!--...-->
        <dxc:PieChartView.ChartStyle>
            <dxc:PieChartStyle Palette="{Binding Palette}" 
                               BackgroundColor="#2d313d"/>
        </dxc:PieChartView.ChartStyle>
    </dxc:PieChartView>
</ContentPage>
```

Use the [PieChartView.SelectionBehavior](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieChartView.SelectionBehavior) property to specify how to highlight a donut segment when a user selects it:
```xaml
<dxc:PieChartView SelectionBehavior="Hatch">
    <!--...-->
</dxc:PieChartView>
```

To change the legend appearance, set the [Legend.Style](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.Legend.Style) property to a [LegendStyle](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.LegendStyle) object, and specify this object's properties to customize the legend's border, background, and items:
```xaml
<dxc:PieChartView.Legend>
    <dxc:Legend>
        <dxc:Legend.Style>
            <dxc:LegendStyle BorderColor="LightGray" BorderThickness="1"
                             BackgroundColor="#424651"
                             MarkerSize="18" TextIndent="6"
                             ItemsVerticalIndent="12">
                <dxc:LegendStyle.TextStyle>
                    <dxc:TextStyle Color="White" Size="12"/>
                </dxc:LegendStyle.TextStyle>
            </dxc:LegendStyle>
        </dxc:Legend.Style>
    </dxc:Legend>
</dxc:PieChartView.Legend>
```

Change text settings and connector thickness for the pie chart's labels. To do this, set the [PieSeriesLabel.Style](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeriesLabel.Style) property to a [PieSeriesLabelStyle](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeriesLabelStyle) object with the specified [TextStyle](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.TextElementStyleBase.TextStyle) and [ConnectorThickness](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.PieSeriesLabelStyle.ConnectorThickness) properties:
```xaml
<dxc:PieChartView>
    <dxc:PieChartView.Series>
            <dxc:DonutSeries>
                <!--...-->
                <dxc:DonutSeries.Label>
                    <dxc:PieSeriesLabel Position="TwoColumns" TextPattern="{}{VP}%" Indent="20">
                        <dxc:PieSeriesLabel.Style>
                            <dxc:PieSeriesLabelStyle ConnectorThickness="1">
                                <dxc:PieSeriesLabelStyle.TextStyle>
                                    <dxc:TextStyle Color="#eff2f6" Size="12"/>
                                </dxc:PieSeriesLabelStyle.TextStyle>
                            </dxc:PieSeriesLabelStyle>
                        </dxc:PieSeriesLabel.Style>
                    </dxc:PieSeriesLabel>
                </dxc:DonutSeries.Label>
        </dxc:DonutSeries>
    </dxc:PieChartView.Series>
</dxc:PieChartView>
```

Use the [BackgroundColor](https://docs.devexpress.com/MAUI/DevExpress.Maui.Charts.HintStyleBase.BackgroundColor) property to change the background of hints:
```xaml
<dxc:PieChartView>
    <dxc:PieChartView.Hint>
        <dxc:PieHint Enabled="True">
            <dxc:PieHint.Style>
                <dxc:PieHintStyle BackgroundColor="#424651"/>
            </dxc:PieHint.Style>
        </dxc:PieHint>
    </dxc:PieChartView.Hint>
</dxc:PieChartView>
```


## Documentation

[Pie Chart for .NET MAUI - Get Started](https://docs.devexpress.com/MAUI/403299/charts/pie-chart/get-started)

## More Examples
* [Stocks App](https://github.com/DevExpress-Examples/maui-stocks-mini)
* [Data Form](https://github.com/DevExpress-Examples/maui-data-form-get-started)
* [Data Editors](https://github.com/DevExpress-Examples/maui-editors-get-started)
* [Data Grid](https://github.com/DevExpress-Examples/maui-data-grid)
* [Scheduler](https://github.com/DevExpress-Examples/maui-scheduler-get-started)
* [Tab Page](https://github.com/DevExpress-Examples/maui-tab-page-get-started)
* [Tab View](https://github.com/DevExpress-Examples/maui-tab-view-get-started)
* [Drawer Page](https://github.com/DevExpress-Examples/maui-drawer-page-get-started)
* [Drawer View](https://github.com/DevExpress-Examples/maui-drawer-view-get-started)
* [Collection View](https://github.com/DevExpress-Examples/maui-collection-view-get-started)
* [Popup](https://github.com/DevExpress-Examples/maui-popup-get-started)