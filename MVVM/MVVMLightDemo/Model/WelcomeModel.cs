using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.Model
{
    public class WelcomeModel : ObservableObject
    {
        private string _instroduction;

        public string Instroduction
        {
            get => _instroduction;
            set
            {
                _instroduction = value;
                RaisePropertyChanged(() => Instroduction);
            } }
    }
}
