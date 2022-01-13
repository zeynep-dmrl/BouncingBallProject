using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;


namespace TopSektirme_Proje5
{
    public partial class Form1 : Form
    {
        Game game;

        public Form1()
        {
            game = new Game(this);
            InitializeComponent();
           
            game.leftStick = leftStick;
            game.rightStick = rightStick;
            game.left_topStick = left_topStick;
            game.right_topStick = right_topStick;

            game.racket = this.racket;

            timer2 = game.each10seconds;
  
            timer3 = game.moverTimer;

            //Message
            string filePath = @"C:\Users\LENOVO\source\repos\TopSektirme_Proje5\gp_yedek.json";
            if (File.Exists(filePath))
            {// this is message before the game starts
                DialogResult dialogResult = MessageBox.Show("Yedekten oyun yükleme yapılsın mı?", "Biliglendirme Kutusu", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)   //if return yes response from the message
                {
                    game.getJsonGameInfo(); //build game according to backup data from json file
                }
                else if (dialogResult == DialogResult.No)  // if return no response from the message
                {
                    TextWriter jsonFile = new StreamWriter(filePath); // start new game then delete json file if exist
                    jsonFile.Write("");
                    jsonFile.Close();
                }
            }
            
          
        }

        //racket movement control
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            game.racketMover();
        }

        //ball generator timerTick
        private void onGameTimer2Tick(object sender, EventArgs e)
        {
            game.OnGameTimeTick(sender,e);
        }

        //provides all movements work timerTick
        private void OnMoverTimer3Tick(object sender, EventArgs e)
        {
            game.racketMover();
            game.OnMoverTimeTick(sender, e);
        }

        //saves data to json file every 2 minutes timerTick
        private void recordGameInfo(object sender, EventArgs e)
        {
            game.recordGame();
        }

        //------------------------THREADS--------------------------------
        public List<RoundedButton> createThreadTask()
        {
            return game.OnGameThread();
        }

        //--------------------------------------------------------------
       
        //play button that starts the game when the game is stopped
        private void playBtn_Click(object sender, EventArgs e)
        {
            playBtn.Enabled = false;
            pauseBtn.Enabled = true;
            game.startGame();
        }

        //pause button that stops the game at any time
        private void pauseBtn_Click(object sender, EventArgs e)
        {
            playBtn.Enabled = true;
            pauseBtn.Enabled = false;
            game.pauseGame();

        }
      
        //backUp button that automatically back up game data to json file
        private void autoBackup(object sender, EventArgs e)
        {
            game.recordGame();
        }

        //restore button that load game data from json file
        private void autoRestore(object sender, EventArgs e)
        {
            game.getJsonGameInfo();
        }
    }
}
