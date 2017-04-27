using System.Windows;
using BlackJack.BJWindows;
using BlackJack.ClientGameLogic;
using BlackJack.GameService;
using System.Collections.Generic;
using System;
using System.ServiceModel;

namespace BlackJack
{

    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<PlayerView> players = new List<PlayerView>();

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                BJService.ServiceProxy.Instance.service.Logout(ClientGameCore.Player.Id);
                base.OnClosing(e);
            }
            catch (Exception)
            {
                // TODO                
                // throw;
            }

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

        private void btnConnect_Click(object sender, RoutedEventArgs e)
        {
            if (ClientGameCore.Status == ClientStatus.Offline)
            {
                Connect(txtNickname.Text);
            }
            else
            {
                Disconnect();
            }
        }

        private void Connect(string nickname)
        {
            try
            {
                BJService.ServiceProxy.Instance.Callback.PlayersUpdated += pl =>
                            {
                                ClientGameCore.Players = pl;
                                UpdatePlayerList();
                            };
                BJService.ServiceProxy.Instance.Callback.GameStarted += callback_GameStarted;
                BJService.ServiceProxy.Instance.Callback.GamePlayerMoved += callback_GamePlayerMoved;
                BJService.ServiceProxy.Instance.Connect(nickname);

                btnConnect.Content = "Disconnect";
                GetPlayers();
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void callback_GamePlayerMoved(GamePlayer player)
        {

        }

        private void callback_GameStarted(List<GamePlayer> players)
        {
            players.Clear();
            foreach (var p in players)
            {
                //players.Add()
            }
        }

        private void GetPlayers()
        {
            try
            {
                //ClientGameCore.Players = service.GetPlayers();
                UpdatePlayerList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        private void UpdatePlayerList()
        {
            lbxPlayers.Items.Clear();
            foreach (var p in ClientGameCore.Players.Players.Values)
            {
                lbxPlayers.Items.Add(p.Nickname);
            }
        }

        private void Disconnect()
        {
            try
            {
                BJService.ServiceProxy.Instance.service.Logout(ClientGameCore.Player.Id);
                ClientGameCore.Status = ClientStatus.Offline;
                BJService.ServiceProxy.Instance.service.Close();
                btnConnect.Content = "Connect";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}