namespace Sistema_ventas.formularios
{
    partial class frmProveedor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProveedor));
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbpaciente = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.txtcorreo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtempresa = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtapellido = new System.Windows.Forms.TextBox();
            this.txtcedula = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.gbpaciente.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(116, 52);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtnombre.Size = new System.Drawing.Size(292, 20);
            this.txtnombre.TabIndex = 0;
            this.txtnombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtnombre_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(28, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(28, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Apellido";
            // 
            // gbpaciente
            // 
            this.gbpaciente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbpaciente.BackgroundImage")));
            this.gbpaciente.Controls.Add(this.txtcedula);
            this.gbpaciente.Controls.Add(this.label4);
            this.gbpaciente.Controls.Add(this.button2);
            this.gbpaciente.Controls.Add(this.button1);
            this.gbpaciente.Controls.Add(this.txtcorreo);
            this.gbpaciente.Controls.Add(this.label8);
            this.gbpaciente.Controls.Add(this.txttelefono);
            this.gbpaciente.Controls.Add(this.label7);
            this.gbpaciente.Controls.Add(this.txtciudad);
            this.gbpaciente.Controls.Add(this.label5);
            this.gbpaciente.Controls.Add(this.txtempresa);
            this.gbpaciente.Controls.Add(this.label3);
            this.gbpaciente.Controls.Add(this.txtapellido);
            this.gbpaciente.Controls.Add(this.txtnombre);
            this.gbpaciente.Controls.Add(this.label2);
            this.gbpaciente.Controls.Add(this.label1);
            this.gbpaciente.Location = new System.Drawing.Point(1, 12);
            this.gbpaciente.Name = "gbpaciente";
            this.gbpaciente.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.gbpaciente.Size = new System.Drawing.Size(447, 383);
            this.gbpaciente.TabIndex = 3;
            this.gbpaciente.TabStop = false;
            this.gbpaciente.Text = "Datos de Cliente";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(169, 298);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 39);
            this.button2.TabIndex = 17;
            this.button2.Text = "Salir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(50, 298);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(104, 39);
            this.button1.TabIndex = 16;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtcorreo
            // 
            this.txtcorreo.Location = new System.Drawing.Point(116, 212);
            this.txtcorreo.Name = "txtcorreo";
            this.txtcorreo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcorreo.Size = new System.Drawing.Size(292, 20);
            this.txtcorreo.TabIndex = 15;
            this.txtcorreo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcorreo_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(29, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Correo";
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(116, 176);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txttelefono.Size = new System.Drawing.Size(292, 20);
            this.txttelefono.TabIndex = 13;
            this.txttelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txttelefono_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(28, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Telefono";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(116, 148);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtciudad.Size = new System.Drawing.Size(292, 20);
            this.txtciudad.TabIndex = 9;
            this.txtciudad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtciudad_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(28, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ciudad";
            // 
            // txtempresa
            // 
            this.txtempresa.Location = new System.Drawing.Point(116, 118);
            this.txtempresa.Name = "txtempresa";
            this.txtempresa.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtempresa.Size = new System.Drawing.Size(292, 20);
            this.txtempresa.TabIndex = 5;
            this.txtempresa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtempresa_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(28, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa";
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(116, 85);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtapellido.Size = new System.Drawing.Size(292, 20);
            this.txtapellido.TabIndex = 3;
            this.txtapellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtapellido_KeyPress);
            // 
            // txtcedula
            // 
            this.txtcedula.Location = new System.Drawing.Point(116, 16);
            this.txtcedula.Name = "txtcedula";
            this.txtcedula.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtcedula.Size = new System.Drawing.Size(292, 20);
            this.txtcedula.TabIndex = 18;
            this.txtcedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcedula_KeyPress_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(28, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Identificacion";
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 395);
            this.Controls.Add(this.gbpaciente);
            this.Name = "frmProveedor";
            this.Text = "frmClientes";
            this.gbpaciente.ResumeLayout(false);
            this.gbpaciente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox gbpaciente;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtcorreo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtempresa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtapellido;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtcedula;
        private System.Windows.Forms.Label label4;
    }
}