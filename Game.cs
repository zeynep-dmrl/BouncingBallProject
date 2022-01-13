using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TopSektirme_Proje5
{
    class Game
    {

        public List<RoundedButton> balls = new List<RoundedButton>();
        public int bcount;

        public Form1 form1;
        public System.Windows.Forms.Timer each10seconds;
        public System.Windows.Forms.Timer moverTimer;
        public Mover gameController;
        public Racket racket;


        public PictureBox left_topStick;
        public PictureBox leftStick;
        public PictureBox rightStick;
        public PictureBox right_topStick;

        public Label result;

        public JsonController jsonController;

        public Thread thread;


        public Game(Form1 form)
        {
            this.form1 = form;
            gameController = new Mover(form);

            each10seconds = new System.Windows.Forms.Timer();
            each10seconds.Enabled = true;
            each10seconds.Interval = 10000;
            each10seconds.Tick += new EventHandler(OnGameTimeTick);

            moverTimer = new System.Windows.Forms.Timer();
            moverTimer.Enabled = true;
            moverTimer.Interval = 100;
            moverTimer.Tick += new EventHandler(OnMoverTimeTick);

            PictureBox racket = new Racket()
            {
                Width = 200,
                Height = 20,
                Location = new Point(270, 366),
                BackColor = Color.FromName("SaddleBrown"),
            };

            RoundedButton ball1 = CreateRoundedButton.createBall();
            form1.Controls.Add(ball1);
            balls.Add(ball1);

            jsonController = new JsonController(this);

            result = new Label();
            
        }

        public void OnGameTimeTick(object sender, EventArgs e)
        {//generate ball every 10 seconds
            bcount = balls.Count;
            if (bcount < 5)
            {
                RoundedButton ball = CreateRoundedButton.createBall();
                form1.Controls.Add(ball);
                balls.Add(ball);

            }

        }

        public void OnMoverTimeTick(object sender, EventArgs e)
        {//movement ball

            bcount = balls.Count;
            if (bcount == 10)
            {
                each10seconds.Stop();
                moverTimer.Stop();

                //label that display result at the end of the game
                result.Text = "KAYBETTİNİZ";
                result.ForeColor = Color.White;
                result.BackColor = Color.Transparent;
                result.Font = new Font("Chiller", 26);
                result.Size = new Size(200, 100);
                result.Location = new Point(255, 195);
                result.Enabled = true;
                form1.Controls.Add(result);

            }
            else
            {   //the ball hits the bars or hits the racket
                for (int i = 0; i < bcount; i++)
                {
                    RoundedButton ball = balls[i];

                    gameController.CollisionGameArea(ball,
                                                     racket,
                                                     left_topStick,
                                                     leftStick,
                                                     rightStick,
                                                     right_topStick,
                                                     balls);
                    gameController.PaddleCollision(ball, racket);
                }
            }

            

        }
        
        //-----------------------------for THREADS--------------------------
        public List<RoundedButton> OnGameThread()
        {//10 saniyede bir top üret
            bcount = balls.Count;
            if (bcount < 5)
            {
                RoundedButton ball = CreateRoundedButton.createBall();
                //form1.Controls.Add(ball);   //!
                balls.Add(ball);

            }
            return balls;

        }
        //--------------------------------------------------------------------

        public void recordGame()
        {//save data every 2 minutes
            jsonController.JsonSerialize();
        }
        
        public void getJsonGameInfo()
        {//fetch data from json file
            jsonController.JsonDeserialize();
        }
        
        public void racketMover()
        {//raket hareket ettir
            racket.Left = Cursor.Position.X - (racket.Width / 2);                                                          
        }

        public void pauseGame()
        {//stop game
            each10seconds.Stop();
            moverTimer.Stop();

            result.Text = "Pause Game";
            result.ForeColor = Color.White;
            result.BackColor = Color.Transparent;
            result.Font = new Font("Chiller", 26);
            result.Size = new Size(200, 100);
            result.Location = new Point(255, 195);
            result.Enabled = true;
            form1.Controls.Add(result);
        }

        public void startGame()
        {//start game
            form1.Controls.Remove(result);
            each10seconds.Start();
            moverTimer.Start();
            
        }

    }
}
