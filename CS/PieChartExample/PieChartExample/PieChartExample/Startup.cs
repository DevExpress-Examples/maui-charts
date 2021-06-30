using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;
using DevExpress.Maui.Charts;

namespace PieChartExample {
	public class Startup : IStartup {
		public void Configure(IAppHostBuilder appBuilder) {
			appBuilder
				.ConfigureMauiHandlers((_, handlers) => handlers.AddHandler<PieChartView, PieChartHandler>())
				.UseMauiApp<App>()
				.ConfigureFonts(fonts => {
					fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				});
		}
	}
}