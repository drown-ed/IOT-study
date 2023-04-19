using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace _03_bikeshop.Logics
{
    public class Car
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public Color Colors { get; set; }
        public Human Driver { get; set; }
    }
}
