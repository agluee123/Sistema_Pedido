namespace Presentacion
{
    partial class Pedidos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pedidos));
            this.cbxCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.BtnAgregarProducto = new System.Windows.Forms.Button();
            this.gbxCrearPedido = new System.Windows.Forms.GroupBox();
            this.lblTipo = new System.Windows.Forms.Label();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.btnEliminarPedido = new System.Windows.Forms.Button();
            this.lblFecha = new System.Windows.Forms.Label();
            this.dtpFechaPedido = new System.Windows.Forms.DateTimePicker();
            this.dgvListaPedidos = new System.Windows.Forms.DataGridView();
            this.chkSelect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnReg = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.gbxFecha = new System.Windows.Forms.GroupBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblHasta = new System.Windows.Forms.Label();
            this.lblDesde = new System.Windows.Forms.Label();
            this.dTPreg2 = new System.Windows.Forms.DateTimePicker();
            this.dTPReg1 = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnBuscarEst = new System.Windows.Forms.Button();
            this.cbxSelEstado = new System.Windows.Forms.ComboBox();
            this.cbxSelTipo = new System.Windows.Forms.ComboBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.gbxCrearPedido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).BeginInit();
            this.gbxFecha.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbxCliente
            // 
            this.cbxCliente.FormattingEnabled = true;
            this.cbxCliente.Location = new System.Drawing.Point(175, 27);
            this.cbxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.cbxCliente.Name = "cbxCliente";
            this.cbxCliente.Size = new System.Drawing.Size(265, 24);
            this.cbxCliente.TabIndex = 2;
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(35, 31);
            this.lblCliente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(112, 16);
            this.lblCliente.TabIndex = 1;
            this.lblCliente.Text = "Seleccion cliente:";
            // 
            // BtnAgregarProducto
            // 
            this.BtnAgregarProducto.Location = new System.Drawing.Point(27, 162);
            this.BtnAgregarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.BtnAgregarProducto.Name = "BtnAgregarProducto";
            this.BtnAgregarProducto.Size = new System.Drawing.Size(179, 28);
            this.BtnAgregarProducto.TabIndex = 7;
            this.BtnAgregarProducto.Text = "Agregar Productos";
            this.BtnAgregarProducto.UseVisualStyleBackColor = true;
            this.BtnAgregarProducto.Click += new System.EventHandler(this.BtnAgregarProducto_Click);
            // 
            // gbxCrearPedido
            // 
            this.gbxCrearPedido.Controls.Add(this.lblTipo);
            this.gbxCrearPedido.Controls.Add(this.cbxTipo);
            this.gbxCrearPedido.Controls.Add(this.btnEliminarPedido);
            this.gbxCrearPedido.Controls.Add(this.lblFecha);
            this.gbxCrearPedido.Controls.Add(this.dtpFechaPedido);
            this.gbxCrearPedido.Controls.Add(this.lblCliente);
            this.gbxCrearPedido.Controls.Add(this.BtnAgregarProducto);
            this.gbxCrearPedido.Controls.Add(this.cbxCliente);
            this.gbxCrearPedido.Location = new System.Drawing.Point(32, 94);
            this.gbxCrearPedido.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCrearPedido.Name = "gbxCrearPedido";
            this.gbxCrearPedido.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCrearPedido.Size = new System.Drawing.Size(485, 207);
            this.gbxCrearPedido.TabIndex = 0;
            this.gbxCrearPedido.TabStop = false;
            this.gbxCrearPedido.Text = "Crear Nuevo Pedido";
            // 
            // lblTipo
            // 
            this.lblTipo.AutoSize = true;
            this.lblTipo.Location = new System.Drawing.Point(39, 116);
            this.lblTipo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipo.Name = "lblTipo";
            this.lblTipo.Size = new System.Drawing.Size(104, 16);
            this.lblTipo.TabIndex = 5;
            this.lblTipo.Text = "Tipo de Pedido:";
            // 
            // cbxTipo
            // 
            this.cbxTipo.Cursor = System.Windows.Forms.Cursors.Default;
            this.cbxTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Viaje",
            "Semanal",
            "Transporte"});
            this.cbxTipo.Location = new System.Drawing.Point(175, 106);
            this.cbxTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(265, 24);
            this.cbxTipo.TabIndex = 6;
            // 
            // btnEliminarPedido
            // 
            this.btnEliminarPedido.Location = new System.Drawing.Point(287, 162);
            this.btnEliminarPedido.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminarPedido.Name = "btnEliminarPedido";
            this.btnEliminarPedido.Size = new System.Drawing.Size(179, 28);
            this.btnEliminarPedido.TabIndex = 7;
            this.btnEliminarPedido.Text = "Eliminar Pedido";
            this.btnEliminarPedido.UseVisualStyleBackColor = true;
            this.btnEliminarPedido.Click += new System.EventHandler(this.btnEliminarPedido_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(39, 66);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(48, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha:";
            // 
            // dtpFechaPedido
            // 
            this.dtpFechaPedido.Location = new System.Drawing.Point(175, 66);
            this.dtpFechaPedido.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFechaPedido.Name = "dtpFechaPedido";
            this.dtpFechaPedido.Size = new System.Drawing.Size(265, 22);
            this.dtpFechaPedido.TabIndex = 4;
            // 
            // dgvListaPedidos
            // 
            this.dgvListaPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaPedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.chkSelect});
            this.dgvListaPedidos.Location = new System.Drawing.Point(587, 94);
            this.dgvListaPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvListaPedidos.Name = "dgvListaPedidos";
            this.dgvListaPedidos.ReadOnly = true;
            this.dgvListaPedidos.RowHeadersWidth = 51;
            this.dgvListaPedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaPedidos.Size = new System.Drawing.Size(879, 638);
            this.dgvListaPedidos.TabIndex = 8;
            this.dgvListaPedidos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellClick);
            this.dgvListaPedidos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListaPedidos_CellContentClick);
            this.dgvListaPedidos.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListaPedidos_CellFormatting);
            // 
            // chkSelect
            // 
            this.chkSelect.HeaderText = "Seleccionar";
            this.chkSelect.MinimumWidth = 6;
            this.chkSelect.Name = "chkSelect";
            this.chkSelect.ReadOnly = true;
            this.chkSelect.Width = 125;
            // 
            // btnReg
            // 
            this.btnReg.Location = new System.Drawing.Point(165, 704);
            this.btnReg.Margin = new System.Windows.Forms.Padding(4);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(179, 28);
            this.btnReg.TabIndex = 5;
            this.btnReg.Text = "Imprimir";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(688, 50);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(707, 22);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(587, 54);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 16);
            this.lblFiltro.TabIndex = 7;
            this.lblFiltro.Text = "Buscar:";
            // 
            // gbxFecha
            // 
            this.gbxFecha.Controls.Add(this.btnBuscar);
            this.gbxFecha.Controls.Add(this.lblHasta);
            this.gbxFecha.Controls.Add(this.lblDesde);
            this.gbxFecha.Controls.Add(this.dTPreg2);
            this.gbxFecha.Controls.Add(this.dTPReg1);
            this.gbxFecha.Location = new System.Drawing.Point(32, 326);
            this.gbxFecha.Margin = new System.Windows.Forms.Padding(4);
            this.gbxFecha.Name = "gbxFecha";
            this.gbxFecha.Padding = new System.Windows.Forms.Padding(4);
            this.gbxFecha.Size = new System.Drawing.Size(485, 177);
            this.gbxFecha.TabIndex = 1;
            this.gbxFecha.TabStop = false;
            this.gbxFecha.Text = "Buscar Por Fecha";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(147, 138);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(183, 31);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblHasta
            // 
            this.lblHasta.AutoSize = true;
            this.lblHasta.Location = new System.Drawing.Point(24, 82);
            this.lblHasta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHasta.Name = "lblHasta";
            this.lblHasta.Size = new System.Drawing.Size(46, 16);
            this.lblHasta.TabIndex = 3;
            this.lblHasta.Text = "Hasta:";
            // 
            // lblDesde
            // 
            this.lblDesde.AutoSize = true;
            this.lblDesde.Location = new System.Drawing.Point(20, 28);
            this.lblDesde.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDesde.Name = "lblDesde";
            this.lblDesde.Size = new System.Drawing.Size(51, 16);
            this.lblDesde.TabIndex = 1;
            this.lblDesde.Text = "Desde:";
            // 
            // dTPreg2
            // 
            this.dTPreg2.Location = new System.Drawing.Point(20, 105);
            this.dTPreg2.Margin = new System.Windows.Forms.Padding(4);
            this.dTPreg2.Name = "dTPreg2";
            this.dTPreg2.Size = new System.Drawing.Size(437, 22);
            this.dTPreg2.TabIndex = 4;
            // 
            // dTPReg1
            // 
            this.dTPReg1.Location = new System.Drawing.Point(20, 49);
            this.dTPReg1.Margin = new System.Windows.Forms.Padding(4);
            this.dTPReg1.Name = "dTPReg1";
            this.dTPReg1.Size = new System.Drawing.Size(437, 22);
            this.dTPReg1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscarEst);
            this.groupBox1.Controls.Add(this.cbxSelEstado);
            this.groupBox1.Controls.Add(this.cbxSelTipo);
            this.groupBox1.Location = new System.Drawing.Point(32, 528);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(485, 107);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Buscar Por Estado";
            // 
            // btnBuscarEst
            // 
            this.btnBuscarEst.Location = new System.Drawing.Point(147, 71);
            this.btnBuscarEst.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuscarEst.Name = "btnBuscarEst";
            this.btnBuscarEst.Size = new System.Drawing.Size(183, 28);
            this.btnBuscarEst.TabIndex = 2;
            this.btnBuscarEst.Text = "Buscar";
            this.btnBuscarEst.UseVisualStyleBackColor = true;
            this.btnBuscarEst.Click += new System.EventHandler(this.btnBuscarEst_Click);
            // 
            // cbxSelEstado
            // 
            this.cbxSelEstado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelEstado.FormattingEnabled = true;
            this.cbxSelEstado.Items.AddRange(new object[] {
            "Pendiente",
            "Entregado"});
            this.cbxSelEstado.Location = new System.Drawing.Point(280, 38);
            this.cbxSelEstado.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSelEstado.Name = "cbxSelEstado";
            this.cbxSelEstado.Size = new System.Drawing.Size(160, 24);
            this.cbxSelEstado.TabIndex = 1;
            // 
            // cbxSelTipo
            // 
            this.cbxSelTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxSelTipo.FormattingEnabled = true;
            this.cbxSelTipo.Items.AddRange(new object[] {
            "Semanal",
            "Viaje",
            "Transporte"});
            this.cbxSelTipo.Location = new System.Drawing.Point(32, 38);
            this.cbxSelTipo.Margin = new System.Windows.Forms.Padding(4);
            this.cbxSelTipo.Name = "cbxSelTipo";
            this.cbxSelTipo.Size = new System.Drawing.Size(160, 24);
            this.cbxSelTipo.TabIndex = 0;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(32, 655);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(179, 28);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar Busqueda";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(338, 655);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(179, 28);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // Pedidos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1532, 780);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbxFecha);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.dgvListaPedidos);
            this.Controls.Add(this.gbxCrearPedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Pedidos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Crear Pedido";
            this.Load += new System.EventHandler(this.Pedidos_Load);
            this.gbxCrearPedido.ResumeLayout(false);
            this.gbxCrearPedido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaPedidos)).EndInit();
            this.gbxFecha.ResumeLayout(false);
            this.gbxFecha.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbxCliente;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.Button BtnAgregarProducto;
        private System.Windows.Forms.GroupBox gbxCrearPedido;
        private System.Windows.Forms.DateTimePicker dtpFechaPedido;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Button btnEliminarPedido;
        private System.Windows.Forms.DataGridView dgvListaPedidos;
        private System.Windows.Forms.Label lblTipo;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.DataGridViewCheckBoxColumn chkSelect;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.GroupBox gbxFecha;
        private System.Windows.Forms.Label lblHasta;
        private System.Windows.Forms.Label lblDesde;
        private System.Windows.Forms.DateTimePicker dTPreg2;
        private System.Windows.Forms.DateTimePicker dTPReg1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEst;
        private System.Windows.Forms.ComboBox cbxSelEstado;
        private System.Windows.Forms.ComboBox cbxSelTipo;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
    }
}