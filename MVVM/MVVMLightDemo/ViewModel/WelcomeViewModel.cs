using GalaSoft.MvvmLight;
using MVVMLightDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.ViewModel
{
    public class WelcomeViewModel : ViewModelBase
    //ViewModelBase同时继承 ObservableObject类和ICleanup接口。
    //所以他同样有INotifyPropertyChanged接口的能力，能够通过触发PropertyChanged事件达到通知View的目的；
    {
        public WelcomeViewModel()
        {
            Welcome = new WelcomeModel() { Instroduction = "Hello World2" };
        }
        #region "属性"
        private WelcomeModel _welcome;

        public WelcomeModel Welcome
        {
            get => _welcome;
            set
            {
                _welcome = value;
                RaisePropertyChanged(() => Welcome);
            }
        }
        #endregion
    }
}
