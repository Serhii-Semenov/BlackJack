using System.Windows;

namespace BlackJack
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegisterForm regForm = new RegisterForm();
            regForm.Show();
        }

        
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            AuthWindow authWindow = new AuthWindow();
            authWindow.Show();
        }
        private void btnMenuWindow_Click(object sender, RoutedEventArgs e)
        {
            var w = new MenuWindow();
            w.ShowDialog();
        }

        private void MainWindowGrid_Loaded(object sender, RoutedEventArgs e)
        {
            btnMenuWindow_Click(null, null);
        }
    }
}



//ButtonsStackPanel.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0, 0));