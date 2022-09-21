namespace Licores
{
    partial class agregarproductos
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
            this.buttguardar = new System.Windows.Forms.Button();
            this.texproducto = new System.Windows.Forms.TextBox();
            this.texcantidad = new System.Windows.Forms.TextBox();
            this.texvalor = new System.Windows.Forms.TextBox();
            this.texasignarcodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttguardar
            // 
            this.buttguardar.Location = new System.Drawing.Point(329, 75);
            this.buttguardar.Name = "buttguardar";
            this.buttguardar.Size = new System.Drawing.Size(75, 23);
            this.buttguardar.TabIndex = 0;
            this.buttguardar.Text = "GUARDAR";
            this.buttguardar.UseVisualStyleBackColor = true;
            this.buttguardar.Click += new System.EventHandler(this.buttguardar_Click);
            // 
            // texproducto
            // 
            this.texproducto.Location = new System.Drawing.Point(37, 37);
            this.texproducto.Name = "texproducto";
            this.texproducto.Size = new System.Drawing.Size(171, 20);
            this.texproducto.TabIndex = 1;
            // 
            // texcantidad
            // 
            this.texcantidad.Location = new System.Drawing.Point(246, 37);
            this.texcantidad.Name = "texcantidad";
            this.texcantidad.Size = new System.Drawing.Size(100, 20);
            this.texcantidad.TabIndex = 2;
            // 
            // texvalor
            // 
            this.texvalor.Location = new System.Drawing.Point(384, 36);
            this.texvalor.Name = "texvalor";
            this.texvalor.Size = new System.Drawing.Size(100, 20);
            this.texvalor.TabIndex = 3;
            // 
            // texasignarcodigo
            // 
            this.texasignarcodigo.Location = new System.Drawing.Point(529, 37);
            this.texasignarcodigo.Name = "texasignarcodigo";
            this.texasignarcodigo.Size = new System.Drawing.Size(100, 20);
            this.texasignarcodigo.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "NOMBRE DEL PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "CANTIDAD AGREGAR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(384, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "VALOR DEL PRODUCTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "ASIGNE CODIGO DEL PRODUCTO";
            // 
            // agregarproductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 124);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texasignarcodigo);
            this.Controls.Add(this.texvalor);
            this.Controls.Add(this.texcantidad);
            this.Controls.Add(this.texproducto);
            this.Controls.Add(this.buttguardar);
            this.Name = "agregarproductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AGREGAR PRODUCTOS";
            this.Load += new System.EventHandler(this.agregarproductos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttguardar;
        private System.Windows.Forms.TextBox texproducto;
        private System.Windows.Forms.TextBox texcantidad;
        private System.Windows.Forms.TextBox texvalor;
        private System.Windows.Forms.TextBox texasignarcodigo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}