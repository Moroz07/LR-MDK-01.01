using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace LiveCharts.Views
{
    public class SalesCartesianChart : LiveCharts.WinForms.CartesianChart,
                                       ISalesView
    {
        private LineSeries seriesData_;
        public SalesCartesianChart()
        {
            seriesData_ = new LineSeries
            {
                Title = "Продажи",

                Stroke = new SolidColorBrush(Colors.Green),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 6,

                Fill = new LinearGradientBrush(
                        System.Windows.Media.Color.FromArgb(90, 33, 150, 243),
                        System.Windows.Media.Color.FromArgb(0, 33, 150, 243),
                        90)
            };

            /// Ось Y
            AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("N0"),

                Separator = new Separator
                {
                    IsEnabled = false,
                },

                MinValue = 0
            }
            );


            /// Ось X
            AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }
        public void Show(List<Sale> sales)
        {
            if (sales == null || sales.Count == 0) return;

            var X = AxisX[0];
            var Y = AxisY[0];

            {
                int maxValue = sales.Max(sale => sale.Count);
                Y.MaxValue = maxValue + 1;
            }

            X.Labels = new string[sales.Count];
            seriesData_.Values = new ChartValues<int>();
            for (int index = 0; index < sales.Count; ++index)
            {
                X.Labels[index] = sales[index].Time.ToShortDateString();
                seriesData_.Values.Add(sales[index].Count);
            }

            Series = new SeriesCollection { seriesData_ };
        }
    }
}
