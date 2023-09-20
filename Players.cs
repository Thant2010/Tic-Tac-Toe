using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Tic_Tac_Toe
{
    internal class Players
    {
        private Image playerImage = new Image();

        public string Player { get; set; }
      
        public Image Image { get
            {
                return playerImage;
            } }

        public Players(string player)
        {
            Player = player.ToUpper();
            
            string source = "Img/" + player.ToUpper() + "-Neon.png";
            this.playerImage.Source = new ImageSourceConverter().ConvertFromString(source) as ImageSource;

        }

    }
}
