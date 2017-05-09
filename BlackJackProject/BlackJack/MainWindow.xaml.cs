using System.Windows;
using BlackJack.BJWindows;
using BlackJack.ClientGameLogic;
using BlackJack.GameService;
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

        }

        private void InitLogin()
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
                //ClientGameCore.Player = new Player() { Id = _id, Nickname = nickname };
                //ClientGameCore.Status = ClientStatus.Online;
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