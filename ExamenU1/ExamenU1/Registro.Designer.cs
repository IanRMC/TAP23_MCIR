namespace ExamenU1
{
    partial class Registro
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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbxExistencia = new System.Windows.Forms.ListBox();
            this.lbxProducto = new System.Windows.Forms.ListBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtExistencia = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(547, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Producto";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Producto";
            // 
            // lbxExistencia
            // 
            this.lbxExistencia.FormattingEnabled = true;
            this.lbxExistencia.Location = new System.Drawing.Point(547, 84);
            this.lbxExistencia.Name = "lbxExistencia";
            this.lbxExistencia.Size = new System.Drawing.Size(120, 212);
            this.lbxExistencia.TabIndex = 21;
            this.lbxExistencia.SelectedIndexChanged += new System.EventHandler(this.lbxExistencia_SelectedIndexChanged);
            // 
            // lbxProducto
            // 
            this.lbxProducto.FormattingEnabled = true;
            this.lbxProducto.Location = new System.Drawing.Point(316, 84);
            this.lbxProducto.Name = "lbxProducto";
            this.lbxProducto.Size = new System.Drawing.Size(225, 212);
            this.lbxProducto.TabIndex = 20;
            this.lbxProducto.SelectedIndexChanged += new System.EventHandler(this.lbxProducto_SelectedIndexChanged);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(108, 250);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 31);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(108, 205);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(84, 28);
            this.btnRegistrar.TabIndex = 18;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtExistencia
            // 
            this.txtExistencia.Location = new System.Drawing.Point(108, 136);
            this.txtExistencia.Name = "txtExistencia";
            this.txtExistencia.Size = new System.Drawing.Size(76, 20);
            this.txtExistencia.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Existencia";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(108, 110);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(76, 20);
            this.txtPrecio.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Precio";
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(108, 84);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(133, 20);
            this.txtProducto.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Producto";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 395);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lbxExistencia);
            this.Controls.Add(this.lbxProducto);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtExistencia);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.label1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lbxExistencia;
        private System.Windows.Forms.ListBox lbxProducto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtExistencia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label label1;
    }
}