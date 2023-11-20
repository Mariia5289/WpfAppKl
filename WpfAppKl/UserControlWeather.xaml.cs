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
using WpfAppKl.DataModel;

namespace WpfAppKl
{
    /// <summary>
    /// Логика взаимодействия для UserControlWeather.xaml
    /// </summary>
    public partial class UserControlWeather : UserControl
    {
        public UserControlWeather()
        {
            InitializeComponent();
        }

        public UserControlWeather(Weather weather)
        {
            InitializeComponent();
            System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["weatherViewSource"];
            myCollectionViewSource.Source = new List<Weather>() { weather };
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {

            // Не загружайте свои данные во время разработки.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Загрузите свои данные здесь и присвойте результат CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }
    }
}
