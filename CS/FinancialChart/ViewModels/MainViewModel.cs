
using DevExpress.Maui.Charts;

namespace FinancialChart {
    public class MainViewModel {
        public StockPrices StockPrices { get; }
        public DateTimeRange VisualRange { get; }

        public MainViewModel() {
            StockPrices = StockData.GetStockPrices();
            VisualRange = new DateTimeRange() {
                VisualMin = new System.DateTime(2020, 04, 07),
                VisualMax = new System.DateTime(2020, 07, 07)
            };
        }
    }
}
