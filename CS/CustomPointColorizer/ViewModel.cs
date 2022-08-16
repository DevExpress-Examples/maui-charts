
using DevExpress.Maui.Charts;

namespace CustomPointColorizer {
    public class ViewModel {
        public List<DataItem> Data { get; }

        public ViewModel() {
            Data = new List<DataItem>() {
                new DataItem() { Argument = new DateTime(2020, 1, 1), Value = 3 },
                new DataItem() { Argument = new DateTime(2020, 2, 1), Value = 5 },
                new DataItem() { Argument = new DateTime(2020, 3, 1), Value = 7 },
                new DataItem() { Argument = new DateTime(2020, 4, 1), Value = 2 },
                new DataItem() { Argument = new DateTime(2020, 5, 1), Value = 6 },
                new DataItem() { Argument = new DateTime(2020, 6, 1), Value = 4 },
                new DataItem() { Argument = new DateTime(2020, 7, 1), Value = 1 },
                new DataItem() { Argument = new DateTime(2020, 8, 1), Value = 8 },
                new DataItem() { Argument = new DateTime(2020, 9, 1), Value = 3 },
                new DataItem() { Argument = new DateTime(2020, 10, 1), Value = 9 },
                new DataItem() { Argument = new DateTime(2020, 11, 1), Value = 4 },
                new DataItem() { Argument = new DateTime(2020, 12, 1), Value = 7 },
            };
        }
    }

    public class DataItem {
        public DateTime Argument { get; set; }
        public double Value { get; set; }
    }

    public class CustomColorizer : ICustomPointColorizer {
        Color ICustomPointColorizer.GetColor(ColoredPointInfo info) {
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
}
