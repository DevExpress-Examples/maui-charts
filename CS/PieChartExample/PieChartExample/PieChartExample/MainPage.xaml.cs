using Microsoft.Maui.Controls;

namespace PieChartExample {
    public partial class MainPage : ContentPage {
        private readonly ViewModel vm = new();
        public MainPage() {
            InitializeComponent();
            BindingContext = vm;
            SizeChanged += (s, e) => vm.UpdateOrientation(Width > Height);
        }
    }
}
