using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroDemo.ViewModels
{
    public class WelcomeViewModel : PropertyChangedBase
    {
        public WelcomeViewModel()
        {
            _instruction = "YAOZHIJIAN";
        }
        private string _instruction;
        /// <summary>
        /// 对应View:x:Name="XXXX"
        /// </summary>
        public string TxtInstruction
        {
            get { return _instruction; }
            set
            {
                _instruction = value;
                NotifyOfPropertyChange(()=> TxtInstruction);
                NotifyOfPropertyChange(() => CanBtnClickMe);
            }
        }
        /// <summary>
        /// 关联到方法BtnClickMe的可用性
        /// </summary>
        public bool CanBtnClickMe
        {
            get { return !string.IsNullOrWhiteSpace(TxtInstruction); }
        }
        /// <summary>
        /// 对应VIew的Button :x:Name="XXXX"
        /// </summary>
        public void BtnClickMe()
        {
            MessageBox.Show($"Hello {TxtInstruction}");
        }
    }
}
