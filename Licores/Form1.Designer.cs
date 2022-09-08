namespace Licores
{
    partial class principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabprincipal = new System.Windows.Forms.TabPage();
            this.tcantidad = new System.Windows.Forms.TextBox();
            this.labelproducto = new System.Windows.Forms.Label();
            this.bpagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.bactualizar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bagregar = new System.Windows.Forms.Button();
            this.bmostrar = new System.Windows.Forms.Button();
            this.datadatos = new System.Windows.Forms.DataGridView();
            this.tvalor = new System.Windows.Forms.TextBox();
            this.tproducto = new System.Windows.Forms.TextBox();
            this.ttotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpaga = new System.Windows.Forms.TextBox();
            this.dataventas = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabprincipal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataventas)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabprincipal);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(807, 480);
            this.tabControl1.TabIndex = 0;
            // 
            // tabprincipal
            // 
            this.tabprincipal.Controls.Add(this.dataventas);
            this.tabprincipal.Controls.Add(this.tpaga);
            this.tabprincipal.Controls.Add(this.label6);
            this.tabprincipal.Controls.Add(this.ttotal);
            this.tabprincipal.Controls.Add(this.tproducto);
            this.tabprincipal.Controls.Add(this.tvalor);
            this.tabprincipal.Controls.Add(this.tcantidad);
            this.tabprincipal.Controls.Add(this.labelproducto);
            this.tabprincipal.Controls.Add(this.bpagar);
            this.tabprincipal.Controls.Add(this.label5);
            this.tabprincipal.Controls.Add(this.label4);
            this.tabprincipal.Controls.Add(this.label3);
            this.tabprincipal.Controls.Add(this.label2);
            this.tabprincipal.Location = new System.Drawing.Point(4, 22);
            this.tabprincipal.Name = "tabprincipal";
            this.tabprincipal.Padding = new System.Windows.Forms.Padding(3);
            this.tabprincipal.Size = new System.Drawing.Size(799, 454);
            this.tabprincipal.TabIndex = 0;
            this.tabprincipal.Text = "VENTAS";
            this.tabprincipal.UseVisualStyleBackColor = true;
            this.tabprincipal.Click += new System.EventHandler(this.tabprincipal_Click);
            // 
            // tcantidad
            // 
            this.tcantidad.Location = new System.Drawing.Point(516, 155);
            this.tcantidad.Name = "tcantidad";
            this.tcantidad.Size = new System.Drawing.Size(88, 20);
            this.tcantidad.TabIndex = 9;
            // 
            // labelproducto
            // 
            this.labelproducto.AutoSize = true;
            this.labelproducto.Location = new System.Drawing.Point(527, 87);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(0, 13);
            this.labelproducto.TabIndex = 8;
            // 
            // bpagar
            // 
            this.bpagar.Location = new System.Drawing.Point(516, 252);
            this.bpagar.Name = "bpagar";
            this.bpagar.Size = new System.Drawing.Size(75, 23);
            this.bpagar.TabIndex = 7;
            this.bpagar.Text = "COBRAR";
            this.bpagar.UseVisualStyleBackColor = true;
            this.bpagar.Click += new System.EventHandler(this.bpagar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(430, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(429, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "VALOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(429, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTO";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.bactualizar);
            this.tabPage2.Controls.Add(this.beliminar);
            this.tabPage2.Controls.Add(this.bagregar);
            this.tabPage2.Controls.Add(this.bmostrar);
            this.tabPage2.Controls.Add(this.datadatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(799, 454);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INVENTARIO";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // bactualizar
            // 
            this.bactualizar.Location = new System.Drawing.Point(589, 289);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(155, 23);
            this.bactualizar.TabIndex = 4;
            this.bactualizar.Text = "ACTUALIZAR PRODUCTOS";
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Location = new System.Drawing.Point(589, 208);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(155, 23);
            this.beliminar.TabIndex = 3;
            this.beliminar.Text = "ELIMINAR PRODUCTO";
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bagregar
            // 
            this.bagregar.Location = new System.Drawing.Point(589, 124);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(155, 23);
            this.bagregar.TabIndex = 2;
            this.bagregar.Text = "AGREGAR PRODUCTO";
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // bmostrar
            // 
            this.bmostrar.Location = new System.Drawing.Point(225, 91);
            this.bmostrar.Name = "bmostrar";
            this.bmostrar.Size = new System.Drawing.Size(149, 23);
            this.bmostrar.TabIndex = 1;
            this.bmostrar.Text = "ACTUALIZAR TABLA";
            this.bmostrar.UseVisualStyleBackColor = true;
            this.bmostrar.Click += new System.EventHandler(this.bmostrar_Click);
            // 
            // datadatos
            // 
            this.datadatos.AllowUserToAddRows = false;
            this.datadatos.AllowUserToDeleteRows = false;
            this.datadatos.AllowUserToOrderColumns = true;
            this.datadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadatos.Location = new System.Drawing.Point(62, 141);
            this.datadatos.Name = "datadatos";
            this.datadatos.ReadOnly = true;
            this.datadatos.Size = new System.Drawing.Size(448, 125);
            this.datadatos.TabIndex = 0;
            this.datadatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadatos_CellContentClick);
            // 
            // tvalor
            // 
            this.tvalor.Location = new System.Drawing.Point(516, 116);
            this.tvalor.Name = "tvalor";
            this.tvalor.Size = new System.Drawing.Size(88, 20);
            this.tvalor.TabIndex = 10;
            // 
            // tproducto
            // 
            this.tproducto.Location = new System.Drawing.Point(516, 79);
            this.tproducto.Name = "tproducto";
            this.tproducto.Size = new System.Drawing.Size(158, 20);
            this.tproducto.TabIndex = 11;
            // 
            // ttotal
            // 
            this.ttotal.Location = new System.Drawing.Point(516, 188);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(88, 20);
            this.ttotal.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(433, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PAGA";
            // 
            // tpaga
            // 
            this.tpaga.Location = new System.Drawing.Point(516, 216);
            this.tpaga.Name = "tpaga";
            this.tpaga.Size = new System.Drawing.Size(88, 20);
            this.tpaga.TabIndex = 14;
            // 
            // dataventas
            // 
            this.dataventas.AllowUserToAddRows = false;
            this.dataventas.AllowUserToDeleteRows = false;
            this.dataventas.AllowUserToOrderColumns = true;
            this.dataventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataventas.Location = new System.Drawing.Point(37, 79);
            this.dataventas.Name = "dataventas";
            this.dataventas.ReadOnly = true;
            this.dataventas.Size = new System.Drawing.Size(340, 232);
            this.dataventas.TabIndex = 15;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 475);
            this.Controls.Add(this.tabControl1);
            this.Name = "principal";
            this.Text = "LICORES";
            this.Load += new System.EventHandler(this.principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabprincipal.ResumeLayout(false);
            this.tabprincipal.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datadatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataventas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabprincipal;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button bactualizar;
        private System.Windows.Forms.Button beliminar;
        private System.Windows.Forms.Button bagregar;
        private System.Windows.Forms.Button bmostrar;
        private System.Windows.Forms.DataGridView datadatos;
        private System.Windows.Forms.Label labelproducto;
        private System.Windows.Forms.Button bpagar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tcantidad;
        private System.Windows.Forms.TextBox tpaga;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ttotal;
        private System.Windows.Forms.TextBox tproducto;
        private System.Windows.Forms.TextBox tvalor;
        private System.Windows.Forms.DataGridView dataventas;
    }
}

