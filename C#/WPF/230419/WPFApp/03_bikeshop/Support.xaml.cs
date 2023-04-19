using _03_bikeshop.Logics;
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

namespace _03_bikeshop
{
    /// <summary>
    /// Support.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Support : Page
    {
        Car myCar = null;
        public Support()
        {
            InitializeComponent();
            InitCar();
        }

        public void InitCar()
        {
            myCar = new Car();
            myCar.Name = "Ionic";
            myCar.Colors = Colors.White;
            myCar.Speed = 220;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            TxtSample.Text = myCar.Speed.ToString();
        }
    }
}
