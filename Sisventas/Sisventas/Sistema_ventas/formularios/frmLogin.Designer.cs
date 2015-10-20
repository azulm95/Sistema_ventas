namespace Sistema_ventas
{
    partial class frmLogin
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
            this.btningresar = new System.Windows.Forms.Button();
            this.gblogin = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtclave = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.gblogin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btningresar
            // 
            this.btningresar.Location = new System.Drawing.Point(62, 217);
            this.btningresar.Name = "btningresar";
            this.btningresar.Size = new System.Drawing.Size(239, 34);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = true;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // gblogin
            // 
            this.gblogin.Controls.Add(this.label2);
            this.gblogin.Controls.Add(this.label1);
            this.gblogin.Controls.Add(this.txtclave);
            this.gblogin.Controls.Add(this.txtnombre);
            this.gblogin.Location = new System.Drawing.Point(12, 12);
            this.gblogin.Name = "gblogin";
            this.gblogin.Size = new System.Drawing.Size(320, 199);
            this.gblogin.TabIndex = 3;
            this.gblogin.TabStop = false;
            this.gblogin.Text = "Datos del usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de usuario:";
            // 
            // txtclave
            // 
            this.txtclave.Location = new System.Drawing.Point(112, 100);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(199, 20);
            this.txtclave.TabIndex = 6;
            this.txtclave.UseSystemPasswordChar = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(112, 36);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 263);
            this.Controls.Add(this.gblogin);
            this.Controls.Add(this.btningresar);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.gblogin.ResumeLayout(false);
            this.gblogin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btningresar;
        private System.Windows.Forms.GroupBox gblogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtclave;
        private System.Windows.Forms.TextBox txtnombre;
    }
}

