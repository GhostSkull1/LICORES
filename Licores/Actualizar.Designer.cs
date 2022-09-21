namespace Licores
{
    partial class Actualizar
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
            this.bactualizapro = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxproducto = new System.Windows.Forms.TextBox();
            this.textBoxcantidad = new System.Windows.Forms.TextBox();
            this.textBoxvalor = new System.Windows.Forms.TextBox();
            this.textBoxcodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bactualizapro
            // 
            this.bactualizapro.Location = new System.Drawing.Point(261, 87);
            this.bactualizapro.Name = "bactualizapro";
            this.bactualizapro.Size = new System.Drawing.Size(75, 23);
            this.bactualizapro.TabIndex = 0;
            this.bactualizapro.Text = "ACTUALIZAR";
            this.bactualizapro.UseVisualStyleBackColor = true;
            this.bactualizapro.Click += new System.EventHandler(this.bactualizapro_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PRODUCTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(217, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(459, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CODIGO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(337, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "VALOR";
            // 
            // textBoxproducto
            // 
            this.textBoxproducto.Location = new System.Drawing.Point(46, 39);
            this.textBoxproducto.Name = "textBoxproducto";
            this.textBoxproducto.Size = new System.Drawing.Size(155, 20);
            this.textBoxproducto.TabIndex = 5;
            // 
            // textBoxcantidad
            // 
            this.textBoxcantidad.Location = new System.Drawing.Point(220, 38);
            this.textBoxcantidad.Name = "textBoxcantidad";
            this.textBoxcantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxcantidad.TabIndex = 6;
            // 
            // textBoxvalor
            // 
            this.textBoxvalor.Location = new System.Drawing.Point(340, 38);
            this.textBoxvalor.Name = "textBoxvalor";
            this.textBoxvalor.Size = new System.Drawing.Size(100, 20);
            this.textBoxvalor.TabIndex = 7;
            // 
            // textBoxcodigo
            // 
            this.textBoxcodigo.Location = new System.Drawing.Point(462, 38);
            this.textBoxcodigo.Name = "textBoxcodigo";
            this.textBoxcodigo.Size = new System.Drawing.Size(100, 20);
            this.textBoxcodigo.TabIndex = 8;
            // 
            // Actualizar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 150);
            this.Controls.Add(this.textBoxcodigo);
            this.Controls.Add(this.textBoxvalor);
            this.Controls.Add(this.textBoxcantidad);
            this.Controls.Add(this.textBoxproducto);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bactualizapro);
            this.Name = "Actualizar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Actualizar";
            this.Load += new System.EventHandler(this.Actualizar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bactualizapro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxproducto;
        private System.Windows.Forms.TextBox textBoxcantidad;
        private System.Windows.Forms.TextBox textBoxvalor;
        private System.Windows.Forms.TextBox textBoxcodigo;
    }
}