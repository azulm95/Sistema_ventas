namespace Sistema_ventas.formularios
{
    partial class MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPrincipal));
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblnombre = new System.Windows.Forms.ToolStripLabel();
            this.lblrol = new System.Windows.Forms.ToolStripLabel();
            this.Menu1 = new System.Windows.Forms.ToolStrip();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.btnconfiguracion = new System.Windows.Forms.ToolStripButton();
            this.btnInventario = new System.Windows.Forms.Button();
            this.btnVentas = new System.Windows.Forms.Button();
            this.btnCompras = new System.Windows.Forms.Button();
            this.Menu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // lblnombre
            // 
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(12, 22);
            this.lblnombre.Text = "-";
            // 
            // lblrol
            // 
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(12, 22);
            this.lblrol.Text = "-";
            // 
            // Menu1
            // 
            this.Menu1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu1.BackgroundImage")));
            this.Menu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblnombre,
            this.lblrol,
            this.btnsalir,
            this.btnconfiguracion});
            this.Menu1.Location = new System.Drawing.Point(0, 0);
            this.Menu1.Name = "Menu1";
            this.Menu1.Size = new System.Drawing.Size(631, 25);
            this.Menu1.TabIndex = 0;
            this.Menu1.Text = "Menu";
            // 
            // btnsalir
            // 
            this.btnsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(23, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnconfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnconfiguracion.Image")));
            this.btnconfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Size = new System.Drawing.Size(23, 22);
            this.btnconfiguracion.Text = "Configuracion";
            this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
            // 
            // btnInventario
            // 
            this.btnInventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInventario.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInventario.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnInventario.Image")));
            this.btnInventario.Location = new System.Drawing.Point(67, 64);
            this.btnInventario.Name = "btnInventario";
            this.btnInventario.Size = new System.Drawing.Size(97, 91);
            this.btnInventario.TabIndex = 1;
            this.btnInventario.Text = "Inventario";
            this.btnInventario.UseVisualStyleBackColor = true;
            this.btnInventario.Click += new System.EventHandler(this.btnInventario_Click);
            // 
            // btnVentas
            // 
            this.btnVentas.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVentas.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnVentas.Image = ((System.Drawing.Image)(resources.GetObject("btnVentas.Image")));
            this.btnVentas.Location = new System.Drawing.Point(67, 175);
            this.btnVentas.Name = "btnVentas";
            this.btnVentas.Size = new System.Drawing.Size(97, 91);
            this.btnVentas.TabIndex = 2;
            this.btnVentas.Text = "Ventas";
            this.btnVentas.UseVisualStyleBackColor = true;
            this.btnVentas.Click += new System.EventHandler(this.btnVentas_Click);
            // 
            // btnCompras
            // 
            this.btnCompras.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCompras.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompras.Image = ((System.Drawing.Image)(resources.GetObject("btnCompras.Image")));
            this.btnCompras.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCompras.Location = new System.Drawing.Point(470, 175);
            this.btnCompras.Name = "btnCompras";
            this.btnCompras.Size = new System.Drawing.Size(101, 91);
            this.btnCompras.TabIndex = 6;
            this.btnCompras.Text = "Compras a Proveedores";
            this.btnCompras.UseVisualStyleBackColor = true;
            this.btnCompras.Click += new System.EventHandler(this.btnCompras_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(631, 359);
            this.Controls.Add(this.btnCompras);
            this.Controls.Add(this.btnVentas);
            this.Controls.Add(this.btnInventario);
            this.Controls.Add(this.Menu1);
            this.Name = "MenuPrincipal";
            this.Text = "d";
            this.Load += new System.EventHandler(this.MenuPrincipal_Load);
            this.Menu1.ResumeLayout(false);
            this.Menu1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblnombre;
        private System.Windows.Forms.ToolStripLabel lblrol;
        private System.Windows.Forms.ToolStrip Menu1;
        private System.Windows.Forms.Button btnInventario;
        private System.Windows.Forms.Button btnVentas;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStripButton btnconfiguracion;
        private System.Windows.Forms.Button btnCompras;

    }
}