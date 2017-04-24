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