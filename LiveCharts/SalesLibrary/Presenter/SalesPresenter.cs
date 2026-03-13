using SalesLibrary.Analysis;
using SalesLibrary.Models;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalesLibrary.Presenter
{
    public class SalesPresenter
    {
        private SalesModel model_ = new SalesModel();
        private List<ISalesView> views_;
        public SalesPresenter(List<ISalesView> views)
        {
            views_ = views;

            model_.Load();
        }

        public void ShowSalesByItem(string itemName)
        {
            List<Sale> sales = model_.LoadSalesForItem(itemName);
            foreach (ISalesView view in views_)
            {
                view.Show(sales);
            }
        }


        public List<Item> GetAllItems()
        {
            return model_.GetAllItems();
        }
        public double GetProfitPercentByItem(Item selectedItem)
        {
            double result = ProfitAnalyzer.CalculateProfitPercentByItem(selectedItem.Name, model_);
            return Math.Round(result, 2);
        }
    }
}
