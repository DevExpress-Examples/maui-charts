
using DevExpress.Maui.Charts;

namespace IndexBasedCustomPointColorizer {
    public class ViewModel {
        CountryStatisticsData data = new CountryStatisticsData();
        public List<CountryStatistics> CountryStatisticsData => this.data.SeriesData;
    }

    public class CountryStatisticsData {
        readonly List<CountryStatistics> data = new List<CountryStatistics> {
            new CountryStatistics("Argentina", 16011.6728032264, "America"),
            new CountryStatistics("Australia", 38159.6336533223, "Australia"),
            new CountryStatistics("Brazil", 11210.3908053823, "America"),
            new CountryStatistics("Canada", 39050.1673163719, "America"),
            new CountryStatistics("China", 7599, "Asia"),
            new CountryStatistics("France", 34123.1966249035, "Europe"),
            new CountryStatistics("Germany", 37402.2677660974, "Europe"),
            new CountryStatistics("India", 3425.4489267524, "Asia"),
            new CountryStatistics("Indonesia", 4325.2533282173, "Asia"),
            new CountryStatistics("Italy", 31954.1751781228, "Europe"),
            new CountryStatistics("Japan", 33732.8682226596, "Asia"),
            new CountryStatistics("Mexico", 14563.884253986, "America"),
            new CountryStatistics("Russia", 19891.3528339013, "Europe"),
            new CountryStatistics("Saudi Arabia", 22713.4852913284, "Asia"),
            new CountryStatistics("South Africa", 10565.1840563081, "Africa"),
            new CountryStatistics("South Korea", 29101.0711400706, "Asia"),
            new CountryStatistics("Turkey", 15686.860167575, "Africa"),
            new CountryStatistics("United Kingdom", 35686.1997705521, "Europe"),
            new CountryStatistics("Spain", 32230.3585974199, "Europe"),
            new CountryStatistics("USA", 47153.0094273427, "America"),
        };
        public List<CountryStatistics> SeriesData => this.data;
    }

    public class CountryStatistics {
        public string Country { get; private set; }
        public double Gdp { get; private set; }
        public string Region { get; private set; }

        public CountryStatistics(string country, double gdp, string region) {
            Country = country;
            Gdp = gdp;
            Region = region;
        }
    }

    public class ColorizerByRegion : IIndexBasedCustomPointColorizer, ILegendItemProvider {
        private CountryStatisticsData data = new CountryStatisticsData();
        private Dictionary<string, Color> colors = new Dictionary<string, Color> {
            {"Africa", Color.FromHex("5b9bd5")},
            {"America",  Color.FromHex("ed7d31")},
            {"Asia", Color.FromHex("a5a5a5")},
            {"Australia", Color.FromHex("ffc000")},
            {"Europe", Color.FromHex("4472c4")}
        };
        private List<string> regions = new List<string> {
            "Africa", "America", "Asia", "Australia", "Europe"
        };

        public Color GetColor(int index) {
            return colors[data.SeriesData[index].Region];
        }

        public CustomLegendItem GetLegendItem(int index) {
            return new CustomLegendItem(regions[index], colors[regions[index]]);
        }

        public int GetLegendItemCount() {
            return regions.Count;
        }

        public ILegendItemProvider GetLegendItemProvider() {
            return this;
        }
    }
}
