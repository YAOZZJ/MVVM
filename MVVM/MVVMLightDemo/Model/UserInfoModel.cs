using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMLightDemo.Model
{
    public class UserInfoModel : ObservableObject
    {
        private string _userName;
        private string _userPhone;
        private string _userSex;
        private string _userAddress;
        /// <summary>
        /// 用户名
        /// </summary>
        public string UserName { get => _userName; set { _userName = value;RaisePropertyChanged(()=>UserName); } }
        /// <summary>
        /// 用户电话
        /// </summary>

        public string UserPhone { get => _userPhone; set { _userPhone = value; RaisePropertyChanged(() => UserPhone); } }

        public string UserSex { get => _userSex; set { _userSex = value; RaisePropertyChanged(() => UserSex); } }
        public string UserAddress { get => _userAddress; set { _userAddress = value; RaisePropertyChanged(() => UserAddress); } }

    }
}
