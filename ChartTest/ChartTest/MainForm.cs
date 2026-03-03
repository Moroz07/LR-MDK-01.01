using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms;
using System.Windows.Media;

namespace ChartTest
{
    public partial class MainForm : Form
    {

        void FillCartesianChart()
        {
            LineSeries series = new LineSeries
            {
                Title = "Продажи",
                Values = new ChartValues<int> { 10, 15, 8, 19, 25, 22 },

                Stroke = new SolidColorBrush(Colors.Gold),
                StrokeThickness = 2,

                PointGeometry = DefaultGeometries.Circle,
                PointGeometrySize = 7,

                Fill = new LinearGradientBrush(
                    System.Windows.Media.Color.FromArgb(100, 153, 0, 18),
                    System.Windows.Media.Color.FromArgb(100, 153, 0, 18),
                    90)
            };

            cartesian.Series = new SeriesCollection { series, /*series_2, series_3*/ };

            /// Ось Y
            cartesian.AxisY.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                LabelFormatter = value => value.ToString("NO"),

                Separator = new Separator
                {
                    Stroke = new SolidColorBrush(Color.FromArgb(40, 0, 0, 0)),
                    StrokeThickness = 1
                },

                MaxValue = 30,
                MinValue = 1
            }
            );  


            /// Ось X
            cartesian.AxisX.Add(new Axis
            {
                Foreground = System.Windows.Media.Brushes.Black,
                Labels = new[] { "Янв", "Фев", "Мар", "Апр", "Май", "Июн" },

                Separator = new Separator
                {
                    IsEnabled = false,
                },
            }
            );
        }

        void FillAngular()
        {
            angular.Value = 65;
            angular.FromValue = 0;
            angular.ToValue = 100;

            angular.TicksForeground = Brushes.Purple;
            angular.NeedleFill = Brushes.Green;
            
        }

        void FillSolid()
        {
            solid.Value = 65;
            solid.From = 0;
            solid.To = 100;
            solid.Uses360Mode = true;
            solid.LabelFormatter = value => value + "%";
            solid.GaugeBackground = Brushes.LawnGreen;
            solid.Base.GaugeActiveFill = new System.Windows.Media.LinearGradientBrush
            {
                GradientStops = new System.Windows.Media.GradientStopCollection
                {
                new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Yellow,.5),
                new System.Windows.Media.GradientStop(System.Windows.Media.Colors.Red,0),
                new System.Windows.Media.GradientStop (System.Windows.Media.Colors.Purple,1)
                }
            };
            
        }
        public MainForm()
        {
            InitializeComponent();

            FillCartesianChart();

            FillAngular();

            FillSolid();
        }
    }
}
