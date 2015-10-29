namespace Sistema_ventas.Controles
{
    partial class mdProducto
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkNomPro = new System.Windows.Forms.CheckBox();
            this.lblprecio = new System.Windows.Forms.Label();
            this.lblmarca = new System.Windows.Forms.Label();
            this.btnDescripcion = new System.Windows.Forms.Button();
            this.lblcantidad = new System.Windows.Forms.Label();
            this.Ncantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Ncantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // chkNomPro
            // 
            this.chkNomPro.AutoSize = true;
            this.chkNomPro.Location = new System.Drawing.Point(3, 16);
            this.chkNomPro.Name = "chkNomPro";
            this.chkNomPro.Size = new System.Drawing.Size(80, 17);
            this.chkNomPro.TabIndex = 0;
            this.chkNomPro.Text = "checkBox1";
            this.chkNomPro.UseVisualStyleBackColor = true;
            // 
            // lblprecio
            // 
            this.lblprecio.AutoSize = true;
            this.lblprecio.Location = new System.Drawing.Point(267, 17);
            this.lblprecio.Name = "lblprecio";
            this.lblprecio.Size = new System.Drawing.Size(35, 13);
            this.lblprecio.TabIndex = 1;
            this.lblprecio.Text = "label1";
            // 
            // lblmarca
            // 
            this.lblmarca.AutoSize = true;
            this.lblmarca.Location = new System.Drawing.Point(390, 17);
            this.lblmarca.Name = "lblmarca";
            this.lblmarca.Size = new System.Drawing.Size(35, 13);
            this.lblmarca.TabIndex = 2;
            this.lblmarca.Text = "label1";
            // 
            // btnDescripcion
            // 
            this.btnDescripcion.Location = new System.Drawing.Point(621, 8);
            this.btnDescripcion.Name = "btnDescripcion";
            this.btnDescripcion.Size = new System.Drawing.Size(73, 31);
            this.btnDescripcion.TabIndex = 3;
            this.btnDescripcion.Text = "Descripcion";
            this.btnDescripcion.UseVisualStyleBackColor = true;
            // 
            // lblcantidad
            // 
            this.lblcantidad.AutoSize = true;
            this.lblcantidad.Location = new System.Drawing.Point(700, 17);
            this.lblcantidad.Name = "lblcantidad";
            this.lblcantidad.Size = new System.Drawing.Size(35, 13);
            this.lblcantidad.TabIndex = 4;
            this.lblcantidad.Text = "label1";
            // 
            // Ncantidad
            // 
            this.Ncantidad.Location = new System.Drawing.Point(586, 13);
            this.Ncantidad.Name = "Ncantidad";
            this.Ncantidad.Size = new System.Drawing.Size(29, 20);
            this.Ncantidad.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(482, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad Solicitada";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Marca";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(224, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Precio";
            // 
            // mdProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ncantidad);
            this.Controls.Add(this.lblcantidad);
            this.Controls.Add(this.btnDescripcion);
            this.Controls.Add(this.lblmarca);
            this.Controls.Add(this.lblprecio);
            this.Controls.Add(this.chkNomPro);
            this.Name = "mdProducto";
            this.Size = new System.Drawing.Size(738, 48);
            this.Load += new System.EventHandler(this.mdProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Ncantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkNomPro;
        public System.Windows.Forms.Label lblprecio;
        public System.Windows.Forms.Label lblmarca;
        public System.Windows.Forms.Button btnDescripcion;
        public System.Windows.Forms.Label lblcantidad;
        public System.Windows.Forms.NumericUpDown Ncantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
