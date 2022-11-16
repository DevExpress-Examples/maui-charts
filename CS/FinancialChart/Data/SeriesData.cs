using DevExpress.Maui.Charts;

namespace FinancialChart {
    public class XYSeriesData : IXYSeriesData {
        StockPrices stockPrices;
        SeriesDataType seriesDataType;

        public XYSeriesData(StockPrices stockPrices, SeriesDataType seriesDataType) {
            this.stockPrices = stockPrices;
            this.seriesDataType = seriesDataType;
        }

        public int GetDataCount() => stockPrices.Count;
        public SeriesDataType GetDataType() => seriesDataType;
        public DateTime GetDateTimeArgument(int index) => stockPrices[index].Date;
        public double GetValue(DevExpress.Maui.Charts.ValueType valueType, int index) {
            switch (valueType) {
                case DevExpress.Maui.Charts.ValueType.Value: return stockPrices[index].Volume;
                case DevExpress.Maui.Charts.ValueType.High: return stockPrices[index].High;
                case DevExpress.Maui.Charts.ValueType.Low: return stockPrices[index].Low;
                case DevExpress.Maui.Charts.ValueType.Open: return stockPrices[index].Open;
                case DevExpress.Maui.Charts.ValueType.Close: return stockPrices[index].Close;
            }
            return 0;
        }
        public double GetNumericArgument(int index) { return 0; }
        public string GetQualitativeArgument(int index) { return string.Empty; }
        public object GetKey(int index) => null;
    }

    public class CalculatedSeriesData : BindableObject, ICalculatedSeriesData {
        public CalculatedSeriesData() {
        }

        public Series Series {
            get => null;
        }
    }
}
