
namespace Feria_tecno_5toB_DJLSM
{
    partial class Bingo
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bingo));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picFutbol = new System.Windows.Forms.PictureBox();
            this.btnjugar = new System.Windows.Forms.Button();
            this.txtjugador = new System.Windows.Forms.TextBox();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.lstEquipos = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picFutbol)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.ForestGreen;
            this.label1.Font = new System.Drawing.Font("Impact", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(28, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 80);
            this.label1.TabIndex = 0;
            this.label1.Text = "BINGO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Green;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(36, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 36);
            this.label2.TabIndex = 1;
            this.label2.Text = "Jugador...";
            // 
            // picFutbol
            // 
            this.picFutbol.Location = new System.Drawing.Point(28, 92);
            this.picFutbol.Name = "picFutbol";
            this.picFutbol.Size = new System.Drawing.Size(197, 123);
            this.picFutbol.TabIndex = 2;
            this.picFutbol.TabStop = false;
            // 
            // btnjugar
            // 
            this.btnjugar.BackColor = System.Drawing.Color.Green;
            this.btnjugar.Font = new System.Drawing.Font("Segoe Script", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnjugar.Location = new System.Drawing.Point(42, 289);
            this.btnjugar.Name = "btnjugar";
            this.btnjugar.Size = new System.Drawing.Size(148, 95);
            this.btnjugar.TabIndex = 3;
            this.btnjugar.Text = "JUGAR";
            this.btnjugar.UseVisualStyleBackColor = false;
            // 
            // txtjugador
            // 
            this.txtjugador.Location = new System.Drawing.Point(193, 231);
            this.txtjugador.Name = "txtjugador";
            this.txtjugador.Size = new System.Drawing.Size(185, 38);
            this.txtjugador.TabIndex = 5;
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje.Location = new System.Drawing.Point(12, 500);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(417, 33);
            this.lblMensaje.TabIndex = 6;
            this.lblMensaje.Text = "¡Bienvenido al Bingo de Fútbol!";
            // 
            // lstEquipos
            // 
            this.lstEquipos.FormattingEnabled = true;
            this.lstEquipos.ItemHeight = 31;
            this.lstEquipos.Location = new System.Drawing.Point(443, 54);
            this.lstEquipos.Name = "lstEquipos";
            this.lstEquipos.Size = new System.Drawing.Size(241, 221);
            this.lstEquipos.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Green;
            this.label3.Location = new System.Drawing.Point(437, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(247, 31);
            this.label3.TabIndex = 8;
            this.label3.Text = "Historial de sorteos";
            // 
            // Bingo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(815, 542);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstEquipos);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.txtjugador);
            this.Controls.Add(this.btnjugar);
            this.Controls.Add(this.picFutbol);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Bingo";
            this.Text = "Bingo";
           
            ((System.ComponentModel.ISupportInitialize)(this.picFutbol)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picFutbol;
        private System.Windows.Forms.Button btnjugar;
        private System.Windows.Forms.TextBox txtjugador;
        private System.Windows.Forms.Label lblMensaje;
        private System.Windows.Forms.ListBox lstEquipos;
        private System.Windows.Forms.Label label3;
    }
}

