using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceCenterIS.ViewModels
{
    internal class AuthorizationViewModel : ViewModelBase
    {
        public static Employee Employee { get; set; }
        public string Login { get; set; }

        public AuthorizationViewModel()
        {
            Title = "Авторизация";
        }

        public IGettingPassword GettingPassword {private get; set; }

        private string Password
        {
            get => GettingPassword.GetPassword();
        }

        public bool LogIn()
        {
            try
            {
                Employee = DataBase.GetContext().Employee.FirstOrDefault(p => p.Login == Login && p.Password == Password);
            }
            catch (Exception)
            {

            }
            return Employee != null;
        }
    }
}
