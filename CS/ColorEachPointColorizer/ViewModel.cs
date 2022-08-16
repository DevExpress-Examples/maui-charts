
namespace ColorEachPointColorizer {
    public class ViewModel {
        public List<DataItem> Data { get; }

        public ViewModel() {
            Data = new List<DataItem> {
                new DataItem(new DateTime(2019, 6, 24), 429),
                new DataItem(new DateTime(2019, 6, 27), 432),
                new DataItem(new DateTime(2019, 7, 1), 301),
                new DataItem(new DateTime(2019, 7, 4), 307),
                new DataItem(new DateTime(2019, 7, 8), 310),
                new DataItem(new DateTime(2019, 7, 15), 380),
                new DataItem(new DateTime(2019, 7, 18), 384),
                new DataItem(new DateTime(2019, 7, 22), 398),
                new DataItem(new DateTime(2019, 7, 26), 379),
                new DataItem(new DateTime(2019, 7, 29), 220),
                new DataItem(new DateTime(2019, 8, 2), 321),
                new DataItem(new DateTime(2019, 8, 5), 341),
                new DataItem(new DateTime(2019, 8, 10), 368),
                new DataItem(new DateTime(2019, 8, 13), 400),
                new DataItem(new DateTime(2019, 8, 15), 557),
                new DataItem(new DateTime(2019, 8, 19), 523),
                new DataItem(new DateTime(2019, 8, 25), 540),
                new DataItem(new DateTime(2019, 8, 30), 485),
                new DataItem(new DateTime(2019, 9, 3), 620),
                new DataItem(new DateTime(2019, 9, 8), 580),
                new DataItem(new DateTime(2019, 9, 15), 499),
                new DataItem(new DateTime(2019, 9, 18), 520),
                new DataItem(new DateTime(2019, 9, 22), 536),
                new DataItem(new DateTime(2019, 9, 26), 525),
                new DataItem(new DateTime(2019, 9, 29), 540),
                new DataItem(new DateTime(2019, 10, 2), 548),
                new DataItem(new DateTime(2019, 10, 5), 568),
                new DataItem(new DateTime(2019, 10, 8), 550)
            };
        }
    }
    public class DataItem {
        public DateTime Time { get; }
        public double Power { get; }

        public DataItem(DateTime time, double power) {
            Time = time;
            Power = power;
        }
    }
}
