using Microsoft.Maui.Graphics;
using System.Collections.Generic;

namespace PieChartExample {
    class ViewModel {
        public IReadOnlyList<LandAreaItem> LandAreas { get; }
        readonly Color[] palette;
        public Color[] Palette => palette;

        public ViewModel() {
            LandAreas = new List<LandAreaItem>() {
            new LandAreaItem("Russia", 17.098),
            new LandAreaItem("Canada", 9.985),
            new LandAreaItem("People's Republic of China", 9.597),
            new LandAreaItem("United States of America", 9.834),
            new LandAreaItem("Brazil", 8.516),
            new LandAreaItem("Australia", 7.692),
            new LandAreaItem("India", 3.287),
            new LandAreaItem("Others", 81.2)
        };
            palette = PaletteLoader.LoadPalette("#975ba5", "#03bfc1", "#f8c855", "#f45a4e",
                                            "#496cbe", "#f58f35", "#d293fd", "#25a966");
        }
    }

    class LandAreaItem {
        public string CountryName { get; }
        public double Area { get; }

        public LandAreaItem(string countryName, double area) {
            this.CountryName = countryName;
            this.Area = area;
        }
    }

    static class PaletteLoader {
        public static Color[] LoadPalette(params string[] values) {
            Color[] colors = new Color[values.Length];
            for (int i = 0; i < values.Length; i++)
                colors[i] = Color.FromArgb(values[i]);
            return colors;
        }
    }
}
