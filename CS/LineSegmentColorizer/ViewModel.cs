
namespace LineSegmentColorizer {
    public class ViewModel {
        public List<DataItem> Data { get; }
        public ViewModel() {
            Data = new List<DataItem>() {
                new DataItem() { Argument = new DateTime(2018, 1, 1), Value = -17.5 },
                new DataItem() { Argument = new DateTime(2018, 1, 10), Value = -1.4 },
                new DataItem() { Argument = new DateTime(2018, 1, 20), Value = -22 },
                new DataItem() { Argument = new DateTime(2018, 1, 30), Value = -26.2 },
                new DataItem() { Argument = new DateTime(2018, 2, 10), Value = -17.5 },
                new DataItem() { Argument = new DateTime(2018, 2, 20), Value = -15.7 },
                new DataItem() { Argument = new DateTime(2018, 2, 28), Value = -7.8 },
                new DataItem() { Argument = new DateTime(2018, 3, 10), Value = -8.8 },
                new DataItem() { Argument = new DateTime(2018, 3, 20), Value = 1.3 },
                new DataItem() { Argument = new DateTime(2018, 3, 30), Value = -7.5 },
                new DataItem() { Argument = new DateTime(2018, 4, 10), Value = 1.5 },
                new DataItem() { Argument = new DateTime(2018, 4, 20), Value = 8.5 },
                new DataItem() { Argument = new DateTime(2018, 4, 30), Value = 11 },
                new DataItem() { Argument = new DateTime(2018, 5, 10), Value = 12.2 },
                new DataItem() { Argument = new DateTime(2018, 5, 20), Value = 13.7 },
                new DataItem() { Argument = new DateTime(2018, 5, 30), Value = 8.3 },
                new DataItem() { Argument = new DateTime(2018, 6, 10), Value = 15.3 },
                new DataItem() { Argument = new DateTime(2018, 6, 20), Value = 19.1 },
                new DataItem() { Argument = new DateTime(2018, 6, 30), Value = 22.3 },
                new DataItem() { Argument = new DateTime(2018, 7, 10), Value = 22.2 },
                new DataItem() { Argument = new DateTime(2018, 7, 20), Value = 24.5 },
                new DataItem() { Argument = new DateTime(2018, 7, 30), Value = 21.4 },
                new DataItem() { Argument = new DateTime(2018, 8, 10), Value = 21.2 },
                new DataItem() { Argument = new DateTime(2018, 8, 20), Value = 15.6 },
                new DataItem() { Argument = new DateTime(2018, 8, 30), Value = 15 },
            };
        }
    }

    public class DataItem {
        public DateTime Argument { get; set; }
        public double Value { get; set; }
    }
}