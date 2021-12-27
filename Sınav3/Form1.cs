using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sınav3
{
    public partial class Form1 : Form
    {
        int enSonSure = 0;
        string isim = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath + "/adSure.txt");
            string[] lines = File.ReadAllLines(path);
            string[,] adSure = new string[lines.Length, 2];      

            for (int i = 0; i < adSure.GetLength(0); i++)
            {
                string[] line = lines[i].Split(';');
                adSure[i, 0] = line[0];
                adSure[i, 1] = line[1];
                if (i < Convert.ToInt32(adSure[i,1])-1)
                {
                    enSonSure = Convert.ToInt32(adSure[i,1]);
                }            
            }

            for (int i = 0; i < adSure.GetLength(0); i++)
            {
                if (Convert.ToInt32(adSure[i,1]) < enSonSure)
                {
                    enSonSure = Convert.ToInt32(adSure[i, 1]);
                    isim = adSure[i, 0];
                }
            }
            lblSonuc.Text = $"{isim} isimli oyuncu {enSonSure} sn ile birinci.";
            timer1.Interval = 5000;
        }
    }
}
