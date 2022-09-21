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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(principal));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabprincipal = new System.Windows.Forms.TabPage();
            this.butactualizar = new System.Windows.Forms.Button();
            this.btotal = new System.Windows.Forms.Button();
            this.dataventas = new System.Windows.Forms.DataGridView();
            this.tpaga = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ttotal = new System.Windows.Forms.TextBox();
            this.tproducto = new System.Windows.Forms.TextBox();
            this.tvalor = new System.Windows.Forms.TextBox();
            this.tcantidad = new System.Windows.Forms.TextBox();
            this.labelproducto = new System.Windows.Forms.Label();
            this.bpagar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tecodigo = new System.Windows.Forms.TextBox();
            this.tevalor = new System.Windows.Forms.TextBox();
            this.tecantidad = new System.Windows.Forms.TextBox();
            this.teproducto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bactualizar = new System.Windows.Forms.Button();
            this.beliminar = new System.Windows.Forms.Button();
            this.bagregar = new System.Windows.Forms.Button();
            this.bmostrar = new System.Windows.Forms.Button();
            this.datadatos = new System.Windows.Forms.DataGridView();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl1.SuspendLayout();
            this.tabprincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataventas)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadatos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabprincipal);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-4, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(687, 369);
            this.tabControl1.TabIndex = 0;
            // 
            // tabprincipal
            // 
            this.tabprincipal.Controls.Add(this.butactualizar);
            this.tabprincipal.Controls.Add(this.btotal);
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
            this.tabprincipal.Size = new System.Drawing.Size(679, 343);
            this.tabprincipal.TabIndex = 0;
            this.tabprincipal.Text = "VENTAS";
            this.tabprincipal.UseVisualStyleBackColor = true;
            this.tabprincipal.Click += new System.EventHandler(this.tabprincipal_Click);
            // 
            // butactualizar
            // 
            this.butactualizar.Location = new System.Drawing.Point(85, 290);
            this.butactualizar.Name = "butactualizar";
            this.butactualizar.Size = new System.Drawing.Size(186, 23);
            this.butactualizar.TabIndex = 17;
            this.butactualizar.Text = "ACTUALIZAR TABLA";
            this.butactualizar.UseVisualStyleBackColor = true;
            this.butactualizar.Click += new System.EventHandler(this.butactualizar_Click);
            // 
            // btotal
            // 
            this.btotal.Location = new System.Drawing.Point(411, 206);
            this.btotal.Name = "btotal";
            this.btotal.Size = new System.Drawing.Size(75, 23);
            this.btotal.TabIndex = 16;
            this.btotal.Text = "TOTAL";
            this.btotal.UseVisualStyleBackColor = true;
            this.btotal.Click += new System.EventHandler(this.btotal_Click);
            // 
            // dataventas
            // 
            this.dataventas.AllowUserToAddRows = false;
            this.dataventas.AllowUserToDeleteRows = false;
            this.dataventas.AllowUserToOrderColumns = true;
            this.dataventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataventas.Location = new System.Drawing.Point(12, 20);
            this.dataventas.Name = "dataventas";
            this.dataventas.ReadOnly = true;
            this.dataventas.Size = new System.Drawing.Size(340, 232);
            this.dataventas.TabIndex = 15;
            this.dataventas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataventas_CellContentClick);
            // 
            // tpaga
            // 
            this.tpaga.Location = new System.Drawing.Point(491, 157);
            this.tpaga.Name = "tpaga";
            this.tpaga.Size = new System.Drawing.Size(88, 20);
            this.tpaga.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 157);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "PAGA";
            // 
            // ttotal
            // 
            this.ttotal.Location = new System.Drawing.Point(491, 129);
            this.ttotal.Name = "ttotal";
            this.ttotal.Size = new System.Drawing.Size(88, 20);
            this.ttotal.TabIndex = 12;
            // 
            // tproducto
            // 
            this.tproducto.Location = new System.Drawing.Point(491, 20);
            this.tproducto.Name = "tproducto";
            this.tproducto.Size = new System.Drawing.Size(158, 20);
            this.tproducto.TabIndex = 11;
            // 
            // tvalor
            // 
            this.tvalor.Location = new System.Drawing.Point(491, 57);
            this.tvalor.Name = "tvalor";
            this.tvalor.Size = new System.Drawing.Size(88, 20);
            this.tvalor.TabIndex = 10;
            // 
            // tcantidad
            // 
            this.tcantidad.Location = new System.Drawing.Point(491, 96);
            this.tcantidad.Name = "tcantidad";
            this.tcantidad.Size = new System.Drawing.Size(88, 20);
            this.tcantidad.TabIndex = 9;
            // 
            // labelproducto
            // 
            this.labelproducto.AutoSize = true;
            this.labelproducto.Location = new System.Drawing.Point(502, 28);
            this.labelproducto.Name = "labelproducto";
            this.labelproducto.Size = new System.Drawing.Size(0, 13);
            this.labelproducto.TabIndex = 8;
            // 
            // bpagar
            // 
            this.bpagar.Location = new System.Drawing.Point(542, 206);
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
            this.label5.Location = new System.Drawing.Point(405, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "TOTAL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(404, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "CANTIDAD";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(404, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "VALOR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(404, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PRODUCTO";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.tecodigo);
            this.tabPage2.Controls.Add(this.tevalor);
            this.tabPage2.Controls.Add(this.tecantidad);
            this.tabPage2.Controls.Add(this.teproducto);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.bactualizar);
            this.tabPage2.Controls.Add(this.beliminar);
            this.tabPage2.Controls.Add(this.bagregar);
            this.tabPage2.Controls.Add(this.bmostrar);
            this.tabPage2.Controls.Add(this.datadatos);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(679, 343);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "INVENTARIO";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Image = ((System.Drawing.Image)(resources.GetObject("label11.Image")));
            this.label11.Location = new System.Drawing.Point(51, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(73, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "INVENTARIO";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label10.Image = ((System.Drawing.Image)(resources.GetObject("label10.Image")));
            this.label10.Location = new System.Drawing.Point(65, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "PRODUCTO";
            // 
            // tecodigo
            // 
            this.tecodigo.Location = new System.Drawing.Point(359, 136);
            this.tecodigo.MaxLength = 5;
            this.tecodigo.Name = "tecodigo";
            this.tecodigo.Size = new System.Drawing.Size(100, 20);
            this.tecodigo.TabIndex = 12;
            this.tecodigo.Validating += new System.ComponentModel.CancelEventHandler(this.tecodigo_Validating);
            // 
            // tevalor
            // 
            this.tevalor.Location = new System.Drawing.Point(137, 136);
            this.tevalor.MaxLength = 50;
            this.tevalor.Name = "tevalor";
            this.tevalor.Size = new System.Drawing.Size(100, 20);
            this.tevalor.TabIndex = 11;
            this.tevalor.Validating += new System.ComponentModel.CancelEventHandler(this.tevalor_Validating);
            // 
            // tecantidad
            // 
            this.tecantidad.Location = new System.Drawing.Point(359, 97);
            this.tecantidad.MaxLength = 5;
            this.tecantidad.Name = "tecantidad";
            this.tecantidad.Size = new System.Drawing.Size(100, 20);
            this.tecantidad.TabIndex = 10;
            this.tecantidad.TextChanged += new System.EventHandler(this.tecantidad_TextChanged);
            this.tecantidad.Validating += new System.ComponentModel.CancelEventHandler(this.tecantidad_Validating);
            // 
            // teproducto
            // 
            this.teproducto.Location = new System.Drawing.Point(137, 98);
            this.teproducto.MaxLength = 50;
            this.teproducto.Name = "teproducto";
            this.teproducto.Size = new System.Drawing.Size(147, 20);
            this.teproducto.TabIndex = 9;
            this.teproducto.Validating += new System.ComponentModel.CancelEventHandler(this.teproducto_Validating);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(290, 139);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(49, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "CODIGO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(62, 139);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "VALOR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(290, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "CANTIDAD";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "PRODUCTO";
            // 
            // bactualizar
            // 
            this.bactualizar.Image = ((System.Drawing.Image)(resources.GetObject("bactualizar.Image")));
            this.bactualizar.Location = new System.Drawing.Point(563, 257);
            this.bactualizar.Name = "bactualizar";
            this.bactualizar.Size = new System.Drawing.Size(60, 60);
            this.bactualizar.TabIndex = 4;
            this.bactualizar.UseVisualStyleBackColor = true;
            this.bactualizar.Click += new System.EventHandler(this.bactualizar_Click);
            // 
            // beliminar
            // 
            this.beliminar.Image = ((System.Drawing.Image)(resources.GetObject("beliminar.Image")));
            this.beliminar.Location = new System.Drawing.Point(563, 176);
            this.beliminar.Name = "beliminar";
            this.beliminar.Size = new System.Drawing.Size(60, 60);
            this.beliminar.TabIndex = 3;
            this.beliminar.UseVisualStyleBackColor = true;
            this.beliminar.Click += new System.EventHandler(this.beliminar_Click);
            // 
            // bagregar
            // 
            this.bagregar.Image = ((System.Drawing.Image)(resources.GetObject("bagregar.Image")));
            this.bagregar.Location = new System.Drawing.Point(563, 92);
            this.bagregar.Name = "bagregar";
            this.bagregar.Size = new System.Drawing.Size(60, 60);
            this.bagregar.TabIndex = 2;
            this.bagregar.UseVisualStyleBackColor = true;
            this.bagregar.Click += new System.EventHandler(this.bagregar_Click);
            // 
            // bmostrar
            // 
            this.bmostrar.Location = new System.Drawing.Point(235, 19);
            this.bmostrar.Name = "bmostrar";
            this.bmostrar.Size = new System.Drawing.Size(211, 23);
            this.bmostrar.TabIndex = 1;
            this.bmostrar.Text = "ACTUALIZAR INFORMACION";
            this.bmostrar.UseVisualStyleBackColor = true;
            this.bmostrar.Click += new System.EventHandler(this.bmostrar_Click);
            // 
            // datadatos
            // 
            this.datadatos.AllowUserToAddRows = false;
            this.datadatos.AllowUserToDeleteRows = false;
            this.datadatos.AllowUserToOrderColumns = true;
            this.datadatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datadatos.Location = new System.Drawing.Point(51, 192);
            this.datadatos.Name = "datadatos";
            this.datadatos.ReadOnly = true;
            this.datadatos.Size = new System.Drawing.Size(448, 125);
            this.datadatos.TabIndex = 0;
            this.datadatos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datadatos_CellContentClick);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 367);
            this.Controls.Add(this.tabControl1);
            this.Name = "principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LICORES";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.principal_FormClosing);
            this.Load += new System.EventHandler(this.principal_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabprincipal.ResumeLayout(false);
            this.tabprincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataventas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datadatos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tecodigo;
        private System.Windows.Forms.TextBox tevalor;
        private System.Windows.Forms.TextBox tecantidad;
        private System.Windows.Forms.TextBox teproducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btotal;
        private System.Windows.Forms.Button butactualizar;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

