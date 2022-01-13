using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Drawing;

namespace TopSektirme_Proje5
{
    class JsonController
    {
        Game game;
        bool jsonFileEncryptControl = true;

        public JsonController(Game gameJ)
        {
            game = gameJ;
        }

        //data model
        [Serializable]
        public class GameInfo
        {
            [JsonProperty("name")]
            public string name { get; set; }

            [JsonProperty("color")]
            public Color color { get; set; }

            [JsonProperty("location")]
            public Point location { get; set; }

            [JsonProperty("size")]
            public Size size { get; set; }
            [JsonProperty("score")]
            public int score { get; set; }

            [JsonProperty("numberOfBall")]
            public int numberOfBall { get; set; }

        }
        
        
        public void Encrypt(string path)    
        {
            Byte[] encryptArray = File.ReadAllBytes(path);   //reads the contents of the file into a byte array and then closes the file.
            for (int i = 0; i<encryptArray.Length; i++)
            {
                encryptArray[i] = (Byte)((int)encryptArray[i] + 1);
                if(encryptArray[i] > 255)
                {
                    encryptArray[i] = 0;
                }
            }
            File.WriteAllBytes(path,encryptArray);
            jsonFileEncryptControl = true;
        }
        
        public void Decrypt(string path)
        {
            Byte[] decryptFile = File.ReadAllBytes(path);
            for(int i = 0; i < decryptFile.Length; i++)
            {
                if( (Byte)( (int)decryptFile[i] - 1) < 0)
                {
                    decryptFile[i] = 255;
                }
                else
                {
                    decryptFile[i] = (Byte)((int)decryptFile[i] - 1);
                }
            }
            File.WriteAllBytes(path, decryptFile);
            jsonFileEncryptControl = false;
        }

        //SERİALİZE JSON
        public void JsonSerialize()
        {
            string filePath = @"C:\Users\LENOVO\source\repos\TopSektirme_Proje5\gp_yedek.json";

            int bcount = game.balls.Count;

            List<GameInfo> data = new List<GameInfo>();

            for (int i = 0; i < bcount; i++)
            {//add model data to json file
                data.Add(new GameInfo()
                {
                    name = game.balls[i].Name,
                    color = game.balls[i].BackColor,
                    location = game.balls[i].Location,
                    size = game.balls[i].Size,
                    score = Mover.score,
                    numberOfBall = bcount,


                });
            }
            string json = JsonConvert.SerializeObject(data.ToArray());
            File.WriteAllText(filePath, json);
            Encrypt(filePath);
        }

        //DESERİALİZE JSON
        public void JsonDeserialize()
        {
            string filePath = @"C:\Users\LENOVO\source\repos\TopSektirme_Proje5\gp_yedek.json";
            if (jsonFileEncryptControl)
            {
                Decrypt(filePath);
            }
            
            StreamReader r = new StreamReader(filePath); // use to read a file
            string jsonString = r.ReadToEnd();          
            var gI = JsonConvert.DeserializeObject<dynamic>(jsonString);
            Console.WriteLine(gI);

            int bcount = game.balls.Count;
            // delete current balls on form1
            for (int i = 0; i < bcount; i++)
            {
                game.form1.Controls.Remove(game.balls[i]);
            }

            game.balls.Clear(); //delete all balls in list
            //then add old(new) ball that in json file to list/form1
            foreach (var item in gI)
            {
                Mover.score = item.score;
                game.form1.Controls["scorelbl"].Text = "Score : " + item.score.ToString();

                RoundedButton ball = new RoundedButton();
                ball.Name = item.name;
                ball.BackColor = item.color;
                ball.Location = item.location;
                ball.Size = item.size;
                game.balls.Add(ball);
                game.form1.Controls.Add(ball);
            }
            r.Close();
            Encrypt(filePath);
        }
      
       
    }
}
