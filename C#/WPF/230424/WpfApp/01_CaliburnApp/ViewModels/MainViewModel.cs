using _01_CaliburnApp.Models;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_CaliburnApp.ViewModels
{
    public class MainViewModel : Screen
    {
        private string firstName = "Yurina";
        public string FirstName
        {
            get => firstName;
            set
            {
                firstName = value;
                NotifyOfPropertyChange(nameof(CanClearName));        // 속성값이 변경된 것을 시스템에 알려주는 역할
                NotifyOfPropertyChange(nameof(FirstName));   
            }
        }

        private string lastName = "Oh";
        public string LastName
        {
            get => lastName;
            set
            {
                lastName = value;
                NotifyOfPropertyChange(nameof(CanClearName));
                NotifyOfPropertyChange(nameof(LastName));
            }
        }

        public string FullName
        {
            get => $"{LastName} {FirstName}";
        }

        // 콤보박스에 바인딩할 속성
        // 이런 곳에서는 var를 쓸 수 없음
        private BindableCollection<Person> managers = new BindableCollection<Person>();

        public BindableCollection<Person> Managers
        {
            get { return managers; }
            set { managers = value; }
        }


        // 콤보박스에 선택된 값을 지정할 속성
        private Person selectedManager;
        public Person SelectedManager
        {
            get => selectedManager;
            set
            {
                selectedManager = value;
                LastName = selectedManager.LastName;
                FirstName = selectedManager.FirstName;
                NotifyOfPropertyChange(() => SelectedManager);
            }
        }

        public void ClearName()
        {
            FirstName = string.Empty;
            LastName = string.Empty;
        }

        public bool CanClearName
        {
            get => !(string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName));
        }

        public MainViewModel()
        {
            Managers.Add(new Person { FirstName = "Skywalker", LastName = "Anakin" });
            Managers.Add(new Person { FirstName = "Amidala", LastName = "Padme" });
            Managers.Add(new Person { FirstName = "Skywalker", LastName = "Luke" });
            Managers.Add(new Person { FirstName = "Organa", LastName = "Leia" });
        }
    }
}
