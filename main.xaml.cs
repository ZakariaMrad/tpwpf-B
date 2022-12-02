using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Shapes;

namespace Tp_Synthèse_B
{
    /// <summary>
    /// Logique d'interaction pour main.xaml
    /// </summary>
    public partial class main : Window
    {
        static List<Clothes> products = new List<Clothes>() { App.Products[0] };
        public main()
        {
            InitializeComponent();



            foreach (var item in products)
            {
                UserControl1 element = new UserControl1(item);
                items.Children.Add(element);
                element.DeleteButton.Click += DeleteButton_Click;
                element.DeleteButton.CommandParameter =item.Id;
            }

           
        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            var button = sender as Button;
            string val = button.CommandParameter.ToString();
            Trace.WriteLine(val);
            products.RemoveAll(x => x.Id.ToString() == val);
        }
    }
}
