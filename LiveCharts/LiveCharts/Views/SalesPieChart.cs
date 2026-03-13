using LiveCharts;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Models;
using SalesLibrary.Presenter;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;

namespace LiveCharts.Views
{
    public class SalesPieChart : LiveCharts.WinForms.PieChart
    {
        private SalesPresenter presenter_;

        public void SetPresenter(SalesPresenter presenter)
        {
            presenter_ = presenter;
        }
        public void UpdateView()
        {
            List<Item> allItems = presenter_.GetAllItems(); ;
            SeriesCollection seriesData = new SeriesCollection();
            foreach (Item i in allItems)
            {
                seriesData.Add(new PieSeries
                {
                    Title = i.Name,
                    Values = new ChartValues<double> { presenter_.GetProfitPercentByItem(i) },
                    DataLabels = true,
                });
            }
            Series = seriesData;
            
        }
    }
}
