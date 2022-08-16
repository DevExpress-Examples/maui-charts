using DevExpress.Maui.Charts;

namespace ValueRangeColorizer
{
    public class ViewModel {
        public List<CryptocurrencyPortfolioItem> CryptocurrencyPortfolioData { get; }

        public ViewModel() {
            CryptocurrencyPortfolioData = new List<CryptocurrencyPortfolioItem>(){
                new CryptocurrencyPortfolioItem("NEO", 13),
                new CryptocurrencyPortfolioItem("HT", -12),
                new CryptocurrencyPortfolioItem("DASH", 9),
                new CryptocurrencyPortfolioItem("LINK", -3),
                new CryptocurrencyPortfolioItem("ETC", -8),
                new CryptocurrencyPortfolioItem("XMR", 10),
                new CryptocurrencyPortfolioItem("TRX", 5),
                new CryptocurrencyPortfolioItem("ADA", -7),
                new CryptocurrencyPortfolioItem("XTZ", 2),
                new CryptocurrencyPortfolioItem("BNB", 10),
                new CryptocurrencyPortfolioItem("USDT", -7),
                new CryptocurrencyPortfolioItem("EOS", 20),
                new CryptocurrencyPortfolioItem("LTC", -13),
                new CryptocurrencyPortfolioItem("BSV", -7),
                new CryptocurrencyPortfolioItem("BCH", 42),
                new CryptocurrencyPortfolioItem("XRP", -8),
                new CryptocurrencyPortfolioItem("ETH", 12),
                new CryptocurrencyPortfolioItem("BTC", 24),
            };
        }
    }
    public class CryptocurrencyPortfolioItem {
        public string Ticker { get; private set; }
        public double Profit { get; private set; }

        public CryptocurrencyPortfolioItem(string ticker, double profit) {
            Ticker = ticker;
            Profit = profit;
        }
    }

    class CryptocurrencyPortfolioAxisLabelTextFormatter : IAxisLabelTextFormatter {
        public string Format(object value) => ((double)value).ToString() + "%";
    }
}
