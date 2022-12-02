using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Tp_Synthèse_B
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class UserControl1 : UserControl
    {
        Clothes Product;
        public UserControl1()
        {
            InitializeComponent();
        }

        public UserControl1(Clothes product)
        {
            Product = product;

            InitializeComponent();

            updateProduct();
        }

        private void updateProduct()
        {
            //img
            price.Text = Product.GetPrice;
            desc.Text = Product.Description;
            color.Items.Clear();
            foreach (var item in Product.Colors)
                color.Items.Add(item);
            size.Items.Clear();
            foreach (var item in Product.Sizes)
                size.Items.Add(item);
            for (int i = 1; i < Product.Quantities; i++)
                qte.Items.Add(i);
            qte.SelectedIndex = 0;
        }

        private void qte_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Product.Quantity = qte.SelectedIndex+1;
            price.Text = Product.GetPrice;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
