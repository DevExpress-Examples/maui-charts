using System.Globalization;
using DevExpress.Maui.Charts;

namespace AreaSegmentColorizer {
    public class ViewModel {
        LightSpectorData data = new LightSpectorData();
        public IList<NumericData> LightSpectorData => this.data.LightSpectors;
    }

    public class LightSpectorData {
        public IList<NumericData> LightSpectors { get; }

        public LightSpectorData() {
            LightSpectors = new List<NumericData>();
            using (Stream stream =
                GetType().Assembly.GetManifestResourceStream("AreaSegmentColorizer.LightSpector.dat")) {
                StreamReader reader = new StreamReader(stream);
                string data = reader.ReadToEnd();
                String[] dataItems = data.Split(new String[] { "\n" },
                                     StringSplitOptions.RemoveEmptyEntries);
                for (int i = 0; i < dataItems.Length; i++) {
                    String[] row = dataItems[i].Split(new String[] { " " },
                                   StringSplitOptions.RemoveEmptyEntries);
                    double argument = Convert.ToDouble(row[0], CultureInfo.InvariantCulture);
                    double value = Convert.ToDouble(row[1], CultureInfo.InvariantCulture);
                    LightSpectors.Add(new NumericData(argument, value));
                }
            }
        }
    }

    public class LightSpectorColorizer : ICustomPointColorizer, ILegendItemProvider {
        Color waveLengthToColor(double waveLength) {
            double gamma = 0.8;
            double red = 0.0;
            double green = 0.0;
            double blue = 0.0;
            if (waveLength <= 440) {
                double attenuation = 0.3 + 0.7 * (waveLength - 380) / (440 - 380);
                red = Math.Pow((-(waveLength - 440) / (440 - 380)) * attenuation, gamma);
                green = 0.0;
                blue = Math.Pow(1.0 * attenuation, gamma);
            }
            else if (waveLength <= 490) {
                red = 0.0;
                green = Math.Pow((waveLength - 440) / (490 - 440), gamma);
                blue = 1.0;
            }
            else if (waveLength <= 510)
            {
                red = 0.0;
                green = 1.0;
                blue = Math.Pow(-(waveLength - 510) / (510 - 490), gamma);
            }
            else if (waveLength <= 580) {
                red = Math.Pow((waveLength - 510) / (580 - 510), gamma);
                green = 1.0;
                blue = 0.0;
            }
            else if (waveLength <= 645) {
                red = 1.0;
                green = Math.Pow(-(waveLength - 645) / (645 - 580), gamma);
                blue = 0.0;
            }
            else if (waveLength <= 750) {
                double attenuation = 0.3 + 0.7 * (750 - waveLength) / (750 - 645);
                red = Math.Pow(1.0 * attenuation, gamma);
                green = 0.0;
                blue = 0.0;
            }
            return Color.FromRgb(red, green, blue);
        }

        protected virtual double[] GetWavesForLegend() {
            return new double[] { 400, 440, 480, 540, 580, 610, 650 };
        }

        Color ICustomPointColorizer.GetColor(ColoredPointInfo info) {
            return waveLengthToColor(info.NumericArgument);
        }
        ILegendItemProvider ICustomPointColorizer.GetLegendItemProvider() {
            return this;
        }

        CustomLegendItem ILegendItemProvider.GetLegendItem(int index) {
            double waveLength = GetWavesForLegend()[index];
            Color color = waveLengthToColor(waveLength);
            return new CustomLegendItem($"{waveLength} nm", color);
        }
        int ILegendItemProvider.GetLegendItemCount() {
            return GetWavesForLegend().Length;
        }
    }

    public class NumericData {
        public double Argument { get; private set; }
        public double Value { get; private set; }
        public NumericData(double argument, double value) {
            Argument = argument;
            Value = value;
        }
    }
}
