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
        private GameServiceClient service;
        private List<PlayerView> players = new List<PlayerView>();

        public MainWindow()
        {
            InitializeComponent();
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            service.Logout(ClientGameCore.Player.Id);
            base.OnClosing(e);
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
            return;

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
                var callback = new ClientCallback();

                callback.PlayersUpdated += pl =>
                    {
                        ClientGameCore.Players = pl;
                        UpdatePlayerList();
                    };

                callback.GameStarted += callback_GameStarted;
                callback.GamePlayerMoved += callback_GamePlayerMoved;

                service = new GameServiceClient(new InstanceContext(callback));
                var id = service.Login(nickname);
                ClientGameCore.Player = new Player() { Id = id, Nickname = nickname };
                ClientGameCore.Status = ClientStatus.Online;
                btnConnect.Content = "Disconnect";
                GetPlayers();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
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
                ClientGameCore.Players = service.GetPlayers();
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
                service.Logout(ClientGameCore.Player.Id);
                ClientGameCore.Status = ClientStatus.Offline;
                service.Close();
                btnConnect.Content = "Connect";
            }
            catch (Exception err)
            {
                 MessageBox.Show(err.Message);
            }
        }
    }
}