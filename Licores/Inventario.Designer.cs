namespace Licores
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
            this.bactualizar = new System.Windows.Forms.Button();
            this.datamostrar = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.bregresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.datamostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(109, 54);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(75, 23);
            this.bactualizar.TabIndex = 0;
            this.bactualizar.Text = "ACTUALIZAR";
            this.bactualizar.UseVisualStyleBackColor = true;
            // 
            // datamostrar
            // 
            this.datamostrar.AllowUserToAddRows = false;
            this.datamostrar.AllowUserToDeleteRows = false;
            this.datamostrar.AllowUserToOrderColumns = true;
            this.datamostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datamostrar.Location = new System.Drawing.Point(23, 112);
            this.datamostrar.Name = "datamostrar";
            this.datamostrar.ReadOnly = true;
            this.datamostrar.Size = new System.Drawing.Size(278, 195);
            this.datamostrar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(371, 54);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(144, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "AGREGAR PRODUCTO";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(371, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "ELIMINAR PRODUCTO";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(371, 182);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(144, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "INGRESAR PRODUCTO";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // bregresar
            // 
            this.bregresar.Location = new System.Drawing.Point(407, 242);
            this.bregresar.Name = "bregresar";
            this.bregresar.Size = new System.Drawing.Size(75, 23);
            this.bregresar.TabIndex = 5;
            this.bregresar.Text = "REGRESAR";
            this.bregresar.UseVisualStyleBackColor = true;
            this.bregresar.Click += new System.EventHandler(this.bregresar_Click);
            // 
            // Inventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 362);
            this.Controls.Add(this.bregresar);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.datamostrar);
            this.Controls.Add(this.bactualizar);
            this.Name = "Inventario";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.datamostrar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.DataGridView datamostrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button bregresar;
    }
}