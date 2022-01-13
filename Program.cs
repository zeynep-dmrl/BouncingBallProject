using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Diagnostics;

namespace TopSektirme_Proje5
{
    static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            
            Form1 ponggame = new Form1();
            Application.Run(ponggame);
            var timer = Stopwatch.StartNew();

            Task t = Task.Run(() =>
            {
                foreach (RoundedButton b in ponggame.createThreadTask()) {
                    ponggame.Controls.Add(b);

                };

            });
            Console.WriteLine($"{timer.ElapsedMilliseconds: #, ##0}ms");

            
            
        }
        

       
    }
}
