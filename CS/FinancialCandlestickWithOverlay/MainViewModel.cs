using DevExpress.Maui.Charts;
using DevExpress.Maui.Core.Internal;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FinancialChartExample {
    public class MainViewModel : BindableBase {
        const int ShownPointCount = 40;
        DateTime rangeStart;
        DateTime rangeEnd;
        IList<HistoricalPrice> stockPrices;
        TimeFrame selectedCandleInterval;

        public ObservableCollection<TimeFrame> CandleIntervals {
            get;
            set;
        }
        public HistoricalPriceData DataStorage {
            get {
                return dataStorage;
            }
            set {
                dataStorage = value;
                RaisePropertyChanged();
            }
        }
        public TimeFrame SelectedCandleInterval {
            get {
                return selectedCandleInterval;
            }
            set {
                selectedCandleInterval = value;
                StockPrices = dataStorage[SelectedCandleInterval];
                RaisePropertyChanged();
            }
        }
        public IList<HistoricalPrice> StockPrices {
            get {
                return stockPrices;
            }
            set {
                stockPrices = value;
                RaisePropertyChanged();
                UpdateRangeToStickToEnd();
            }
        }
        public DateTime RangeStart {
            get => rangeStart;
            set {
                rangeStart = value;
                RaisePropertyChanged();
            }
        }
        public DateTime RangeEnd {
            get => rangeEnd;
            set {
                rangeEnd = value;
                RaisePropertyChanged();
            }
        }
        HistoricalPriceData dataStorage;
        public MainViewModel() {
            dataStorage = new HistoricalPriceData(new PairInfo() {
                Change = 10,
                ChangePercent = 0.0543,
                PairName = "BTA/RON",
                LatestPrice = 137194,
                InDollars = 30555.46,
                HighPriceValue = 151381,
                LowPriceValue = 136959,
                LatestUpdate = DateTime.Now,
            });
            CandleIntervals = new ObservableCollection<TimeFrame> { TimeFrame.M15, TimeFrame.M30, TimeFrame.H1, TimeFrame.H2, TimeFrame.H4, TimeFrame.D };
            SelectedCandleInterval = CandleIntervals[0];
        }

        void UpdateRangeToStickToEnd() {
            int endIndex = StockPrices.Count -1;
            int startIndex = Math.Max(endIndex - ShownPointCount, 0);
            RangeStart = StockPrices[startIndex].Timestamp;
            RangeEnd = StockPrices[endIndex].Timestamp;
        }
    }
    public class BindableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
