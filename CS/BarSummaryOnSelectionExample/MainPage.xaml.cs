using DevExpress.Maui.Charts;

namespace BarSummaryOnSelectionExample {
    public partial class MainPage : ContentPage {
        MainViewModel viewModel;
        public MainPage() {
            InitializeComponent();
            this.BindingContext = viewModel = new MainViewModel();
        }
        private void ChartView_SelectionChanged(object sender, DevExpress.Maui.Charts.SelectionChangedEventArgs e) {
            if (e.SelectedObjects.Count > 0) {
                viewModel.SelectedDataItem = (ComponentReplyInfo)((DataSourceKey)e.SelectedObjects[0]).DataObject;
            }
            else {
                viewModel.SelectedDataItem = null;
            }
        }
    }
}