using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.WinForms;
using LiveCharts.Wpf;
using SalesLibrary;
using SalesLibrary.Analysis;
using SalesLibrary.Presenter;
using SalesLibrary.Views;
using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Forms;
using System.Windows.Media;

namespace LiveCharts
{
    public partial class MainForm : Form
    {

        private SalesPresenter presenter_;
        void FillCartesianChart()
        {
            ItemsList.DataSource = presenter_.GetAllItems();
            ItemsList.DisplayMember = "Name";
            if (ItemsList.Items.Count > 0)
            {
                presenter_.ShowSalesByItem(((Item)ItemsList.Items[0]).Name);
            }
        }
        public MainForm()
        {
            InitializeComponent();

            presenter_ = new SalesPresenter(new List<ISalesView> { cartesian });

            FillCartesianChart();
            pie.SetPresenter(presenter_);
            pie.UpdateView();

        }

        private void ItemsList_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            Item selectedItem = ((Item)(ItemsList.SelectedItem));
            if (selectedItem == null)
            {
                return;
            }

            presenter_.ShowSalesByItem(selectedItem.Name);
            
        
        }

       
    }
}
