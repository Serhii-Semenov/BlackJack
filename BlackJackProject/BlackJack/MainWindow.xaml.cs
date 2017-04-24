using System.Windows;
using BlackJack.BJWindows;

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
        
        private void btnMenuWindow_Click(object sender, RoutedEventArgs e)
        {
            var w = new AuthWindow();
            w.ShowDialog();
            if (w.DialogResult == false) this.Close();
            else this.Visibility = Visibility.Visible;
        }

        private void MainWindowGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
            btnMenuWindow_Click(null, null);
            
        }
    }
}