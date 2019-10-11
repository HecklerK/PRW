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

namespace PRW.Pages
{
    /// <summary>
    /// Логика взаимодействия для AuthPage.xaml
    /// </summary>
    public partial class AuthPage : Page
    {
        public AuthPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(Login.Text) || string.IsNullOrEmpty(Passsword.Password))
            {
                MessageBox.Show("Введите логин и пароль");
                return;
            }

            using (var db = new APEntities())
            {
                var user = db.User
                    .AsNoTracking()
                    .FirstOrDefault(u => u.Login == Login.Text && u.Password == Passsword.Password);
                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден");
                    return;
                }

                MessageBox.Show("Пользователь найден");
                switch (user.Role)
                {
                    case "Директор":
                        NavigationService.Navigate(new DirectorMenu());
                        break;
                }
            }
        }
    }
}
