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
    /// Логика взаимодействия для RoomToFindPlayer.xaml
    /// </summary>
    public partial class RoomToFindPlayer : Window
    {
        public RoomToFindPlayer()
        {
            InitializeComponent();

            addVizualRandomPlayers();
        }

        private void addVizualRandomPlayers()
        {
            const int maxPlayers = 5;
            int p = new Random().Next(1, maxPlayers);
            Label[] labels = new Label[p];
            for (int i = 0; i < p; i++)
            {
                labels[i] = new Label();
                labels[i].Width = 90; // Ширина
                labels[i].Height = 30; // Высота
                labels[i].Margin = new Thickness(20, 0, 20, 0);// Позиция
                labels[i].Name = "lblPlayer" + i;
                labels[i].Content = "Игрок " + (i + 2);
                spPlaers.Children.Add(labels[i]);
            }
        }

        private void btnStartGame_Click(object sender, RoutedEventArgs e)
        {
            // TODO
        }
    }
}
