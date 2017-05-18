using System.Windows;
using System.Text.RegularExpressions;
using BlackJack.BJService;

namespace BlackJack.BJWindows
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        public string NickName { get; set; }
        public int ID { get; set; }
        private bool CheckPassword { get; set; }
        private bool CheckLogin { get; set; }

        public AuthWindow()
        {
            InitializeComponent();
            lbLoginError.Visibility = System.Windows.Visibility.Hidden;
            lbPasswError.Visibility = System.Windows.Visibility.Hidden;
            LoginButton.IsEnabled = false;
            CheckPassword = false;
            CheckLogin = false;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }

        private static bool IsLoginAllowed(string text)
        {
            bool ValidLogin = false;
            Regex regLogin = new Regex(@"^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            if (text.Length > 1)
            {
                ValidLogin = regLogin.IsMatch(text);
            }

            return ValidLogin;
        }
                
        private void btnRegestration_Click(object sender, RoutedEventArgs e)
        {
            RegisterForm rf = new RegisterForm();
            rf.ShowDialog();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ID = ServiceProxy.Instance.Login(tbLogin.Text, tbPassword.Password);
            if (ID > 0)
            {
                // temp message
                // MessageBox.Show("True " + tbLogin.Text, ID.ToString(), MessageBoxButton.OK, MessageBoxImage.Information);

                NickName = tbLogin.Text;

                DialogResult = true;
                // Connect
                this.Close();
            }
            else
            {
                lbLoginError.Visibility = System.Windows.Visibility.Visible;
                lbLoginError.Content = "Неправильный логин или пароль";
            }            
        }

        private void tbLogin_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (IsLoginAllowed(tbLogin.Text.Trim()) == false)
            {
                lbLoginError.Visibility = System.Windows.Visibility.Visible;
                lbLoginError.Content = "Логин введен некорректно";
                CheckLogin = false;
                CheckAll();
            }
            else
            {
                lbLoginError.Visibility = System.Windows.Visibility.Hidden;
                CheckLogin = true;
                CheckAll();
            }            
        }

        private void tbPassword_PreviewKeyUp(object sender, System.Windows.Input.KeyEventArgs e)
        {
            if (string.IsNullOrEmpty(tbPassword.Password))
            {
                lbPasswError.Visibility = System.Windows.Visibility.Visible;
                lbPasswError.Content = "Введите пароль";
                CheckPassword = false;
                CheckAll();
            }
            else
            {
                lbPasswError.Visibility = System.Windows.Visibility.Hidden;
                CheckPassword = true;
                CheckAll();
            }  
        }


        private void CheckAll()
        {
            if(CheckLogin && CheckPassword)
            {
                LoginButton.IsEnabled = true;
            }
            else
            {
                LoginButton.IsEnabled = false;
            }
        }
    }
}

