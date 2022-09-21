namespace Licores
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.texusuario = new System.Windows.Forms.TextBox();
            this.texclave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buentrar = new System.Windows.Forms.Button();
            this.bucancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // texusuario
            // 
            this.texusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texusuario.Location = new System.Drawing.Point(269, 58);
            this.texusuario.Name = "texusuario";
            this.texusuario.Size = new System.Drawing.Size(100, 20);
            this.texusuario.TabIndex = 0;
            this.texusuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // texclave
            // 
            this.texclave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.texclave.Location = new System.Drawing.Point(269, 92);
            this.texclave.Name = "texclave";
            this.texclave.PasswordChar = '*';
            this.texclave.Size = new System.Drawing.Size(100, 20);
            this.texclave.TabIndex = 1;
            this.texclave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(179, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "USUARIO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "CONTRASEÑA:";
            // 
            // buentrar
            // 
            this.buentrar.Location = new System.Drawing.Point(182, 137);
            this.buentrar.Name = "buentrar";
            this.buentrar.Size = new System.Drawing.Size(75, 23);
            this.buentrar.TabIndex = 4;
            this.buentrar.Text = "ENTRAR";
            this.buentrar.UseVisualStyleBackColor = true;
            this.buentrar.Click += new System.EventHandler(this.buentrar_Click);
            // 
            // bucancelar
            // 
            this.bucancelar.Location = new System.Drawing.Point(293, 136);
            this.bucancelar.Name = "bucancelar";
            this.bucancelar.Size = new System.Drawing.Size(75, 23);
            this.bucancelar.TabIndex = 5;
            this.bucancelar.Text = "CANCELAR";
            this.bucancelar.UseVisualStyleBackColor = true;
            this.bucancelar.Click += new System.EventHandler(this.bucancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 143);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(401, 196);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bucancelar);
            this.Controls.Add(this.buentrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texclave);
            this.Controls.Add(this.texusuario);
            this.MaximizeBox = false;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox texusuario;
        private System.Windows.Forms.TextBox texclave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buentrar;
        private System.Windows.Forms.Button bucancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}