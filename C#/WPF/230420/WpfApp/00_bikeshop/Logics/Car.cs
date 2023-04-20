using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Media.Animation;

namespace _03_bikeshop.Logics
{
    public class Car : Notifier
    {
        private double speed;
        private string names;
        public string Name { 
            get
            {
                return names;
            }
            set
            {
                names = value;
                OnPropertyChanged("Name");
            }

                 }
        public double Speed { get => speed; set=> speed = value; }
        public Color Colorz { get; set; }
        public Human Driver { get; set; }
    }
}
