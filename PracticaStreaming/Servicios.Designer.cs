namespace PracticaStreaming
{
    partial class Servicios
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
            this.cboServicio = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rb1Mes = new System.Windows.Forms.RadioButton();
            this.rb2Mes = new System.Windows.Forms.RadioButton();
            this.rb3Mes = new System.Windows.Forms.RadioButton();
            this.rb6Mes = new System.Windows.Forms.RadioButton();
            this.rb12Mes = new System.Windows.Forms.RadioButton();
            this.cbxImpuestos = new System.Windows.Forms.CheckBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboServicio
            // 
            this.cboServicio.FormattingEnabled = true;
            this.cboServicio.Items.AddRange(new object[] {
            "-----",
            "Xbox game pass",
            "Xbox live gold",
            "Disney+",
            "HBOMax",
            "Malwerbytes"});
            this.cboServicio.Location = new System.Drawing.Point(63, 58);
            this.cboServicio.Name = "cboServicio";
            this.cboServicio.Size = new System.Drawing.Size(121, 21);
            this.cboServicio.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona el servicio";
            // 
            // rb1Mes
            // 
            this.rb1Mes.AutoSize = true;
            this.rb1Mes.Location = new System.Drawing.Point(53, 113);
            this.rb1Mes.Name = "rb1Mes";
            this.rb1Mes.Size = new System.Drawing.Size(54, 17);
            this.rb1Mes.TabIndex = 2;
            this.rb1Mes.TabStop = true;
            this.rb1Mes.Text = "1 Mes";
            this.rb1Mes.UseVisualStyleBackColor = true;
            // 
            // rb2Mes
            // 
            this.rb2Mes.AutoSize = true;
            this.rb2Mes.Location = new System.Drawing.Point(126, 113);
            this.rb2Mes.Name = "rb2Mes";
            this.rb2Mes.Size = new System.Drawing.Size(65, 17);
            this.rb2Mes.TabIndex = 3;
            this.rb2Mes.TabStop = true;
            this.rb2Mes.Text = "2 Meses";
            this.rb2Mes.UseVisualStyleBackColor = true;
            // 
            // rb3Mes
            // 
            this.rb3Mes.AutoSize = true;
            this.rb3Mes.Location = new System.Drawing.Point(53, 147);
            this.rb3Mes.Name = "rb3Mes";
            this.rb3Mes.Size = new System.Drawing.Size(65, 17);
            this.rb3Mes.TabIndex = 4;
            this.rb3Mes.TabStop = true;
            this.rb3Mes.Text = "3 Meses";
            this.rb3Mes.UseVisualStyleBackColor = true;
            // 
            // rb6Mes
            // 
            this.rb6Mes.AutoSize = true;
            this.rb6Mes.Location = new System.Drawing.Point(126, 147);
            this.rb6Mes.Name = "rb6Mes";
            this.rb6Mes.Size = new System.Drawing.Size(65, 17);
            this.rb6Mes.TabIndex = 5;
            this.rb6Mes.TabStop = true;
            this.rb6Mes.Text = "6 Meses";
            this.rb6Mes.UseVisualStyleBackColor = true;
            // 
            // rb12Mes
            // 
            this.rb12Mes.AutoSize = true;
            this.rb12Mes.Location = new System.Drawing.Point(53, 181);
            this.rb12Mes.Name = "rb12Mes";
            this.rb12Mes.Size = new System.Drawing.Size(71, 17);
            this.rb12Mes.TabIndex = 6;
            this.rb12Mes.TabStop = true;
            this.rb12Mes.Text = "12 Meses";
            this.rb12Mes.UseVisualStyleBackColor = true;
            // 
            // cbxImpuestos
            // 
            this.cbxImpuestos.AutoSize = true;
            this.cbxImpuestos.Location = new System.Drawing.Point(63, 232);
            this.cbxImpuestos.Name = "cbxImpuestos";
            this.cbxImpuestos.Size = new System.Drawing.Size(125, 17);
            this.cbxImpuestos.TabIndex = 7;
            this.cbxImpuestos.Text = "Se cobran impuestos";
            this.cbxImpuestos.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(84, 288);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // Servicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 338);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxImpuestos);
            this.Controls.Add(this.rb12Mes);
            this.Controls.Add(this.rb6Mes);
            this.Controls.Add(this.rb3Mes);
            this.Controls.Add(this.rb2Mes);
            this.Controls.Add(this.rb1Mes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboServicio);
            this.Name = "Servicios";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Servicios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboServicio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rb1Mes;
        private System.Windows.Forms.RadioButton rb2Mes;
        private System.Windows.Forms.RadioButton rb3Mes;
        private System.Windows.Forms.RadioButton rb6Mes;
        private System.Windows.Forms.RadioButton rb12Mes;
        private System.Windows.Forms.CheckBox cbxImpuestos;
        private System.Windows.Forms.Button btnCalcular;
    }
}

