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
using System.Windows.Shapes;

namespace FoodDelivery
{
    /// <summary>
    /// Interaction logic for KFSWindow.xaml
    /// </summary>
    public partial class KFSWindow : Window
    {
        public KFSWindow()
        {
            InitializeComponent();
        }

        public void Button_Delivery(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Очікуйте замовлення!");
        }

        public void Button_Back(object sender, RoutedEventArgs e)
        {
            CatalogOfRestaurant catalogOfRestaurant = new CatalogOfRestaurant();
            catalogOfRestaurant.Show();
            Hide();
        }
    }
}
