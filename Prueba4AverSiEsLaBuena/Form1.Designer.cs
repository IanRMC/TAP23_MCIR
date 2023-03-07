namespace Prueba4AverSiEsLaBuena
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
            this.selectorDeMes1 = new Prueba4AverSiEsLaBuena.SelectorDeMes();
            this.SuspendLayout();
            // 
            // selectorDeMes1
            // 
            this.selectorDeMes1.Location = new System.Drawing.Point(101, 71);
            this.selectorDeMes1.Mes = "Enero";
            this.selectorDeMes1.Name = "selectorDeMes1";
            this.selectorDeMes1.Size = new System.Drawing.Size(207, 40);
            this.selectorDeMes1.TabIndex = 0;
            this.selectorDeMes1.Valor = 1;
            this.selectorDeMes1.Change += new System.EventHandler<ControlesEjercicio.ChangeSelectorArgs>(this.selectorDeMes1_Change);
            this.selectorDeMes1.Load += new System.EventHandler(this.selectorDeMes1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(430, 176);
            this.Controls.Add(this.selectorDeMes1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private SelectorDeMes selectorDeMes1;
    }
}

