using LiveCharts.Wpf;
using LiveCharts;
using SalesLibrary;
using SalesLibrary.Models;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using SalesLibrary.Analysis;
using SalesLibrary.Presenters;

namespace ChartTest.Views
{
    class SalesPieChart : LiveCharts.WinForms.PieChart
                                    
    {
        private SalesPresenter presenter_;

        public void SetPresenter(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Item> allItems = presenter_.GetAllItems();
            SeriesCollection seriesData_ = new SeriesCollection();
            foreach (Item item in allItems)
            {
                seriesData_.Add(new PieSeries
                {
                    Title = item.Name,
                    Values = new ChartValues<double> { presenter_.GetProfitPercentByItem(item)},
                    
                });
            }
            Series = seriesData_;
            LegendLocation = LegendLocation.Right;
        }
    }
}
