namespace ExamenU1
{
    partial class Venta
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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbxUnidades = new System.Windows.Forms.ListBox();
            this.lbxPrecio = new System.Windows.Forms.ListBox();
            this.lbxProducto = new System.Windows.Forms.ListBox();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtUnidades = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(611, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Unidades";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Precio";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(312, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Producto";
            // 
            // lbxUnidades
            // 
            this.lbxUnidades.FormattingEnabled = true;
            this.lbxUnidades.Location = new System.Drawing.Point(611, 83);
            this.lbxUnidades.Name = "lbxUnidades";
            this.lbxUnidades.Size = new System.Drawing.Size(120, 225);
            this.lbxUnidades.TabIndex = 22;
            this.lbxUnidades.SelectedIndexChanged += new System.EventHandler(this.lbxUnidades_SelectedIndexChanged);
            // 
            // lbxPrecio
            // 
            this.lbxPrecio.FormattingEnabled = true;
            this.lbxPrecio.Location = new System.Drawing.Point(485, 83);
            this.lbxPrecio.Name = "lbxPrecio";
            this.lbxPrecio.Size = new System.Drawing.Size(120, 225);
            this.lbxPrecio.TabIndex = 21;
            this.lbxPrecio.SelectedIndexChanged += new System.EventHandler(this.lbxPrecio_SelectedIndexChanged);
            // 
            // lbxProducto
            // 
            this.lbxProducto.FormattingEnabled = true;
            this.lbxProducto.Location = new System.Drawing.Point(312, 83);
            this.lbxProducto.Name = "lbxProducto";
            this.lbxProducto.Size = new System.Drawing.Size(165, 225);
            this.lbxProducto.TabIndex = 20;
            this.lbxProducto.SelectedIndexChanged += new System.EventHandler(this.lbxProducto_SelectedIndexChanged);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(130, 252);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(30, 31);
            this.lblTotal.TabIndex = 19;
            this.lblTotal.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "TOTAL";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(92, 179);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 36);
            this.btnAgregar.TabIndex = 17;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtUnidades
            // 
            this.txtUnidades.Location = new System.Drawing.Point(57, 137);
            this.txtUnidades.Name = "txtUnidades";
            this.txtUnidades.Size = new System.Drawing.Size(100, 20);
            this.txtUnidades.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Unidades";
            // 
            // cbxProducto
            // 
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(54, 83);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(177, 21);
            this.cbxProducto.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Producto";
            // 
            // Venta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbxUnidades);
            this.Controls.Add(this.lbxPrecio);
            this.Controls.Add(this.lbxProducto);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtUnidades);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbxProducto);
            this.Controls.Add(this.label1);
            this.Name = "Venta";
            this.Text = "Venta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbxUnidades;
        private System.Windows.Forms.ListBox lbxPrecio;
        private System.Windows.Forms.ListBox lbxProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtUnidades;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.Label label1;
    }
}