namespace Sistema_ventas.formularios
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            this.flpprductos = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnseleccion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flpprductos
            // 
            this.flpprductos.AutoScroll = true;
            this.flpprductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("flpprductos.BackgroundImage")));
            this.flpprductos.Location = new System.Drawing.Point(1, 0);
            this.flpprductos.Name = "flpprductos";
            this.flpprductos.Size = new System.Drawing.Size(599, 384);
            this.flpprductos.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(450, 390);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnseleccion
            // 
            this.btnseleccion.Location = new System.Drawing.Point(301, 390);
            this.btnseleccion.Name = "btnseleccion";
            this.btnseleccion.Size = new System.Drawing.Size(132, 40);
            this.btnseleccion.TabIndex = 3;
            this.btnseleccion.Text = "Selccionar";
            this.btnseleccion.UseVisualStyleBackColor = true;
            this.btnseleccion.Click += new System.EventHandler(this.btnseleccion_Click);
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 442);
            this.Controls.Add(this.btnseleccion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flpprductos);
            this.Name = "frmProductos";
            this.Text = "frmProductos";
            this.Load += new System.EventHandler(this.frmProductos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flpprductos;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnseleccion;
    }
}