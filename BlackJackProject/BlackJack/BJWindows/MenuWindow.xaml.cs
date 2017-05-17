using BlackJack.BJService;
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
using System.Windows.Shapes;

namespace BlackJack.BJWindows
{
    /// <summary>
    /// Логика взаимодействия для MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();

            InitLogin();
            
        }

        public MenuWindow(string login, int coin)
        {
            InitializeComponent();

            InitPlayer(login, coin);
        }

        private void InitPlayer(string login, int coin)
        {
            lblCoin.Content = coin.ToString();
            lblPlayerName.Content = login;
        }

        private void InitLogin()
        {
            while (true)
            {
                var w = new AuthWindow();
                w.ShowDialog();
                if (w.DialogResult == false) this.Close();
                else
                {
                    this.Visibility = Visibility.Visible;
                    //lblPlayerName = 
                    return;
                }
            }
        }

        private void btnGameSolo_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void btnGameRoom_Click(object sender, RoutedEventArgs e)
        {
            // TODO
            var w = new RoomToFindPlayer();
            w.ShowDialog();
        }

        private void btnGetCredit_Click(object sender, RoutedEventArgs e)
        {
            //TODO
            //ServiceProxy.Instance.service.
        }

        private void btnRule_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void btnStatistic_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }

        private void btnLogout_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }
    }
}
