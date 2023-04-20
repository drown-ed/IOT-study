using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace _03_bikeshop.Logics
{

    internal class MyConverter : IValueConverter
    {
        // 대상에다가 표현할 때 값 반환 (OneWay)
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value.ToString() + " km/h";
        }

        // 대상 값 변형 돼 원본(소스) 값 변환해 표현 (TwoWay)
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return int.Parse(value.ToString()) * 3;
        }
    }
}
