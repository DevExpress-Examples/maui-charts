using DevExpress.Maui.Charts;
using System.Globalization;

namespace SeriesLabelTextProvider {
    public partial class MainPage : ContentPage {
        public MainPage() {
            InitializeComponent();

            PieSeries pieSeries = new PieSeries() {
                Data = new PieSeriesDataAdapter() {
                    LabelDataMember = "Label",
                    ValueDataMember = "Value",
                    DataSource = new List<DataItem>() {
                        new DataItem() { Label = "AAA", Value = 1230000 },
                        new DataItem() { Label = "BBB", Value = 3330000 },
                        new DataItem() { Label = "CCC", Value = 2100000 },
                    }
                },
                Label = new PieSeriesLabel() {
                    Position = PieSeriesLabelPosition.Inside,
                    TextProvider = new LabelTextProvider(),
                    Style = new PieSeriesLabelStyle() {
                        TextStyle = new TextStyle() {
                            Size = 18
                        }
                    }
                }
            };
            pieChart.Series.Add(pieSeries);
        }
    }

    public class LabelTextProvider : ISeriesLabelTextProvider {
        string ISeriesLabelTextProvider.GetText(SeriesLabelValuesBase values) {
            if (values is PieSeriesLabelValues seriesValues) {
                double v = seriesValues.Value;
                if (v >= 1000000000 || v <= -1000000000)
                    return (v / 1000000000.0).ToString("$#.###B", CultureInfo.InvariantCulture);
                else if (v >= 1000000 || v <= -1000000)
                    return (v / 1000000.0).ToString("$#.###M", CultureInfo.InvariantCulture);
                else if (v >= 1000 || v <= -1000)
                    return (v / 1000.0).ToString("$#.###K", CultureInfo.InvariantCulture);
                else
                    return v.ToString();
            }
            return String.Empty;
        }
    }

    public class DataItem {
        public string Label { get; set; }
        public double Value { get; set; }
    }
}