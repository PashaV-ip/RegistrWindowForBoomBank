using RegistrWindowForBoomBank.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrWindowForBoomBank.ViewModel
{
    public class MenuWindowViewModel : BaseViewModel
    {
        private string _userInfo;
        public string UserInfo
        {
            get => _userInfo;
            set
            {
                _userInfo = value;
                OnPropertyChanged(nameof(UserInfo));
            }
        }
        public MenuWindowViewModel()
        {
            UserInfo = StaticUserRegistr.InfoUser;
        }
    }
}
