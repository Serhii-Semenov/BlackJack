using System.Windows;
using BlackJack.BJWindows;
using BlackJack.ClientGameLogic;
using BlackJack.GameService;
using System.Collections.Generic;
using System;
using BlackJack.BJService;
using System.Windows.Controls;

namespace BlackJack
{
    /// <summary>
    /// 
    /// </summary>
    public partial class MainWindow : Window
    {


        public MainWindow()
        {
            InitializeComponent();

            ListBox lbxPlayers = new ListBox();
            WrapPanelForList.Children.Add(lbxPlayers);

        }

        private void InitLogin()
        {
            var w = new AuthWindow();
            w.ShowDialog();
            if (w.DialogResult == false) this.Close();
            else
            {
                var nickname = w.NickName;

                if (ClientGameCore.Status == ClientStatus.Offline)
                {
                    Connect(nickname);
                }
                else
                {
                    Disconnect();
                }
            }
        }

        protected override void OnClosing(System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                ServiceProxy.Instance.Logout(ClientGameCore.Player.Id);
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
            
        }

        private void MainWindowGrid_Loaded(object sender, RoutedEventArgs e)
        {
            InitLogin();
        }

        private void Connect(string nickname, int _id)
        {
            try
            {
                ServiceProxy.Instance.Connect(nickname, _id);

                var callback = new ClientCallback();

                callback.PlayersUpdated += pl =>
                    {
                        ClientGameCore.Players = pl;
                        UpdatePlayerList();
                    };

                callback.GameStarted += callback_GameStarted;
                callback.GamePlayerMoved += callback_GamePlayerMoved;

                //service = ServiceProxy.Instance;
                ////service = new GameServiceClient(new InstanceContext(callback));
                var id = ServiceProxy.Instance.Login(nickname, null);
                ClientGameCore.Player = new Player() { Id = id, Nickname = nickname };
                ClientGameCore.Status = ClientStatus.Online;
                GetPlayers();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }           
        }

        internal static void callback_GameStarted(List<GamePlayer> players)
        {
            players.Clear();
            foreach (var p in players)
            {
                //players.Add()
            }
        }

        public static void callback_GamePlayerMoved(GamePlayer player)
        {
           
        }



        private void GetPlayers()
        {
            try
            {
                ClientGameCore.Players = ServiceProxy.Instance.GetPlayers();
                UpdatePlayerList();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }

        public static void UpdatePlayerList()
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
                ServiceProxy.Instance.Logout(ClientGameCore.Player.Id);
                ClientGameCore.Status = ClientStatus.Offline;
                ServiceProxy.Instance.Close();
            }
            catch (Exception err)
            {
                 MessageBox.Show(err.Message);
            }
        }
    }
}