﻿namespace Sistema_ventas.formularios
{
    partial class frmVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmVentas));
            this.Menu3 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblnombre = new System.Windows.Forms.ToolStripLabel();
            this.lblrol = new System.Windows.Forms.ToolStripLabel();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.btnconfiguracion = new System.Windows.Forms.ToolStripButton();
            this.tabVentas = new System.Windows.Forms.TabControl();
            this.tabFactura = new System.Windows.Forms.TabPage();
            this.lblnombrec = new System.Windows.Forms.Label();
            this.lblusuario = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lbltotal = new System.Windows.Forms.Label();
            this.lblsubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chkiva = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.tabCarro = new System.Windows.Forms.TabPage();
            this.bagregar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.dgCarro = new System.Windows.Forms.DataGridView();
            this.Menu3.SuspendLayout();
            this.tabVentas.SuspendLayout();
            this.tabFactura.SuspendLayout();
            this.tabCarro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgCarro)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu3
            // 
            this.Menu3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblnombre,
            this.lblrol,
            this.btnsalir,
            this.btnconfiguracion});
            this.Menu3.Location = new System.Drawing.Point(0, 0);
            this.Menu3.Name = "Menu3";
            this.Menu3.Size = new System.Drawing.Size(521, 25);
            this.Menu3.TabIndex = 1;
            this.Menu3.Text = "Menu";
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
            this.btnconfiguracion.Click += new System.EventHandler(this.btnconfiguracion_Click);
            // 
            // tabVentas
            // 
            this.tabVentas.Controls.Add(this.tabFactura);
            this.tabVentas.Controls.Add(this.tabCarro);
            this.tabVentas.Location = new System.Drawing.Point(0, 28);
            this.tabVentas.Name = "tabVentas";
            this.tabVentas.SelectedIndex = 0;
            this.tabVentas.Size = new System.Drawing.Size(520, 390);
            this.tabVentas.TabIndex = 2;
            // 
            // tabFactura
            // 
            this.tabFactura.BackColor = System.Drawing.Color.Transparent;
            this.tabFactura.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabFactura.BackgroundImage")));
            this.tabFactura.Controls.Add(this.lblnombrec);
            this.tabFactura.Controls.Add(this.lblusuario);
            this.tabFactura.Controls.Add(this.label8);
            this.tabFactura.Controls.Add(this.btnAgregar);
            this.tabFactura.Controls.Add(this.lbltotal);
            this.tabFactura.Controls.Add(this.lblsubtotal);
            this.tabFactura.Controls.Add(this.label6);
            this.tabFactura.Controls.Add(this.chkiva);
            this.tabFactura.Controls.Add(this.label5);
            this.tabFactura.Controls.Add(this.label3);
            this.tabFactura.Controls.Add(this.lblCodigo);
            this.tabFactura.Controls.Add(this.label4);
            this.tabFactura.Controls.Add(this.label2);
            this.tabFactura.Controls.Add(this.label1);
            this.tabFactura.Controls.Add(this.txtproducto);
            this.tabFactura.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabFactura.Location = new System.Drawing.Point(4, 22);
            this.tabFactura.Name = "tabFactura";
            this.tabFactura.Padding = new System.Windows.Forms.Padding(3);
            this.tabFactura.Size = new System.Drawing.Size(512, 364);
            this.tabFactura.TabIndex = 0;
            this.tabFactura.Text = "Facturas";
            // 
            // lblnombrec
            // 
            this.lblnombrec.AutoSize = true;
            this.lblnombrec.BackColor = System.Drawing.Color.White;
            this.lblnombrec.Location = new System.Drawing.Point(199, 125);
            this.lblnombrec.Name = "lblnombrec";
            this.lblnombrec.Size = new System.Drawing.Size(13, 13);
            this.lblnombrec.TabIndex = 22;
            this.lblnombrec.Text = "--";
            // 
            // lblusuario
            // 
            this.lblusuario.AutoSize = true;
            this.lblusuario.BackColor = System.Drawing.Color.White;
            this.lblusuario.Location = new System.Drawing.Point(93, 273);
            this.lblusuario.Name = "lblusuario";
            this.lblusuario.Size = new System.Drawing.Size(16, 13);
            this.lblusuario.TabIndex = 20;
            this.lblusuario.Text = "---";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(19, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 19);
            this.label8.TabIndex = 19;
            this.label8.Text = "Usuario:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(390, 299);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(115, 45);
            this.btnAgregar.TabIndex = 18;
            this.btnAgregar.Text = "Agregar Cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // lbltotal
            // 
            this.lbltotal.AutoSize = true;
            this.lbltotal.BackColor = System.Drawing.Color.White;
            this.lbltotal.Location = new System.Drawing.Point(93, 237);
            this.lbltotal.Name = "lbltotal";
            this.lbltotal.Size = new System.Drawing.Size(16, 13);
            this.lbltotal.TabIndex = 17;
            this.lbltotal.Text = "---";
            // 
            // lblsubtotal
            // 
            this.lblsubtotal.AutoSize = true;
            this.lblsubtotal.BackColor = System.Drawing.Color.White;
            this.lblsubtotal.Location = new System.Drawing.Point(105, 158);
            this.lblsubtotal.Name = "lblsubtotal";
            this.lblsubtotal.Size = new System.Drawing.Size(16, 13);
            this.lblsubtotal.TabIndex = 16;
            this.lblsubtotal.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(20, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 19);
            this.label6.TabIndex = 15;
            this.label6.Text = "Total:";
            // 
            // chkiva
            // 
            this.chkiva.AutoSize = true;
            this.chkiva.BackColor = System.Drawing.Color.White;
            this.chkiva.Location = new System.Drawing.Point(108, 200);
            this.chkiva.Name = "chkiva";
            this.chkiva.Size = new System.Drawing.Size(40, 17);
            this.chkiva.TabIndex = 14;
            this.chkiva.Text = "IVA";
            this.chkiva.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(19, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Impuesto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(19, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 19);
            this.label3.TabIndex = 12;
            this.label3.Text = "Sub Total:";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.BackColor = System.Drawing.Color.White;
            this.lblCodigo.Location = new System.Drawing.Point(93, 84);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(16, 13);
            this.lblCodigo.TabIndex = 6;
            this.lblCodigo.Text = "---";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(19, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Numero:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(19, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(174, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Identificacion del Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(18, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Buscar Producto:";
            // 
            // txtproducto
            // 
            this.txtproducto.Location = new System.Drawing.Point(142, 37);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(365, 21);
            this.txtproducto.TabIndex = 0;
            this.txtproducto.TextChanged += new System.EventHandler(this.txtproducto_TextChanged);
            this.txtproducto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtproducto_KeyPress);
            // 
            // tabCarro
            // 
            this.tabCarro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tabCarro.BackgroundImage")));
            this.tabCarro.Controls.Add(this.bagregar);
            this.tabCarro.Controls.Add(this.btneliminar);
            this.tabCarro.Controls.Add(this.dgCarro);
            this.tabCarro.Location = new System.Drawing.Point(4, 22);
            this.tabCarro.Name = "tabCarro";
            this.tabCarro.Padding = new System.Windows.Forms.Padding(3);
            this.tabCarro.Size = new System.Drawing.Size(512, 364);
            this.tabCarro.TabIndex = 1;
            this.tabCarro.Text = "Carro de compras";
            this.tabCarro.UseVisualStyleBackColor = true;
            this.tabCarro.Click += new System.EventHandler(this.tabCarro_Click);
            // 
            // bagregar
            // 
            this.bagregar.Location = new System.Drawing.Point(6, 311);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(106, 47);
            this.bagregar.TabIndex = 2;
            this.bagregar.Text = "Realizar Venta";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(118, 311);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(97, 47);
            this.btneliminar.TabIndex = 1;
            this.btneliminar.Text = "Eliminar";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // dgCarro
            // 
            this.dgCarro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCarro.Location = new System.Drawing.Point(142, 0);
            this.dgCarro.Name = "dgCarro";
            this.dgCarro.Size = new System.Drawing.Size(370, 88);
            this.dgCarro.TabIndex = 0;
            // 
            // frmVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 424);
            this.Controls.Add(this.tabVentas);
            this.Controls.Add(this.Menu3);
            this.Name = "frmVentas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.frmVentas_Load);
            this.Menu3.ResumeLayout(false);
            this.Menu3.PerformLayout();
            this.tabVentas.ResumeLayout(false);
            this.tabFactura.ResumeLayout(false);
            this.tabFactura.PerformLayout();
            this.tabCarro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgCarro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip Menu3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblnombre;
        private System.Windows.Forms.ToolStripLabel lblrol;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStripButton btnconfiguracion;
        private System.Windows.Forms.TabControl tabVentas;
        private System.Windows.Forms.TabPage tabFactura;
        private System.Windows.Forms.TabPage tabCarro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lbltotal;
        private System.Windows.Forms.Label lblsubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkiva;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Label lblusuario;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.Label lblnombrec;
        private System.Windows.Forms.DataGridView dgCarro;
    }
}