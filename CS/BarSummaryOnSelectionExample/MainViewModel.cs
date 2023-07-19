using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BarSummaryOnSelectionExample {
    public class MainViewModel : BindableBase {
        int selectionCompletedThreads;
        int selectionBugs;
        float selectionAvgReplyTime;
        float selectionAvgIterations;
        int selectionThreadsCount;
        float selectionCompletedThreadsProgress;
        ComponentReplyInfo selectedDataItem;
        public string EmptySelectionString = "All Components";
        public string PeriodText {
            get;
            set;
        }
        public int TotalReplies {
            get;
            set;
        }
        public ComponentReplyInfo SelectedDataItem {
            get {
                return selectedDataItem;
            }
            set {
                selectedDataItem = value;
                RaisePropertyChanged(nameof(SelectedComponentString));
                UpdateSelectionProperties();
            }
        }
        public string SelectedComponentString {
            get {
                if (SelectedDataItem == null)
                    return EmptySelectionString;
                return SelectedDataItem.ComponentName;
            }
        }
        public int SelectionCompletedThreads {
            get {
                return selectionCompletedThreads;
            }
            set {
                selectionCompletedThreads = value;
                RaisePropertyChanged();
            }
        }
        public int SelectionBugs {
            get {
                return selectionBugs;
            }
            set {
                selectionBugs = value;
                RaisePropertyChanged();
            }
        }
        public float SelectionAvgReplyTime {
            get {
                return selectionAvgReplyTime;
            }
            set {
                selectionAvgReplyTime = value;
                RaisePropertyChanged();
            }
        }
        public float SelectionAvgIterations {
            get {
                return selectionAvgIterations;
            }
            set {
                selectionAvgIterations = value;
                RaisePropertyChanged();
            }
        }
        public int SelectionThreadsCount {
            get {
                return selectionThreadsCount;
            }
            set {
                selectionThreadsCount = value;
                RaisePropertyChanged();
            }
        }
        public float SelectionCompletedThreadsProgress {
            get {
                return selectionCompletedThreadsProgress;
            }
            set {
                selectionCompletedThreadsProgress = value;
                RaisePropertyChanged();
            }
        }
        public ObservableCollection<ComponentReplyInfo> ComponentReplyInfos {
            get;
            set;
        }
        public MainViewModel() {
            PeriodText = "April 6 - April 20";
            ComponentReplyInfos = new ObservableCollection<ComponentReplyInfo> {
                new ComponentReplyInfo("Data Grid", 30, 3.4f, 2.2f, 2,28),
                new ComponentReplyInfo("Charts", 29, 3.6f, 2.3f, 2, 25),
                new ComponentReplyInfo("Controls", 25, 2.1f, 1.9f, 2,17),
                new ComponentReplyInfo("Collection View", 20, 2.5f, 2.1f, 1, 20),
                new ComponentReplyInfo("Editors", 15, 2.2f, 1.9f, 2,13),

            };
            TotalReplies = ComponentReplyInfos.Sum(ri => ri.Count);
            UpdateSelectionProperties();
        }
        void UpdateSelectionProperties() {
            if (SelectedDataItem == null) {
                SelectionCompletedThreads = ComponentReplyInfos.Sum(x => x.CompletedThreadsCount);
                SelectionBugs = ComponentReplyInfos.Sum(x => x.BugReportsCount);
                SelectionAvgReplyTime = ComponentReplyInfos.Average(x => x.AvgReplyTime);
                SelectionAvgIterations = ComponentReplyInfos.Average(x => x.AvgIterationsCount);
                SelectionThreadsCount = TotalReplies;
            }
            else {
                SelectionCompletedThreads = SelectedDataItem.CompletedThreadsCount;
                SelectionBugs = SelectedDataItem.BugReportsCount;
                SelectionAvgReplyTime = SelectedDataItem.AvgReplyTime;
                SelectionAvgIterations = SelectedDataItem.AvgIterationsCount;
                SelectionThreadsCount = SelectedDataItem.Count;
            }
            SelectionCompletedThreadsProgress = (float)SelectionCompletedThreads / (float)SelectionThreadsCount;
        }
    }

    public class ComponentReplyInfo {
        public ComponentReplyInfo(string componentName, int count, float avgReplyTime, float avgIterationsCount, int bugReportsCount, int completedThreadsCount) {
            ComponentName = componentName;
            Count = count;
            AvgReplyTime = avgReplyTime;
            AvgIterationsCount = avgIterationsCount;
            BugReportsCount = bugReportsCount;
            CompletedThreadsCount = completedThreadsCount;
        }
        public string ComponentName {
            get;
            set;
        }
        public int Count {
            get;
            set;
        }
        public float AvgReplyTime {
            get;
            set;
        }
        public float AvgIterationsCount {
            get;
            set;
        }
        public int BugReportsCount {
            get;
            set;
        }
        public int CompletedThreadsCount {
            get;
            set;
        }
    }
    public class BindableBase : INotifyPropertyChanged {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged([CallerMemberName] string propertyName = "") {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
