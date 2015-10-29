namespace Sistema_ventas.Controles
{
    partial class Producto1
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
            this.chkproduc = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblprec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkproduc
            // 
            this.chkproduc.AutoSize = true;
            this.chkproduc.Location = new System.Drawing.Point(17, 16);
            this.chkproduc.Name = "chkproduc";
            this.chkproduc.Size = new System.Drawing.Size(80, 17);
            this.chkproduc.TabIndex = 0;
            this.chkproduc.Text = "checkBox1";
            this.chkproduc.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Precio";
            // 
            // lblprec
            // 
            this.lblprec.AutoSize = true;
            this.lblprec.Location = new System.Drawing.Point(345, 17);
            this.lblprec.Name = "lblprec";
            this.lblprec.Size = new System.Drawing.Size(35, 13);
            this.lblprec.TabIndex = 2;
            this.lblprec.Text = "label2";
            // 
            // Producto1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblprec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkproduc);
            this.Name = "Producto1";
            this.Size = new System.Drawing.Size(422, 48);
            this.Load += new System.EventHandler(this.Producto1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.CheckBox chkproduc;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lblprec;
    }
}
