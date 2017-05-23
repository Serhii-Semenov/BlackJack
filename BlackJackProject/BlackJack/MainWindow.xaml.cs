using System.Windows;
using BlackJack.BJWindows;
using BlackJack.ClientGameLogic;
using BlackJack.ServiceReference;
using System.Collections.Generic;
using System;
using BlackJack.BJService;
using System.Windows.Controls;
using BJDataLevel.Model;

namespace BlackJack
{
    public partial class MainWindow : Window
    {
        private static ListBox lbxPlayers;

        /// <summary>
        /// Current player use from BJDataLevel.Model;
        /// </summary>
        private Players Plr = new Players(); 

        public string NickName { get; set; }
        public int ID { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            lbxPlayers = new ListBox();
            WrapPanelForList.Children.Add(lbxPlayers);
            lbxPlayers.Items.Add("Name ");
            ServiceProxy.Instance.Initialized += Instance_Initialized;
        }

        void Instance_Initialized()
        {
            ServiceProxy.Instance.Callback.PlayersUpdated += pl =>
            {
                ClientGameCore.Players = pl;
                UpdatePlayerList();
            };

            ServiceProxy.Instance.Callback.GameStarted += callback_GameStarted;
            ServiceProxy.Instance.Callback.GamePlayerMoved += callback_GamePlayerMoved;
        }

        private void InitAuth()
        {
            var w = new AuthWindow();
            w.ShowDialog();
            if (w.DialogResult == false) this.Close();
            else
            {
                Plr.Login = w.NickName;
                Plr.Id = w.ID;

                if (ClientGameCore.Status == ClientStatus.Offline)
                {
                    Connect(Plr.Login, Plr.Id);
                    InitMenu();
                }
                else
                {
                    Disconnect();
                }
            }
        }

        private void InitMenu()
        {
            var w = new MenuWindow(Plr.Login, ServiceProxy.Instance.GetBalanse(Plr.Id)); // костыль
            w.ShowDialog();
            if (w.DialogResult == false) this.Close();

            switch (w.Game)
            {
                case -1:
                    {
                        try
                        {
                            Disconnect();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            throw;
                        }
                        InitAuth();
                    }
                    break;
                case 1:
                    this.Title = "Игра с компьютером";
                    break;
                default:
                    this.Title = "Ничего!";
                    break;
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

        private void MainWindowGrid_Loaded(object sender, RoutedEventArgs e)
        {
            InitAuth();
        }

        private void Connect(string nickname, int _id)
        {
            try
            {
                ServiceProxy.Instance.Connect(nickname, _id);
                //ClientGameCore.Player = new Player() { Id = _id, Nickname = nickname };
                //ClientGameCore.Status = ClientStatus.Online;
                GetPlayers();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }           
        }

        internal void callback_GameStarted(List<GamePlayer> players)
        {
            players.Clear();
            foreach (var p in players)
            {
                //players.Add()
            }
        }

        public void callback_GamePlayerMoved(GamePlayer player)
        {
            
        }

        private void GetPlayers()
        {
            //try
            //{
            //    ClientGameCore.Players = ServiceProxy.Instance.GetPlayers();
            //    UpdatePlayerList();
            //}
            //catch (Exception err)
            //{
            //    MessageBox.Show(err.Message);
            //}
        }

        public void UpdatePlayerList()
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