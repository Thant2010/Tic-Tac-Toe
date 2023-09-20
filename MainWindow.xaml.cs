using System;
using System.CodeDom;
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



namespace Tic_Tac_Toe
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] fields = new string[9];
        Players[] gamePlayer = new Players[] { new Players("x"), new Players("o") };
        Random random = new Random();
        Players currentPlayer;
        Button[] buttons;

        public MainWindow()
        {
            InitializeComponent();
            currentPlayer = gamePlayer[random.Next(gamePlayer.Length)];
            lblPlayer.Content = currentPlayer.Image;
            buttons = new Button[] { btn_0, btn_1, btn_2, btn_3, btn_4, btn_5, btn_6, btn_7, btn_8 };
        }

        public void NewGame()
        {
            fields = new string[9];
            currentPlayer = gamePlayer[random.Next(gamePlayer.Length)];
            lblPlayer.Content = currentPlayer.Image;

            foreach(Button btn in this.buttons)
            {
                btn.Content = null;
                btn.IsEnabled = true;
            }

        }

        public void ChangePlayer()
        {
            switch (this.currentPlayer.Player)
            {
                case "X":
             
                    this.currentPlayer = gamePlayer[1];
                    lblPlayer.Content = currentPlayer.Image;
                    break;
                case "O":
           
                    this.currentPlayer = gamePlayer[0];
                    lblPlayer.Content = currentPlayer.Image;
                    break;
            }
        
        }

        public bool CheckOfWin()
        {
            bool win = false;
            bool remis = false;

            
           
            if (fields[0] == currentPlayer.Player && fields[1] == currentPlayer.Player && fields[2] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[3] == currentPlayer.Player && fields[4] == currentPlayer.Player && fields[5] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[6] == currentPlayer.Player && fields[7] == currentPlayer.Player && fields[8] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[0] == currentPlayer.Player && fields[3] == currentPlayer.Player && fields[6] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[1] == currentPlayer.Player && fields[4] == currentPlayer.Player && fields[7] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[2] == currentPlayer.Player && fields[5] == currentPlayer.Player && fields[8] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[0] == currentPlayer.Player && fields[4] == currentPlayer.Player && fields[8] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }
            else if (fields[2] == currentPlayer.Player && fields[4] == currentPlayer.Player && fields[6] == currentPlayer.Player)
            {
                MessageBox.Show("Spieler " + currentPlayer.Player + " hat Gewonnen!");
                win = true;
            }

            if (!win)
            {
                foreach (Button btn in buttons)
                {
                    if (btn.Content == null)
                    {
                        remis = false;
                        break;
                    }
                    else
                    {
                        remis = true;
                    }
                }
            }

            if (!remis )
            {
                return win;
            }
            else
            {
                lblPlayer.Content = null;
                MessageBox.Show("Unentschieden");
                return true;
            }

        }

        public void GameLoop()
        {
            if (!CheckOfWin())
            {
                ChangePlayer();
            }
            else
            {
                foreach(Button btn in buttons)
                {
                    btn.IsEnabled = false;
                }
            }
        }

        public Image PlayerImage(string player)
        {

            var img = new Image();
            img.Source = new BitmapImage(new Uri("img/" + player + "-Neon.png", UriKind.Relative));
            return img;

        }

        private void btn_0_Click(object sender, RoutedEventArgs e)
        {

            
            btn_0.Content = PlayerImage(currentPlayer.Player);
            fields[0] = currentPlayer.Player;
            GameLoop();
            btn_0.IsEnabled = false;

        }

        private void btn_1_Click(object sender, RoutedEventArgs e)
        {
            
            btn_1.Content = PlayerImage(currentPlayer.Player);
            fields[1] = currentPlayer.Player;
            GameLoop();
            btn_1.IsEnabled = false;
        }


        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            
            btn_2.Content = PlayerImage(currentPlayer.Player);
            fields[2] = currentPlayer.Player;
            GameLoop();
            btn_2.IsEnabled = false;
        }

        private void btn_3_Click(object sender, RoutedEventArgs e)
        {
            
            btn_3.Content = PlayerImage(currentPlayer.Player);
            fields[3] = currentPlayer.Player;
            GameLoop();
            btn_3.IsEnabled = false;
        }

        private void btn_4_Click(object sender, RoutedEventArgs e)
        {
            btn_4.Content = PlayerImage(currentPlayer.Player);
            fields[4] = currentPlayer.Player;
            GameLoop();
            btn_4.IsEnabled = false;
        }

        private void btn_5_Click(object sender, RoutedEventArgs e)
        {
            btn_5.Content = PlayerImage(currentPlayer.Player);
            fields[5] = currentPlayer.Player;
            GameLoop();
            btn_5.IsEnabled = false;
        }

        private void btn_6_Click(object sender, RoutedEventArgs e)
        {
            btn_6.Content = PlayerImage(currentPlayer.Player);
            fields[6] = currentPlayer.Player;
            GameLoop();
            btn_6.IsEnabled = false;
        }

        private void btn_7_Click(object sender, RoutedEventArgs e)
        {
            btn_7.Content = PlayerImage(currentPlayer.Player);
            fields[7] = currentPlayer.Player;
            GameLoop();
            btn_7.IsEnabled = false;
        }

        private void btn_8_Click(object sender, RoutedEventArgs e)
        {
            btn_8.Content = PlayerImage(currentPlayer.Player);
            fields[8] = currentPlayer.Player;
            GameLoop();
            btn_8.IsEnabled = false;
        }
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            NewGame();
        }
    }
}
