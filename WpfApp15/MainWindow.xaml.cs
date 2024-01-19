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

namespace WpfApp15
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }

    }

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string UserLogin { get; private set; }
        public MainWindow()
        {
            InitializeComponent();
        }

        private void windowreg_Click(object sender, RoutedEventArgs e)
        {
            this.Hide();
            Window1 window = new Window1();
            window.Show();
        }

        private void avtoriz_Click(object sender, RoutedEventArgs e)
        {
            var login = loginnn.Text;
            var passormail = passsss.Text;
            var context = new AppDbContext();

            var user = context.Us.SingleOrDefault(x => x.Login == login && x.Password == passormail || x.Email == passormail);
            if (user is null)
            {
                MessageBox.Show("неверный логин или пароль");
                return;
            }
            UserLogin = loginnn.Text;
            this.Hide();
            Window2 window2 = new Window2(UserLogin);
            window2.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (passssstext.Visibility == Visibility.Visible)
            {
                passssstext.Visibility = Visibility.Hidden;
                passsss.Text = passssstext.Password;
                passsss.Visibility = Visibility.Visible;
            }
            else
            {
                passsss.Visibility = Visibility.Hidden;
                passssstext.Visibility = Visibility.Visible;
            }
        }
    }
}
