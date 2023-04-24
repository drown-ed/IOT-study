﻿using System;
using System.Windows;
using System.Windows.Input;
using wp08_personalInfoApp.Models;

namespace wp08_personalInfoApp.ViewModels
{
    internal class MainViewModel : ViewModelBase
    {
        // View에서 사용할 멤버변수 선언
        // 입력쪽 변수
        private string inFirstName;
        private string inLastName;
        private string inEmail;
        private DateTime inDate;

        // 결과 출력쪽 변수
        private string outFirstName;
        private string outLastName;
        private string outEmail;
        private string outDate; // 생일날짜 출력할때는 문자열 대체
        private string outAdult;
        private string outBirthDay;
        private string outZodiac;

        // 일이 많아짐. 실제로 사용할 속성
        // 입력을 위한 속성들
        public string InFirstName { 
            get => inFirstName;
            set
            {
                inFirstName = value;
                RaisePropertyChanged(nameof(InFirstName)); // "InFirstName"
            }
        }

        public string InLastName { 
            get => inLastName;
            set
            {
                inLastName = value;
                RaisePropertyChanged(nameof(InLastName));
            }
        }

        public string InEmail { 
            get => inEmail;
            set
            {
                inEmail = value;
                RaisePropertyChanged(nameof(InEmail));
            }
        }

        public DateTime InDate { 
            get => inDate;
            set
            {
                inDate = value;
                RaisePropertyChanged(nameof(InDate));
            }
        }

        // 출력을 위한 속성들
        public string OutFirstName { 
            get => outFirstName;
            set
            {
                outFirstName = value;
                RaisePropertyChanged(nameof(OutFirstName));
            }
        }

        public string OutLastName { 
            get => outLastName;
            set
            {
                outLastName = value;
                RaisePropertyChanged(nameof(OutLastName));
            }
        }

        public string OutEmail { 
            get => outEmail;
            set
            {
                outEmail = value;
                RaisePropertyChanged(nameof(OutEmail));
            }
        }
        public string OutDate { 
            get => outDate;
            set
            {
                outDate = value;
                RaisePropertyChanged(nameof(OutDate));
            }
        }
        public string OutAdult { 
            get => outAdult;
            set
            {
                outAdult = value;
                RaisePropertyChanged(nameof(OutAdult));
            }
        }
        public string OutBirthDay { 
            get => outBirthDay;
            set
            {
                outBirthDay = value;
                RaisePropertyChanged(nameof(OutBirthDay));
            }
        }
        public string OutZodiac { 
            get => outZodiac;
            set
            {
                outZodiac = value;
                RaisePropertyChanged(nameof(OutZodiac));
            }
        }

        // 버튼 클릭에 대한 이벤트 처리 (명령)
        private ICommand proceedCommand;
        public ICommand ProceedCommand => proceedCommand ?? (proceedCommand = new RelayCommand<object>(
        o => Proceed(), o => !string.IsNullOrEmpty(inFirstName) &&
                             !string.IsNullOrEmpty(inLastName) &&
                             !string.IsNullOrEmpty(inEmail) &&
                             !string.IsNullOrEmpty(inDate.ToString()))
        );

        private void Proceed()
        {
            try
            {
                Person person = new Person(InFirstName, inLastName, inEmail, inDate);
                OutFirstName = person.FirstName;
                OutLastName = person.LastName;
                OutEmail = person.Email;
                OutDate = person.Date.ToString("yyyy년 MM월 dd일");
                OutAdult = person.IsAdult == true ? "성년" : "미성년";
                OutBirthDay = person.IsBirthDay == true ? "생일" : "-";
                OutZodiac = person.Zodiac;
            }
            catch (Exception ex)
            {

                MessageBox.Show($"예외발생 {ex.Message}");
            }
        }
    }
}
