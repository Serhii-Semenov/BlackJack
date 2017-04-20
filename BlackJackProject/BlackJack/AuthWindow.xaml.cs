using System.Windows;
using System.Text.RegularExpressions;


namespace BlackJack
{
    /// <summary>
    /// Логика взаимодействия для AuthWindow.xaml
    /// </summary>
    public partial class AuthWindow : Window
    {
        
        public AuthWindow()
        {
            InitializeComponent();
            
            
            

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private static bool IsLoginAllowed(string text)
        {
            bool ValidLogin = false;
            Regex regLogin = new Regex(@"^[a-zA-Zа-яА-Я][a-zA-Zа-яА-Я0-9]{2,9}$");
            if (text.Length > 0)
            {
                ValidLogin = regLogin.IsMatch(text);
            }

            return ValidLogin;
        }


        private void LoginTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (IsLoginAllowed(LoginTextBox.Text.Trim()) == false)
            {
                e.Handled = true;
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                LoginTextBox.Focus();
            }
        }

        
    }
}

