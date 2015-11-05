namespace Sistema_ventas.formularios
{
    partial class frmComprasProveedores
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmComprasProveedores));
            this.Menu4 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblnombre = new System.Windows.Forms.ToolStripLabel();
            this.lblrol = new System.Windows.Forms.ToolStripLabel();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.btnconfiguracion = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnpedido = new System.Windows.Forms.Button();
            this.btnproducto = new System.Windows.Forms.Button();
            this.btnprove = new System.Windows.Forms.Button();
            this.ncantidad = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.lblproducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblnomprove = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Menu4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu4
            // 
            this.Menu4.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblnombre,
            this.lblrol,
            this.btnsalir,
            this.btnconfiguracion});
            this.Menu4.Location = new System.Drawing.Point(0, 0);
            this.Menu4.Name = "Menu4";
            this.Menu4.Size = new System.Drawing.Size(400, 25);
            this.Menu4.TabIndex = 2;
            this.Menu4.Text = "Menu";
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
            // btnsalir
            // 
            this.btnsalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnsalir.Image = ((System.Drawing.Image)(resources.GetObject("btnsalir.Image")));
            this.btnsalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(23, 22);
            this.btnsalir.Text = "Salir";
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btnconfiguracion
            // 
            this.btnconfiguracion.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnconfiguracion.Image = ((System.Drawing.Image)(resources.GetObject("btnconfiguracion.Image")));
            this.btnconfiguracion.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnconfiguracion.Name = "btnconfiguracion";
            this.btnconfiguracion.Size = new System.Drawing.Size(23, 22);
            this.btnconfiguracion.Text = "Configuracion";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnpedido);
            this.groupBox1.Controls.Add(this.btnproducto);
            this.groupBox1.Controls.Add(this.btnprove);
            this.groupBox1.Controls.Add(this.ncantidad);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblproducto);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblnomprove);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 187);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de compra";
            // 
            // btnpedido
            // 
            this.btnpedido.Location = new System.Drawing.Point(240, 154);
            this.btnpedido.Name = "btnpedido";
            this.btnpedido.Size = new System.Drawing.Size(148, 23);
            this.btnpedido.TabIndex = 8;
            this.btnpedido.Text = "Realizar pedido";
            this.btnpedido.UseVisualStyleBackColor = true;
            this.btnpedido.Click += new System.EventHandler(this.btnpedido_Click);
            // 
            // btnproducto
            // 
            this.btnproducto.Location = new System.Drawing.Point(240, 66);
            this.btnproducto.Name = "btnproducto";
            this.btnproducto.Size = new System.Drawing.Size(147, 23);
            this.btnproducto.TabIndex = 7;
            this.btnproducto.Text = "Buscar Producto";
            this.btnproducto.UseVisualStyleBackColor = true;
            this.btnproducto.Click += new System.EventHandler(this.btnproducto_Click);
            // 
            // btnprove
            // 
            this.btnprove.Location = new System.Drawing.Point(240, 35);
            this.btnprove.Name = "btnprove";
            this.btnprove.Size = new System.Drawing.Size(147, 23);
            this.btnprove.TabIndex = 6;
            this.btnprove.Text = "Agregar Proveedor";
            this.btnprove.UseVisualStyleBackColor = true;
            this.btnprove.Click += new System.EventHandler(this.btnprove_Click);
            // 
            // ncantidad
            // 
            this.ncantidad.Location = new System.Drawing.Point(133, 97);
            this.ncantidad.Name = "ncantidad";
            this.ncantidad.Size = new System.Drawing.Size(49, 20);
            this.ncantidad.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Cantidad solicitada";
            // 
            // lblproducto
            // 
            this.lblproducto.AutoSize = true;
            this.lblproducto.Location = new System.Drawing.Point(149, 71);
            this.lblproducto.Name = "lblproducto";
            this.lblproducto.Size = new System.Drawing.Size(13, 13);
            this.lblproducto.TabIndex = 3;
            this.lblproducto.Text = "--";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre del producto";
            // 
            // lblnomprove
            // 
            this.lblnomprove.AutoSize = true;
            this.lblnomprove.Location = new System.Drawing.Point(149, 40);
            this.lblnomprove.Name = "lblnomprove";
            this.lblnomprove.Size = new System.Drawing.Size(13, 13);
            this.lblnomprove.TabIndex = 1;
            this.lblnomprove.Text = "--";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre del proveedor";
            // 
            // frmComprasProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 217);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Menu4);
            this.Name = "frmComprasProveedores";
            this.Text = "frmComprasProveedores";
            this.Load += new System.EventHandler(this.frmComprasProveedores_Load);
            this.Menu4.ResumeLayout(false);
            this.Menu4.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ncantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu4;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblnombre;
        private System.Windows.Forms.ToolStripLabel lblrol;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStripButton btnconfiguracion;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnproducto;
        private System.Windows.Forms.Button btnprove;
        private System.Windows.Forms.NumericUpDown ncantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblproducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblnomprove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnpedido;
    }
}