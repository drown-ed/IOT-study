using _02_EmployeesApp;
using _02_EmployeesApp.ViewModels;
using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace _02_EmployeesApp
{
    // Caliburn으로 MVVm 실행할 때 주요설정 진행
    public class Bootstrapper : BootstrapperBase
    {
        public Bootstrapper()
        { 
            Initialize();
        }

        // 시작한 후 초기화 진행
        protected async override void OnStartup(object sender, StartupEventArgs e)
        {
            //base.OnStartup(sender, e); 부모 클래스 실행은 주석 처리
            await DisplayRootViewForAsync<MainViewModel>();
        }
    }
}
