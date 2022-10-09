using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.ObjectModel;
using RegistrWindowForBoomBank.Model;

namespace RegistrWindowForBoomBank.Core
{
    public static class FileWriter
    {
        //public ObservableCollection<string>
        public static void FileWrite(User user)
        {
            using (StreamWriter reader = new StreamWriter(@"..\..\File\Users.txt", true))
            {
                string userInfo = user.FirstName + ";" + user.MiddleName + ";" + user.LastName + ";" + user.Phone + ";" + user.Password + $";{user.Role};" + user.BankCard;
                reader.WriteLine(userInfo);
            }
        }
    }
}
