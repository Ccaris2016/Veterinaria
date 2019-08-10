namespace WindowsFormsApp1
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
            this.Exit = new System.Windows.Forms.Button();
            this.Vaca = new System.Windows.Forms.Button();
            this.Caballo = new System.Windows.Forms.Button();
            this.Menor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Exit
            // 
            this.Exit.BackColor = System.Drawing.Color.Moccasin;
            this.Exit.Location = new System.Drawing.Point(694, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(94, 26);
            this.Exit.TabIndex = 0;
            this.Exit.Text = "Salir";
            this.Exit.UseVisualStyleBackColor = false;
            this.Exit.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Vaca
            // 
            this.Vaca.BackColor = System.Drawing.Color.Moccasin;
            this.Vaca.Location = new System.Drawing.Point(305, 137);
            this.Vaca.Name = "Vaca";
            this.Vaca.Size = new System.Drawing.Size(143, 56);
            this.Vaca.TabIndex = 1;
            this.Vaca.Text = "Vaca";
            this.Vaca.UseVisualStyleBackColor = false;
            this.Vaca.Click += new System.EventHandler(this.Vaca_Click);
            // 
            // Caballo
            // 
            this.Caballo.BackColor = System.Drawing.Color.Moccasin;
            this.Caballo.Location = new System.Drawing.Point(569, 264);
            this.Caballo.Name = "Caballo";
            this.Caballo.Size = new System.Drawing.Size(147, 59);
            this.Caballo.TabIndex = 2;
            this.Caballo.Text = "Caballo";
            this.Caballo.UseVisualStyleBackColor = false;
            this.Caballo.Click += new System.EventHandler(this.Caballo_Click);
            // 
            // Menor
            // 
            this.Menor.BackColor = System.Drawing.Color.Moccasin;
            this.Menor.Location = new System.Drawing.Point(48, 271);
            this.Menor.Name = "Menor";
            this.Menor.Size = new System.Drawing.Size(145, 52);
            this.Menor.TabIndex = 3;
            this.Menor.Text = "Menor";
            this.Menor.UseVisualStyleBackColor = false;
            this.Menor.Click += new System.EventHandler(this.Menor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Menor);
            this.Controls.Add(this.Caballo);
            this.Controls.Add(this.Vaca);
            this.Controls.Add(this.Exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Button Vaca;
        private System.Windows.Forms.Button Caballo;
        private System.Windows.Forms.Button Menor;
    }
}

