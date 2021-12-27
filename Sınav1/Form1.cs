using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sınav1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int txtBirLength = txtTextBir.Text.Length;
            int txtIkiLength = txtTextIki.Text.Length;

            lblBirinci.Text = $"Metin uzunluğu: {txtBirLength}";
            lblIkinci.Text = $"Metin uzunluğu: {txtIkiLength}";

            if (txtBirLength != 0 && txtIkiLength != 0)
            {
                if (txtBirLength > txtIkiLength) MessageBox.Show($"Metin 1 : {txtBirLength} uzunluğunda {txtTextBir.Text}");
                else if (txtIkiLength > txtBirLength) MessageBox.Show($"Metin 2 : {txtIkiLength} uzunluğunda {txtTextIki.Text}");
                else MessageBox.Show("Birbirlerine uzunlukları eşit.");
            }
            else MessageBox.Show("Lütfen metinleri tam giriniz.");

        }
    }
}
