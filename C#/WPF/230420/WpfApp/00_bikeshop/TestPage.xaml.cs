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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _03_bikeshop
{
    /// <summary>
    /// Support.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class TestPage : Page
    {
        Car myCar = null;
        public TestPage()
        {
            InitializeComponent();
            InitCar();
        }

        public void InitCar()
        {
            myCar = new Car();
            myCar.Name = "Ionic";
            myCar.Colorz = Colors.White;
            myCar.Speed = 220;

            var cars = new List<Car>();
            var rand = new Random();
            for (int i = 0; i< 10; i++)
            {
                cars.Add(new Car() {
                    Speed = i * 10,
                    Colorz = Color.FromRgb((byte)rand.Next(256), (byte)rand.Next(256), (byte)rand.Next(256))
                });
            }
            CtlCars.DataContext = cars;
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            /*TxtSample.Text = myCar.Speed.ToString();*/
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("이것도 버튼");
        }
    }
}
