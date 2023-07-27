using DevExpress.Maui.Charts;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialChartExample
{
    public class TimeFrameToDateTimeMeasureUnitConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            if (!(value is TimeFrame timeFrame) || targetType != typeof(DateTimeMeasureUnit)) return null;
            switch (timeFrame) {
                case TimeFrame.M15:
                case TimeFrame.M30:
                    return DateTimeMeasureUnit.Minute;
                case TimeFrame.H1:
                case TimeFrame.H2:
                case TimeFrame.H4:
                    return DateTimeMeasureUnit.Hour;
                case TimeFrame.D:
                    return DateTimeMeasureUnit.Day;
                default:
                    throw new NotSupportedException();
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotSupportedException();
        }
    }
}
