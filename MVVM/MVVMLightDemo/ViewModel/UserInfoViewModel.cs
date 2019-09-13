using GalaSoft.MvvmLight;
using MVVMLightDemo.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.ViewModel
{
    public class UserInfoViewModel: ViewModelBase
    {
        private UserInfoModel userInfo;

        //public UserInfoModel UserInfo { get => userInfo; set { userInfo = value; RaisePropertyChanged(() => UserInfo); } } 
        public UserInfoViewModel()
        {
            UserInfo = new UserInfoModel();
            UserInfo.UserName = "YAOZJ";
        }

        public UserInfoModel UserInfo { get => userInfo; set => userInfo = value; }
    }
}
