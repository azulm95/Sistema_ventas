namespace Sistema_ventas
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.btningresar.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btningresar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btningresar.BackgroundImage")));
            this.btningresar.ForeColor = System.Drawing.Color.Black;
            this.btningresar.Image = ((System.Drawing.Image)(resources.GetObject("btningresar.Image")));
            this.btningresar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btningresar.Location = new System.Drawing.Point(50, 203);
            this.btningresar.Name = "btningresar";
            this.btningresar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btningresar.Size = new System.Drawing.Size(239, 38);
            this.btningresar.TabIndex = 2;
            this.btningresar.Text = "Ingresar";
            this.btningresar.UseVisualStyleBackColor = false;
            this.btningresar.Click += new System.EventHandler(this.btningresar_Click);
            // 
            // gblogin
            // 
            this.gblogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gblogin.BackgroundImage")));
            this.gblogin.Controls.Add(this.label2);
            this.gblogin.Controls.Add(this.btningresar);
            this.gblogin.Controls.Add(this.label1);
            this.gblogin.Controls.Add(this.txtclave);
            this.gblogin.Controls.Add(this.txtnombre);
            this.gblogin.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gblogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gblogin.Location = new System.Drawing.Point(-1, 1);
            this.gblogin.Name = "gblogin";
            this.gblogin.Size = new System.Drawing.Size(345, 264);
            this.gblogin.TabIndex = 3;
            this.gblogin.TabStop = false;
            this.gblogin.Text = "Datos del usuario";
            this.gblogin.Enter += new System.EventHandler(this.gblogin_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
            this.label2.Location = new System.Drawing.Point(13, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Password:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.Location = new System.Drawing.Point(13, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 22);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de usuario:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtclave
            // 
            this.txtclave.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtclave.Location = new System.Drawing.Point(14, 142);
            this.txtclave.Name = "txtclave";
            this.txtclave.Size = new System.Drawing.Size(199, 22);
            this.txtclave.TabIndex = 6;
            this.txtclave.UseSystemPasswordChar = true;
            // 
            // txtnombre
            // 
            this.txtnombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtnombre.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtnombre.Location = new System.Drawing.Point(13, 64);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(199, 22);
            this.txtnombre.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(344, 263);
            this.Controls.Add(this.gblogin);
            this.Name = "Form1";
            this.Text = "Login";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Form1_KeyPress);
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

