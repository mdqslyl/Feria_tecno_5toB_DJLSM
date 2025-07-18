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
    
    public partial class Cristiano : Form
    {
        public Cristiano()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox12_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox18_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_1_Click(object sender, EventArgs e)
        {   //Primer Espacio
            if (TxtBox1_C.Text.ToLower() == "c")
            {
                TxtBox1_C.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_C.Text.ToLower() == "r" || TxtBox1_C.Text.ToLower() == "i" || TxtBox1_C.Text.ToLower() == "s" || TxtBox1_C.Text.ToLower() == "t" || TxtBox1_C.Text.ToLower() == "i" || TxtBox1_C.Text.ToLower() == "a" || TxtBox1_C.Text.ToLower() == "n" || TxtBox1_C.Text.ToLower() == "o")
            {
                TxtBox1_C.BackColor = Color.DarkGoldenrod;
            }

            //Segundo Espacio
            if (TxtBox1_R.Text.ToLower() == "r")
            {
                TxtBox1_R.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_R.Text.ToLower() == "c" || TxtBox1_R.Text.ToLower() == "i" || TxtBox1_R.Text.ToLower() == "s" || TxtBox1_R.Text.ToLower() == "t" || TxtBox1_R.Text.ToLower() == "i" || TxtBox1_R.Text.ToLower() == "a" || TxtBox1_R.Text.ToLower() == "n" || TxtBox1_R.Text.ToLower() == "o")
            {
                TxtBox1_R.BackColor = Color.DarkGoldenrod;
            }

            //Tercer Espacio
            if (TxtBox1_I.Text.ToLower() == "i")
            {
                TxtBox1_I.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_I.Text.ToLower() == "c" || TxtBox1_I.Text.ToLower() == "r" || TxtBox1_I.Text.ToLower() == "s" || TxtBox1_I.Text.ToLower() == "t" || TxtBox1_I.Text.ToLower() == "a" || TxtBox1_I.Text.ToLower() == "n" || TxtBox1_I.Text.ToLower() == "o")
            {
                TxtBox1_I.BackColor = Color.DarkGoldenrod;
            }

            //Cuarto Espacio
            if (TxtBox1_S.Text.ToLower() == "s")
            {
                TxtBox1_S.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_S.Text.ToLower() == "c" || TxtBox1_S.Text.ToLower() == "r" || TxtBox1_S.Text.ToLower() == "i" || TxtBox1_S.Text.ToLower() == "t" || TxtBox1_S.Text.ToLower() == "i" || TxtBox1_S.Text.ToLower() == "a" || TxtBox1_S.Text.ToLower() == "n" || TxtBox1_S.Text.ToLower() == "o")
            {
                TxtBox1_S.BackColor = Color.DarkGoldenrod;
            }

            //Quinto Espacio
            if (TxtBox1_T.Text.ToLower() == "t")
            {
                TxtBox1_T.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_T.Text.ToLower() == "c" || TxtBox1_T.Text.ToLower() == "r" || TxtBox1_T.Text.ToLower() == "i" || TxtBox1_T.Text.ToLower() == "s" || TxtBox1_T.Text.ToLower() == "i" || TxtBox1_T.Text.ToLower() == "a" || TxtBox1_T.Text.ToLower() == "n" || TxtBox1_T.Text.ToLower() == "o")
            {
                TxtBox1_T.BackColor = Color.DarkGoldenrod;
            }

            //Sexto Espacio
            if (TxtBox1_II.Text.ToLower() == "i")
            {
                TxtBox1_II.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_II.Text.ToLower() == "c" || TxtBox1_II.Text.ToLower() == "r" || TxtBox1_II.Text.ToLower() == "i" || TxtBox1_II.Text.ToLower() == "s" || TxtBox1_II.Text.ToLower() == "t" || TxtBox1_II.Text.ToLower() == "a" || TxtBox1_II.Text.ToLower() == "n" || TxtBox1_II.Text.ToLower() == "o")
            {
                TxtBox1_II.BackColor = Color.DarkGoldenrod;
            }

            //Septimo Espacio
            if (TxtBox1_A.Text.ToLower() == "a")
            {
                TxtBox1_A.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_A.Text.ToLower() == "c" || TxtBox1_A.Text.ToLower() == "r" || TxtBox1_A.Text.ToLower() == "i" || TxtBox1_A.Text.ToLower() == "s" || TxtBox1_A.Text.ToLower() == "t" || TxtBox1_A.Text.ToLower() == "i" || TxtBox1_A.Text.ToLower() == "n" || TxtBox1_A.Text.ToLower() == "o")
            {
                TxtBox1_A.BackColor = Color.DarkGoldenrod;
            }

            //Octavo Espacio
            if (TxtBox1_N.Text.ToLower() == "n")
            {
                TxtBox1_N.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_N.Text.ToLower() == "c" || TxtBox1_N.Text.ToLower() == "r" || TxtBox1_N.Text.ToLower() == "i" || TxtBox1_N.Text.ToLower() == "s" || TxtBox1_N.Text.ToLower() == "t" || TxtBox1_N.Text.ToLower() == "i" || TxtBox1_N.Text.ToLower() == "a" || TxtBox1_N.Text.ToLower() == "o")
            {
                TxtBox1_N.BackColor = Color.DarkGoldenrod;
            }

            //Noveno Espacio
            if (TxtBox1_O.Text.ToLower() == "o")
            {
                TxtBox1_O.BackColor = Color.DarkGreen;
            }
            else if (TxtBox1_O.Text.ToLower() == "c" || TxtBox1_O.Text.ToLower() == "r" || TxtBox1_O.Text.ToLower() == "i" || TxtBox1_O.Text.ToLower() == "s" || TxtBox1_O.Text.ToLower() == "t" || TxtBox1_O.Text.ToLower() == "i" || TxtBox1_O.Text.ToLower() == "a" || TxtBox1_O.Text.ToLower() == "n")
            {
                TxtBox1_O.BackColor = Color.DarkGoldenrod;
            }

            //Imagen
            if (TxtBox1_C.Text.ToLower() == "c" & TxtBox1_R.Text.ToLower() == "r" & TxtBox1_I.Text.ToLower() == "i" & TxtBox1_S.Text.ToLower() == "s" & TxtBox1_T.Text.ToLower() == "t" & TxtBox1_II.Text.ToLower() == "i" & TxtBox1_A.Text.ToLower() == "a" & TxtBox1_N.Text.ToLower() == "n" & TxtBox1_O.Text.ToLower() == "o")
            {
                picBoxCR7.Image = Properties.Resources.crischikito;
            }
            else
            {
                picBoxCR7.Hide();
            }
        }

        private void richTextBox24_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox19_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox20_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox21_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox22_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox26_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox25_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Neymar formularioNeymar = new Neymar(); // Crear instancia del formulario Neymar
            formularioNeymar.Show();                // Mostrar formulario
            this.Hide();                            // Ocultar formulario actual (Form1)
        }
    }
}
