namespace Juego_adivina__numero
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.Nro_Intentos = new System.Windows.Forms.Label();
            this.Lista_Intentos = new System.Windows.Forms.ListBox();
            this.CajaTexto = new System.Windows.Forms.TextBox();
            this.NuevoJuego = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(351, 145);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Probar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Nro_Intentos
            // 
            this.Nro_Intentos.AutoSize = true;
            this.Nro_Intentos.Location = new System.Drawing.Point(362, 182);
            this.Nro_Intentos.Name = "Nro_Intentos";
            this.Nro_Intentos.Size = new System.Drawing.Size(44, 16);
            this.Nro_Intentos.TabIndex = 1;
            this.Nro_Intentos.Text = "label1";
            // 
            // Lista_Intentos
            // 
            this.Lista_Intentos.FormattingEnabled = true;
            this.Lista_Intentos.ItemHeight = 16;
            this.Lista_Intentos.Location = new System.Drawing.Point(330, 212);
            this.Lista_Intentos.Name = "Lista_Intentos";
            this.Lista_Intentos.Size = new System.Drawing.Size(120, 84);
            this.Lista_Intentos.TabIndex = 2;
            // 
            // CajaTexto
            // 
            this.CajaTexto.Location = new System.Drawing.Point(306, 95);
            this.CajaTexto.Name = "CajaTexto";
            this.CajaTexto.Size = new System.Drawing.Size(160, 22);
            this.CajaTexto.TabIndex = 3;
            // 
            // NuevoJuego
            // 
            this.NuevoJuego.Location = new System.Drawing.Point(306, 312);
            this.NuevoJuego.Name = "NuevoJuego";
            this.NuevoJuego.Size = new System.Drawing.Size(174, 23);
            this.NuevoJuego.TabIndex = 4;
            this.NuevoJuego.Text = "Nuevo juego";
            this.NuevoJuego.UseVisualStyleBackColor = true;
            this.NuevoJuego.Click += new System.EventHandler(this.NuevoJuego_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(304, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Adivina el número secreto";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NuevoJuego);
            this.Controls.Add(this.CajaTexto);
            this.Controls.Add(this.Lista_Intentos);
            this.Controls.Add(this.Nro_Intentos);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Nro_Intentos;
        private System.Windows.Forms.ListBox Lista_Intentos;
        private System.Windows.Forms.TextBox CajaTexto;
        private System.Windows.Forms.Button NuevoJuego;
        private System.Windows.Forms.Label label1;
    }
}

