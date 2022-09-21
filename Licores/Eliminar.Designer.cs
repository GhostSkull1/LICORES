namespace Licores
{
    partial class Eliminar
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
            this.bborrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.texeliminar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bborrar
            // 
            this.bborrar.Location = new System.Drawing.Point(136, 114);
            this.bborrar.Name = "bborrar";
            this.bborrar.Size = new System.Drawing.Size(75, 23);
            this.bborrar.TabIndex = 0;
            this.bborrar.Text = "BORRAR";
            this.bborrar.UseVisualStyleBackColor = true;
            this.bborrar.Click += new System.EventHandler(this.bborrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "INGRESE EL CODIGO DEL PRODUCTO A ELIMINAR";
            // 
            // texeliminar
            // 
            this.texeliminar.Location = new System.Drawing.Point(124, 64);
            this.texeliminar.Name = "texeliminar";
            this.texeliminar.Size = new System.Drawing.Size(100, 20);
            this.texeliminar.TabIndex = 2;
            // 
            // Eliminar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 175);
            this.Controls.Add(this.texeliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bborrar);
            this.Name = "Eliminar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eliminar";
            this.Load += new System.EventHandler(this.Eliminar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bborrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texeliminar;
    }
}