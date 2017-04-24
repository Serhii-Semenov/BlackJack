using System;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;

namespace BlackJack
{
    /// <summary>
    /// Логика взаимодействия для RegisterForm.xaml
    /// </summary>
    public partial class RegisterForm : Window
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private static bool IsEmailAllowed(string text)
        {
            bool ValidEmail = false;
            Regex regEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (text.Length > 0)
            {
                ValidEmail = regEMail.IsMatch(text);
            }

            return ValidEmail;
        }

        private void txtEmail_LostFocus(object sender, RoutedEventArgs e)
        {
            if (IsEmailAllowed(txtEmail.Text.Trim()) == false)
            {
                e.Handled = true;
                MessageBox.Show("Введите E-Mail", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                txtEmail.Focus();
            }
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


        private void txtLogin_LostFocus(object sender, RoutedEventArgs e)
        {
            if (IsLoginAllowed(txtLogin.Text.Trim()) == false)
            {
                e.Handled = true;
                MessageBox.Show("Введите логин", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                txtLogin.Focus();
            }
        }

        private void Content_TextChanged(Object sender, RoutedEventArgs args)
        {
            if (!txtPassw.Password.Equals(txtConfirmPassword.Password))
            {
                RegisterButton.IsEnabled = false;
            }                
            else
            {
                RegisterButton.IsEnabled = true;
            }
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
