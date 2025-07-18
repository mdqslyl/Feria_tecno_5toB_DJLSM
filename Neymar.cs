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
    public partial class Neymar : Form
    {
        public Neymar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Primer Espacio - Letra N
            if (TxtBox_N.Text.ToLower() == "n")
            {
                TxtBox_N.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_N.Text.ToLower() == "e" || TxtBox_N.Text.ToLower() == "y" || TxtBox_N.Text.ToLower() == "m" || TxtBox_N.Text.ToLower() == "a" || TxtBox_N.Text.ToLower() == "r")
            {
                TxtBox_N.BackColor = Color.DarkGoldenrod;
            }

            // Segundo Espacio - Letra E
            if (TxtBox_E.Text.ToLower() == "e")
            {
                TxtBox_E.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_E.Text.ToLower() == "n" || TxtBox_E.Text.ToLower() == "y" || TxtBox_E.Text.ToLower() == "m" || TxtBox_E.Text.ToLower() == "a" || TxtBox_E.Text.ToLower() == "r")
            {
                TxtBox_E.BackColor = Color.DarkGoldenrod;
            }

            // Tercer Espacio - Letra Y
            if (TxtBox_Y.Text.ToLower() == "y")
            {
                TxtBox_Y.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_Y.Text.ToLower() == "n" || TxtBox_Y.Text.ToLower() == "e" || TxtBox_Y.Text.ToLower() == "m" || TxtBox_Y.Text.ToLower() == "a" || TxtBox_Y.Text.ToLower() == "r")
            {
                TxtBox_Y.BackColor = Color.DarkGoldenrod;
            }

            // Cuarto Espacio - Letra M
            if (TxtBox_M.Text.ToLower() == "m")
            {
                TxtBox_M.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_M.Text.ToLower() == "n" || TxtBox_M.Text.ToLower() == "e" || TxtBox_M.Text.ToLower() == "y" || TxtBox_M.Text.ToLower() == "a" || TxtBox_M.Text.ToLower() == "r")
            {
                TxtBox_M.BackColor = Color.DarkGoldenrod;
            }

            // Quinto Espacio - Letra A
            if (TxtBox_A.Text.ToLower() == "a")
            {
                TxtBox_A.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_A.Text.ToLower() == "n" || TxtBox_A.Text.ToLower() == "e" || TxtBox_A.Text.ToLower() == "y" || TxtBox_A.Text.ToLower() == "m" || TxtBox_A.Text.ToLower() == "r")
            {
                TxtBox_A.BackColor = Color.DarkGoldenrod;
            }

            // Sexto Espacio - Letra R
            if (TxtBox_R.Text.ToLower() == "r")
            {
                TxtBox_R.BackColor = Color.DarkGreen;
            }
            else if (TxtBox_R.Text.ToLower() == "n" || TxtBox_R.Text.ToLower() == "e" || TxtBox_R.Text.ToLower() == "y" || TxtBox_R.Text.ToLower() == "m" || TxtBox_R.Text.ToLower() == "a")
            {
                TxtBox_R.BackColor = Color.DarkGoldenrod;
            }
            if (TxtBox_N.Text.ToLower() == "n" && TxtBox_E.Text.ToLower() == "e" && TxtBox_Y.Text.ToLower() == "y" && TxtBox_M.Text.ToLower() == "m" && TxtBox_A.Text.ToLower() == "a" && TxtBox_R.Text.ToLower() == "r")
            picBox_Ney.Image = Properties.Resources.neymar;
        }


        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnSiguiente_Click(object sender, EventArgs e)
        {
            Nani formularioNani = new Nani(); // Crear instancia del formulario Neymar
            formularioNani.Show();                // Mostrar formulario
            this.Hide();                            // Ocultar formulario actual (Form1)
        }
    }
}
