namespace Capcha
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
            this.captcha1 = new Captcha.Captcha();
            this.SuspendLayout();
            // 
            // captcha1
            // 
            this.captcha1.Dificultad = 10;
            this.captcha1.Location = new System.Drawing.Point(2, 33);
            this.captcha1.Name = "captcha1";
            this.captcha1.Size = new System.Drawing.Size(834, 257);
            this.captcha1.TabIndex = 0;
            this.captcha1.Validado += new System.EventHandler<Captcha.CaptchaEvents>(this.captcha1_Validado);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 342);
            this.Controls.Add(this.captcha1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Captcha.Captcha captcha1;
    }
}

