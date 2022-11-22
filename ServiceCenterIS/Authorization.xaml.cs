using ServiceCenterIS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ServiceCenterIS
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class Authorization : Window, IGettingPassword
    {

        public Authorization()
        {
            InitializeComponent();
            (DataContext as AuthorizationViewModel).GettingPassword = this;
        }

        public string GetPassword() => pbPass.Password;

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if ((DataContext as AuthorizationViewModel).LogIn())
            {
                CaptchaWindow captchaWindow = new CaptchaWindow();
                captchaWindow.Show();
            }
            else MessageBox.Show("Неверный логин или пароль!");
        }
    }
}
