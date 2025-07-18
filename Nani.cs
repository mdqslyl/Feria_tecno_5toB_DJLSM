using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Feria_tecno_5toB_DJLSM
{
    public partial class Nani : Form
    {
        public Nani()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Primer Espacio - Letra N
            if (TxtBox_N1.Text.ToLower() == "n")
            {
                TxtBox_N1.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_N1.Text.ToLower() == "a" || TxtBox_N1.Text.ToLower() == "n" || TxtBox_N1.Text.ToLower() == "i")
            {
                TxtBox_N1.BackColor = Color.DarkGoldenrod;
            }

            // Segundo Espacio - Letra A
            if (TxtBox_A.Text.ToLower() == "a")
            {
                TxtBox_A.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_A.Text.ToLower() == "n" || TxtBox_A.Text.ToLower() == "i")
            {
                TxtBox_A.BackColor = Color.DarkGoldenrod;
            }

            // Tercer Espacio - Letra N
            if (TxtBox_N2.Text.ToLower() == "n")
            {
                TxtBox_N2.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_N2.Text.ToLower() == "a" || TxtBox_N2.Text.ToLower() == "i")
            {
                TxtBox_N2.BackColor = Color.DarkGoldenrod;
            }

            // Cuarto Espacio - Letra I
            if (TxtBox_I.Text.ToLower() == "i")
            {
                TxtBox_I.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_I.Text.ToLower() == "n" || TxtBox_I.Text.ToLower() == "a")
            {
                TxtBox_I.BackColor = Color.DarkGoldenrod;
            }
            if (TxtBox_N1.Text.ToLower() == "n" && TxtBox_A.Text.ToLower() == "a" && TxtBox_N2.Text.ToLower() == "n" && TxtBox_I.Text.ToLower() == "i")
            {
                picBox_Nani.Image = Properties.Resources.nani;
            }
        }
    }
}
