using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Sınav2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            lstResult.Items.Clear();

            int toplamPuan = 0;

            string path = Path.Combine(Application.StartupPath + "/teams.txt");
            string[] lines = File.ReadAllLines(path);
            string[,] teamsProp = new string[lines.Length,2];

            for (int i = 0; i < teamsProp.GetLength(0); i++)
            {
                string[] line = lines[i].Split(';');
                teamsProp[i, 0] = line[0];
                teamsProp[i, 1] = line[1];                       
            }
            for (int i = 0; i < teamsProp.GetLength(0); i++)
            {
                string[] puan = teamsProp[i, 1].Split('-');

                for (int j = 0; j < 5; j++)
                {
                    if (puan[j] == "G") toplamPuan += 3;
                    else if (puan[j] == "B") toplamPuan += 1;
                }
                lstResult.Items.Add($"{teamsProp[i,0]} takımı {toplamPuan} sahipdir.");
                toplamPuan = 0;
            }
        }
    }
}
