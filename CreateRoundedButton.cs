using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirme_Proje5
{
    public class CreateRoundedButton : RoundedButton
    {
        //public string Name { get; set; }
        //public string BackColor { get; set; }
        public const int Height = 30;
        public const int Width = 30;


        public CreateRoundedButton()
        {}
        
        //generate random color for ball Backcolor
        public static string BtnColors()
        {
            string[] colors = { "Red", "Blue", "Green", "Yellow", "Purple" };
            Random rnd = new Random();
            int i = rnd.Next(colors.Length);
            return colors[i];
        }
       
        //generate random string for ball name
        public static string rndStringGenerator()
        {
            Random rnd = new Random();
            var builder = new StringBuilder(3);
            for (int i = 0; i< 3; i++)
            {
                //var @char = (char)rnd.Next(0, 26);
                var @char = (char)rnd.Next(65,91);
                builder.Append(@char);
            }
            return builder.ToString();
        }
        
        //create rounded button then returns
        public static RoundedButton createBall()
        {
            Random randomNbr = new Random();
            RoundedButton button = new CreateRoundedButton()
            {
                Name = CreateRoundedButton.rndStringGenerator(),
                BackColor = Color.FromName(CreateRoundedButton.BtnColors()),
                Size = new Size(30, 30),
                Location = new Point(randomNbr.Next(140, 200), randomNbr.Next(80, 200)),
            };
            return button;
        }

    }

}
