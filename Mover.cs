using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirme_Proje5
{
    public class Mover
    {
        Form form1;

        public int speed_left = 4;
        public int speed_top = 4;

        public static int score = 0;

        public Mover(Form form)
        {
            form1 = form;
        }

        //controls ball hits racket and following movement
        public void PaddleCollision(RoundedButton button, Racket racket)
        {
            button.Left += speed_left;
            button.Top += speed_top;

            if (button.Bounds.IntersectsWith(racket.Bounds))        //ball hitting the racket
            {
                speed_top = -speed_top;
                score += 1;
                form1.Controls["scorelbl"].Text = "Score : " + score.ToString();
            }
        }

        //controls ball hits sticks and following movement
        public void CollisionGameArea(
            RoundedButton button,
            Racket racket,
            PictureBox left_topStick,
            PictureBox leftStick,
            PictureBox rightStick,
            PictureBox right_topStick,
            List<RoundedButton> balls
            )
        {

            button.Left += speed_left;  
            button.Top += speed_top;    

            //<Sticks>
            if (button.Bounds.IntersectsWith(leftStick.Bounds))         //ball hitting the left stick
            {
                speed_left = -speed_left;
            }
            if (button.Bounds.IntersectsWith(rightStick.Bounds))        //ball hitting the right stick
            {
                speed_left = -speed_left;
            }
            if (button.Bounds.IntersectsWith(right_topStick.Bounds))    //ball hitting the right-top stick
            {
                speed_top = -speed_top;
            }
            if (button.Bounds.IntersectsWith(left_topStick.Bounds))     //ball hitting the left-top stick
            {
                speed_top = -speed_top;
            }
            // </>

            // <ball out of the game>
            //TOP
            if(button.Location.Y < 0) 
            {
                form1.Controls.Remove(button);
                balls.Remove(button);
                score += 10;
                form1.Controls["scorelbl"].Text = "Score : " + score.ToString();

            }
            //BOTTOM
            else if(button.Location.Y > 366)
            {
                form1.Controls.Remove(button);
                balls.Remove(button);

                score -= 20;
                form1.Controls["scorelbl"].Text = "Score : " + score.ToString();

                // add 2 balls
                RoundedButton oneball = CreateRoundedButton.createBall();
                balls.Add(oneball);
                form1.Controls.Add(oneball);

                RoundedButton twoball = CreateRoundedButton.createBall();
                balls.Add(twoball);
                form1.Controls.Add(twoball);

                
                
            }
            // </>

        }
       
    }
}
