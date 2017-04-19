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
        StackPanel ButtonsStackPanel;
        Button LoginButton;
        Button RegisterButton;
        Image BlackJackImage;
        TabControl LoginTabControl;
        TabControl RegisterTabControl;

        public MainWindow()
        {
            InitializeComponent();

            CreateControls();
        }

        void CreateControls()
        {
            ButtonsStackPanel = new StackPanel();
            ButtonsStackPanel.Height = 45;
            ButtonsStackPanel.Width = 220;
            ButtonsStackPanel.Orientation = Orientation.Horizontal;
            ButtonsStackPanel.HorizontalAlignment = System.Windows.HorizontalAlignment.Right;
            ButtonsStackPanel.VerticalAlignment = System.Windows.VerticalAlignment.Top;

                        
            //создание кнопок
            LoginButton = new Button();
            RegisterButton = new Button();
            //текст кнопок
            LoginButton.Content = "Авторизация";
            RegisterButton.Content = "Регистрация";
            //курсор
            LoginButton.Cursor = Cursors.Hand;
            RegisterButton.Cursor = Cursors.Hand;
            //кнопки по центру стекпанели
            LoginButton.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            RegisterButton.VerticalAlignment = System.Windows.VerticalAlignment.Center;


            //кнопки в стекпанель
            ButtonsStackPanel.Children.Add(LoginButton);
            ButtonsStackPanel.Children.Add(RegisterButton);


            //картинка
            BlackJackImage = new Image();
            BlackJackImage.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            BlackJackImage.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            


            MainWindowGrid.Children.Add(ButtonsStackPanel);
        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}



//ButtonsStackPanel.Background = new SolidColorBrush(Color.FromArgb(0xFF, 0xFF, 0, 0));