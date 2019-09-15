using Caliburn.Micro;
using CaliburnMicroDemo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace CaliburnMicroDemo
{
    public class Bootstrapper : BootstrapperBase
    {
        #region Constructor
        public Bootstrapper()
        {
            Initialize();
        }
        #endregion

        #region Overrides
        protected override void OnStartup(object sender, StartupEventArgs e)
        {
            //定义了一套简洁有效的 “命名约定” 功能，用于匹配 View 和 ViewModel 之间的联系。
            //获取到指定 VM 的全名，并移除了 “Model” 部分，剩下的部分便是对应的 View
            // DisplayRootViewFor<IShell>();
            DisplayRootViewFor<WelcomeViewModel>();
        }
        #endregion
    }
}
