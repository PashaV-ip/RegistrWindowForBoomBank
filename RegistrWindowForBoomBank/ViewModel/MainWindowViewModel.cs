using RegistrWindowForBoomBank.Core;
using RegistrWindowForBoomBank.Model;
using RegistrWindowForBoomBank.View.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace RegistrWindowForBoomBank.ViewModel
{
    public class MainWindowViewModel : BaseViewModel
    {
        private User _user;
        public User User
        {
            get => _user;
            set
            {
                _user = value;
                OnPropertyChanged(nameof(User));
            }
        }
        public void Exit()
        {
            foreach (Window item  in Application.Current.Windows)
            {
                if(item is MainWindow)
                {
                    item.Close();
                }
            }
        }
        public void Reagistr()
        {
            if (!string.IsNullOrEmpty(User.FirstName) &&
                !string.IsNullOrEmpty(User.MiddleName) &&
                !string.IsNullOrEmpty(User.LastName) &&
                !string.IsNullOrEmpty(User.Phone) &&
                !string.IsNullOrEmpty(User.Password) &&
                !string.IsNullOrEmpty(User.BankCard))
            {
                FileWriter.FileWrite(User);
                StaticUserRegistr.InfoUser = User.ToString();
                MessageBox.Show("Вы успешно зарегестрировались!", 
                    "Регистрация", MessageBoxButton.OK);
                MenuWindow menuWindow = new MenuWindow();
                menuWindow.Show();
                Exit();
            }
            else
            {
                MessageBox.Show("Одно или несколько полей пустые!", 
                    "Ошибка..", MessageBoxButton.OK);
            }
        }
        public MainWindowViewModel()
        {
            User = new User();
        }
    }
}
