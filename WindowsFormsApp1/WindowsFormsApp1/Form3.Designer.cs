namespace WindowsFormsApp1
{
    partial class CaballoForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Volver = new System.Windows.Forms.Button();
            this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
            this.userControl11 = new WpfControlLibrary1.UserControl1();
            this.SuspendLayout();
            // 
            // Volver
            // 
            this.Volver.Location = new System.Drawing.Point(12, 12);
            this.Volver.Name = "Volver";
            this.Volver.Size = new System.Drawing.Size(119, 36);
            this.Volver.TabIndex = 0;
            this.Volver.Text = "Volver";
            this.Volver.UseVisualStyleBackColor = true;
            this.Volver.UseWaitCursor = true;
            this.Volver.Click += new System.EventHandler(this.Volver_Click);
            // 
            // elementHost1
            // 
            this.elementHost1.Location = new System.Drawing.Point(27, 69);
            this.elementHost1.Name = "elementHost1";
            this.elementHost1.Size = new System.Drawing.Size(543, 322);
            this.elementHost1.TabIndex = 1;
            this.elementHost1.Text = "elementHost1";
            this.elementHost1.Child = this.userControl11;
            // 
            // CaballoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.elementHost1);
            this.Controls.Add(this.Volver);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CaballoForm";
            this.Text = "Form3";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Volver;
        private System.Windows.Forms.Integration.ElementHost elementHost1;
        private WpfControlLibrary1.UserControl1 userControl11;
    }
}