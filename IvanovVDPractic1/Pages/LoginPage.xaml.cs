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

namespace IvanovVDPractic1.Pages
{
    /// <summary>
    /// Логика взаимодействия для LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        public class UserInfo
        {
            public static string InfoRole
            {
                get;
                set;
            }
        }

        private void AutorizButton_Click(object sender, RoutedEventArgs e)
        {
            var user = App.db.UsersData.Where(x => x.Login == LogBox.Text && x.Password == PassBox.Text).FirstOrDefault();
            if (user != null)
            {
                if (user.Login == "pedophile")
                {
                    MessageBox.Show("Добро пожаловать в панель администрации");
                    UserInfo.InfoRole = "pedophile";
                    App.LoggedUser = user;
                    this.NavigationService.Navigate(new AdminPage());
                }
                else if (user.Login != "pedophile")
                {
                    MessageBox.Show("ЧИНЬ ЧАНЬ ЧЁНЬ ЧИНЬ, АЗИАТСКАЯ ХАВААААА");
                    App.LoggedUser = user;
                    this.NavigationService.Navigate(new UserPage());
                }
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль");
            }
        }
    }
}
