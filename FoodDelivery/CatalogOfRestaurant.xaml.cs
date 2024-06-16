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
    /// Interaction logic for UserPageWindow.xaml
    /// </summary>
    public partial class CatalogOfRestaurant: Window
    {
        public CatalogOfRestaurant()
        {
                InitializeComponent();
        }


        private void Button_Donald_Click(object sender, RoutedEventArgs e)
        {
            // Створюємо нове вікно для McDonald's і відображаємо його
            McDonald_sWindow mcWindow = new McDonald_sWindow();
            mcWindow.Show();

            // Приховуємо поточне вікно
            Hide();
        }

        private void Button_KFS_Click(object sender, RoutedEventArgs e)
        {
            // Створюємо нове вікно для KFS і відображаємо його
            KFSWindow kfsWindow = new KFSWindow();
            kfsWindow.Show();

            // Приховуємо поточне вікно
            Hide();
        }

        private void Button_Kebab_Click(object sender, RoutedEventArgs e)
        {
            // Створюємо нове вікно для Kebab House і відображаємо його
            KebabWindow kebabWindow = new KebabWindow();
            kebabWindow.Show();

            // Приховуємо поточне вікно
            Hide();
        }
    }
}


