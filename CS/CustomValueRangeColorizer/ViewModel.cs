using System.Collections.Generic;
using DevExpress.Maui.Charts;

namespace CustomValueRangeColorizer
{
    public class ViewModel {
        HpiProvider valueProvider = new HpiProvider();
        public List<CountryStatistics> CountryStatisticsData => this.valueProvider.SeriesData;
    }

    public class HpiProvider : ICustomColorizerNumericValueProvider {
        private CountryStatisticsData data = new CountryStatisticsData();

        public double GetValueForColorizer(int index) {
            return this.data.SeriesData[index].Hpi;
        }

        public List<CountryStatistics> SeriesData => this.data.SeriesData;
    }

    public class CountryStatisticsData {
        readonly List<CountryStatistics> data = new List<CountryStatistics> {
            new CountryStatistics("Argentina", 16011.6728032264, 40412000, 54.055),
            new CountryStatistics("Australia", 38159.6336533223, 40412000, 41.980),
            new CountryStatistics("Brazil", 11210.3908053823, 194946000, 52.9),
            new CountryStatistics("Canada", 39050.1673163719, 34126000, 43.56),
            new CountryStatistics("China", 7599, 1338300000, 44.66),
            new CountryStatistics("France", 34123.1966249035, 64895000, 46.523),
            new CountryStatistics("Germany", 37402.2677660974, 81777000, 47.2),
            new CountryStatistics("India", 3425.4489267524, 1224615000, 50.865),
            new CountryStatistics("Indonesia", 4325.2533282173, 239870000, 55.481),
            new CountryStatistics("Italy", 31954.1751781228, 60483000, 46.352),
            new CountryStatistics("Japan", 33732.8682226596, 127451000, 47.508),
            new CountryStatistics("Mexico", 14563.884253986, 113423000, 52.894),
            new CountryStatistics("Russia", 19891.3528339013, 141750000, 34.518),
            new CountryStatistics("Saudi Arabia", 22713.4852913284, 27448000, 45.965),
            new CountryStatistics("South Africa", 10565.1840563081, 49991000, 28.190),
            new CountryStatistics("South Korea", 29101.0711400706, 48875000, 43.781),
            new CountryStatistics("Turkey", 15686.860167575, 72752000, 47.623),
            new CountryStatistics("United Kingdom", 35686.1997705521, 62232000, 47.925),
            new CountryStatistics("Spain", 32230.3585974199, 46071000, 44.063),
            new CountryStatistics("USA", 47153.0094273427, 309349000, 37.340),
        };
        public List<CountryStatistics> SeriesData => this.data;
    }

    public class CountryStatistics {
        public string Country { get; private set; }
        public double Gdp { get; private set; }
        public double Population { get; private set; }
        public double Hpi { get; private set; }

        public CountryStatistics(string country, double gdp, double population, double hpi) {
            Country = country;
            Gdp = gdp;
            Population = population;
            Hpi = hpi;
        }
    }
}
