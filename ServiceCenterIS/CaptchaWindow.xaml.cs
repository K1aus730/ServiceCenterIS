using ServiceCenterIS.ViewModels;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ServiceCenterIS
{
    /// <summary>
    /// Логика взаимодействия для CaptchaWindow.xaml
    /// </summary>
    public partial class CaptchaWindow : Window
    {
        public CaptchaWindow()
        {
            InitializeComponent();
            NewCaptcha();
        }

        public void NewCaptcha()
        {

            String allowchar = " ";

            allowchar = "A,B,C,D,E,F,G,H,I,J,K,L,M,N,O,P,Q,R,S,T,U,V,W,X,Y,Z";

            allowchar += "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,y,z";

            allowchar += "1,2,3,4,5,6,7,8,9,0";

            char[] a = { ',' };

            String[] ar = allowchar.Split(a);

            String pwd = "";

            string temp = " ";

            Random r = new Random();

            for (int i = 0; i < 7; i++)
            {
                temp = ar[r.Next(0, ar.Length)];
                pwd += temp;
            }
            textblockCaptcha.Text = pwd;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            if (tbCaptcha.Text == textblockCaptcha.Text)
            {
                MessageBox.Show($"Добро пожаловать,{AuthorizationViewModel.Employee.Name}");
            }
            else
            {
                MessageBox.Show("Ввели неверно!");
                textblockCaptcha.Text = "";
                NewCaptcha();

            }
        }
    }
}
