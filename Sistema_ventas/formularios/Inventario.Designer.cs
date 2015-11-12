namespace Sistema_ventas.formularios
{
    partial class Inventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inventario));
            this.tpinventario2 = new System.Windows.Forms.TabControl();
            this.tpinvntario1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtproducto = new System.Windows.Forms.TextBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.gproductos = new System.Windows.Forms.GroupBox();
            this.btnAgragar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxclasificacion = new System.Windows.Forms.ComboBox();
            this.cbxmarca = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdescripcion = new System.Windows.Forms.TextBox();
            this.dtfecha_ven = new System.Windows.Forms.DateTimePicker();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcodigo = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.Menu2 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.lblnombre = new System.Windows.Forms.ToolStripLabel();
            this.lblrol = new System.Windows.Forms.ToolStripLabel();
            this.btnsalir = new System.Windows.Forms.ToolStripButton();
            this.btnconfiguracion = new System.Windows.Forms.ToolStripButton();
            this.tpinventario2.SuspendLayout();
            this.tpinvntario1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.gproductos.SuspendLayout();
            this.Menu2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpinventario2
            // 
            this.tpinventario2.Controls.Add(this.tpinvntario1);
            this.tpinventario2.Controls.Add(this.tabPage2);
            this.tpinventario2.Location = new System.Drawing.Point(0, 28);
            this.tpinventario2.Name = "tpinventario2";
            this.tpinventario2.SelectedIndex = 0;
            this.tpinventario2.Size = new System.Drawing.Size(806, 415);
            this.tpinventario2.TabIndex = 0;
            // 
            // tpinvntario1
            // 
            this.tpinvntario1.Controls.Add(this.label1);
            this.tpinvntario1.Controls.Add(this.txtproducto);
            this.tpinvntario1.Controls.Add(this.btnbuscar);
            this.tpinvntario1.Controls.Add(this.dataGridView1);
            this.tpinvntario1.Location = new System.Drawing.Point(4, 22);
            this.tpinvntario1.Name = "tpinvntario1";
            this.tpinvntario1.Padding = new System.Windows.Forms.Padding(3);
            this.tpinvntario1.Size = new System.Drawing.Size(798, 389);
            this.tpinvntario1.TabIndex = 0;
            this.tpinvntario1.Text = "Inventario";
            this.tpinvntario1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 11;
            this.label1.Text = "Digite el nombre del prooducto:";
            // 
            // txtproducto
            // 
            this.txtproducto.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtproducto.Location = new System.Drawing.Point(198, 26);
            this.txtproducto.Name = "txtproducto";
            this.txtproducto.Size = new System.Drawing.Size(194, 20);
            this.txtproducto.TabIndex = 10;
            // 
            // btnbuscar
            // 
            this.btnbuscar.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnbuscar.Location = new System.Drawing.Point(662, 14);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(109, 32);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.Text = "buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 47);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 338);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.gproductos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(798, 389);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Agregar productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // gproductos
            // 
            this.gproductos.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gproductos.BackgroundImage")));
            this.gproductos.Controls.Add(this.btnAgragar);
            this.gproductos.Controls.Add(this.label8);
            this.gproductos.Controls.Add(this.cbxclasificacion);
            this.gproductos.Controls.Add(this.cbxmarca);
            this.gproductos.Controls.Add(this.label7);
            this.gproductos.Controls.Add(this.label6);
            this.gproductos.Controls.Add(this.label5);
            this.gproductos.Controls.Add(this.label4);
            this.gproductos.Controls.Add(this.label3);
            this.gproductos.Controls.Add(this.label2);
            this.gproductos.Controls.Add(this.txtdescripcion);
            this.gproductos.Controls.Add(this.dtfecha_ven);
            this.gproductos.Controls.Add(this.txtprecio);
            this.gproductos.Controls.Add(this.txtcodigo);
            this.gproductos.Controls.Add(this.txtnombre);
            this.gproductos.Location = new System.Drawing.Point(-4, -22);
            this.gproductos.Name = "gproductos";
            this.gproductos.Size = new System.Drawing.Size(806, 415);
            this.gproductos.TabIndex = 0;
            this.gproductos.TabStop = false;
            this.gproductos.Text = "Nombre:";
            // 
            // btnAgragar
            // 
            this.btnAgragar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnAgragar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAgragar.BackgroundImage")));
            this.btnAgragar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnAgragar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgragar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAgragar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgragar.Image")));
            this.btnAgragar.Location = new System.Drawing.Point(685, 366);
            this.btnAgragar.Name = "btnAgragar";
            this.btnAgragar.Size = new System.Drawing.Size(109, 39);
            this.btnAgragar.TabIndex = 15;
            this.btnAgragar.Text = "Ingresar";
            this.btnAgragar.UseVisualStyleBackColor = false;
            this.btnAgragar.Click += new System.EventHandler(this.btnAgragar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(383, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 22);
            this.label8.TabIndex = 14;
            this.label8.Text = "Clasificacion:";
            // 
            // cbxclasificacion
            // 
            this.cbxclasificacion.FormattingEnabled = true;
            this.cbxclasificacion.Location = new System.Drawing.Point(496, 161);
            this.cbxclasificacion.Name = "cbxclasificacion";
            this.cbxclasificacion.Size = new System.Drawing.Size(200, 21);
            this.cbxclasificacion.TabIndex = 13;
            // 
            // cbxmarca
            // 
            this.cbxmarca.FormattingEnabled = true;
            this.cbxmarca.Location = new System.Drawing.Point(102, 161);
            this.cbxmarca.Name = "cbxmarca";
            this.cbxmarca.Size = new System.Drawing.Size(200, 21);
            this.cbxmarca.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(331, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 22);
            this.label7.TabIndex = 11;
            this.label7.Text = "Fecha de  vencinmiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(30, 254);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 22);
            this.label6.TabIndex = 10;
            this.label6.Text = "Descripcion:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(420, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 22);
            this.label5.TabIndex = 9;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(30, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 8;
            this.label4.Text = "Marca:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(25, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Codigo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(24, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombre:";
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(135, 257);
            this.txtdescripcion.Multiline = true;
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(648, 103);
            this.txtdescripcion.TabIndex = 5;
            // 
            // dtfecha_ven
            // 
            this.dtfecha_ven.Location = new System.Drawing.Point(522, 104);
            this.dtfecha_ven.Name = "dtfecha_ven";
            this.dtfecha_ven.Size = new System.Drawing.Size(200, 20);
            this.dtfecha_ven.TabIndex = 4;
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(496, 58);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(200, 20);
            this.txtprecio.TabIndex = 3;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(102, 107);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(200, 20);
            this.txtcodigo.TabIndex = 1;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(102, 58);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(200, 20);
            this.txtnombre.TabIndex = 0;
            // 
            // Menu2
            // 
            this.Menu2.BackColor = System.Drawing.Color.SteelBlue;
            this.Menu2.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.lblnombre,
            this.lblrol,
            this.btnsalir,
            this.btnconfiguracion});
            this.Menu2.Location = new System.Drawing.Point(0, 0);
            this.Menu2.Name = "Menu2";
            this.Menu2.Size = new System.Drawing.Size(806, 25);
            this.Menu2.TabIndex = 1;
            this.Menu2.Text = "Menu";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(0, 22);
            // 
            // lblnombre
            // 
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(15, 22);
            this.lblnombre.Text = "-";
            // 
            // lblrol
            // 
            this.lblrol.Name = "lblrol";
            this.lblrol.Size = new System.Drawing.Size(15, 22);
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
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 441);
            this.Controls.Add(this.Menu2);
            this.Controls.Add(this.tpinventario2);
            this.Name = "Inventario";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.Inventario_Load);
            this.tpinventario2.ResumeLayout(false);
            this.tpinvntario1.ResumeLayout(false);
            this.tpinvntario1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.gproductos.ResumeLayout(false);
            this.gproductos.PerformLayout();
            this.Menu2.ResumeLayout(false);
            this.Menu2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tpinventario2;
        private System.Windows.Forms.TabPage tpinvntario1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStrip Menu2;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripLabel lblnombre;
        private System.Windows.Forms.ToolStripLabel lblrol;
        private System.Windows.Forms.ToolStripButton btnsalir;
        private System.Windows.Forms.ToolStripButton btnconfiguracion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtproducto;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gproductos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdescripcion;
        private System.Windows.Forms.DateTimePicker dtfecha_ven;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcodigo;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbxclasificacion;
        private System.Windows.Forms.ComboBox cbxmarca;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAgragar;
    }
}