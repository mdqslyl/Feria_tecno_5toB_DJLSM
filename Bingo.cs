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
    public partial class Bingo : Form
    {
        private List<string> equipos = new List<string>
        {
            "Real Madrid", "Barcelona", "Manchester City", "Liverpool",
            "Bayern Munich", "PSG", "Juventus", "Chelsea",
            "Inter de Milán", "Atlético de Madrid", "Milan", "Arsenal"
        };

        private Random random = new Random();

        public Bingo()
        {
            InitializeComponent();
        }

        private void btnJugar_Click(object sender, EventArgs e)
        {
            string jugador = txtjugador.Text.Trim();

            if (string.IsNullOrEmpty(jugador))
            {
                lblMensaje.Text = "Por favor, ingresa tu nombre.";
                return;
            }

            if (equipos.Count == 0)
            {
                lblMensaje.Text = "¡Todos los equipos ya han sido sorteados!";
                return;
            }

            
            int index = random.Next(equipos.Count);
            string equipoSorteado = equipos[index];
            equipos.RemoveAt(index); 

            lstEquipos.Items.Add($"{jugador} obtuvo: {equipoSorteado}");
            lblMensaje.Text = $"¡Suerte {jugador}! Te tocó: {equipoSorteado}";
        }
    }
}
