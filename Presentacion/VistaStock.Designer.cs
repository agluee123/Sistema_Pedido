namespace Ilgabinetto
{
    partial class VistaStock
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
            this.gbxStock = new System.Windows.Forms.GroupBox();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxStock = new System.Windows.Forms.TextBox();
            this.Cantidad = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.gbxEntrega = new System.Windows.Forms.GroupBox();
            this.btnLimp = new System.Windows.Forms.Button();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tbxEntregado = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.cbxProducto = new System.Windows.Forms.ComboBox();
            this.dtpFechaEntrega = new System.Windows.Forms.DateTimePicker();
            this.dgvEntrega = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gbxStock.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.gbxEntrega.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).BeginInit();
            this.SuspendLayout();
            // 
            // gbxStock
            // 
            this.gbxStock.Controls.Add(this.btnModificar);
            this.gbxStock.Controls.Add(this.lblNombre);
            this.gbxStock.Controls.Add(this.tbxStock);
            this.gbxStock.Controls.Add(this.Cantidad);
            this.gbxStock.Controls.Add(this.btnLimpiar);
            this.gbxStock.Controls.Add(this.tbxNombre);
            this.gbxStock.Controls.Add(this.btnEliminar);
            this.gbxStock.Controls.Add(this.btnAgregar);
            this.gbxStock.Location = new System.Drawing.Point(49, 87);
            this.gbxStock.Margin = new System.Windows.Forms.Padding(4);
            this.gbxStock.Name = "gbxStock";
            this.gbxStock.Padding = new System.Windows.Forms.Padding(4);
            this.gbxStock.Size = new System.Drawing.Size(481, 275);
            this.gbxStock.TabIndex = 4;
            this.gbxStock.TabStop = false;
            this.gbxStock.Text = "Cargar Stock";
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(292, 157);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(112, 44);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // tbxStock
            // 
            this.tbxStock.Location = new System.Drawing.Point(220, 102);
            this.tbxStock.Margin = new System.Windows.Forms.Padding(4);
            this.tbxStock.Name = "tbxStock";
            this.tbxStock.Size = new System.Drawing.Size(132, 22);
            this.tbxStock.TabIndex = 4;
            // 
            // Cantidad
            // 
            this.Cantidad.AutoSize = true;
            this.Cantidad.Location = new System.Drawing.Point(112, 102);
            this.Cantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Size = new System.Drawing.Size(61, 16);
            this.Cantidad.TabIndex = 3;
            this.Cantidad.Text = "Cantidad";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(292, 215);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(220, 44);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(132, 22);
            this.tbxNombre.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(116, 216);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(60, 158);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 28);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(605, 53);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 16);
            this.lblFiltro.TabIndex = 5;
            this.lblFiltro.Text = "Buscar:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(706, 49);
            this.tbxFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(707, 22);
            this.tbxFiltro.TabIndex = 6;
            // 
            // dgvStock
            // 
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStock.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(604, 87);
            this.dgvStock.Margin = new System.Windows.Forms.Padding(4);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(879, 275);
            this.dgvStock.TabIndex = 7;
            this.dgvStock.SelectionChanged += new System.EventHandler(this.dgvStock_SelectionChanged);
            // 
            // gbxEntrega
            // 
            this.gbxEntrega.Controls.Add(this.dtpFechaEntrega);
            this.gbxEntrega.Controls.Add(this.cbxProducto);
            this.gbxEntrega.Controls.Add(this.tbxCantidad);
            this.gbxEntrega.Controls.Add(this.lblCantidad);
            this.gbxEntrega.Controls.Add(this.label3);
            this.gbxEntrega.Controls.Add(this.btnLimp);
            this.gbxEntrega.Controls.Add(this.lblProducto);
            this.gbxEntrega.Controls.Add(this.tbxEntregado);
            this.gbxEntrega.Controls.Add(this.label2);
            this.gbxEntrega.Controls.Add(this.btnRegistrar);
            this.gbxEntrega.Location = new System.Drawing.Point(49, 382);
            this.gbxEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.gbxEntrega.Name = "gbxEntrega";
            this.gbxEntrega.Padding = new System.Windows.Forms.Padding(4);
            this.gbxEntrega.Size = new System.Drawing.Size(481, 385);
            this.gbxEntrega.TabIndex = 8;
            this.gbxEntrega.TabStop = false;
            this.gbxEntrega.Text = "Registrar Entrega";
            // 
            // btnLimp
            // 
            this.btnLimp.Location = new System.Drawing.Point(292, 216);
            this.btnLimp.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimp.Name = "btnLimp";
            this.btnLimp.Size = new System.Drawing.Size(100, 28);
            this.btnLimp.TabIndex = 12;
            this.btnLimp.Text = "Limpiar";
            this.btnLimp.UseVisualStyleBackColor = true;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(112, 44);
            this.lblProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(64, 16);
            this.lblProducto.TabIndex = 1;
            this.lblProducto.Text = "Producto:";
            // 
            // tbxEntregado
            // 
            this.tbxEntregado.Location = new System.Drawing.Point(219, 73);
            this.tbxEntregado.Margin = new System.Windows.Forms.Padding(4);
            this.tbxEntregado.Name = "tbxEntregado";
            this.tbxEntregado.Size = new System.Drawing.Size(132, 22);
            this.tbxEntregado.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Entregado a:";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(60, 217);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(172, 28);
            this.btnRegistrar.TabIndex = 11;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Fecha de entrega:";
            // 
            // tbxCantidad
            // 
            this.tbxCantidad.Location = new System.Drawing.Point(220, 106);
            this.tbxCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCantidad.Name = "tbxCantidad";
            this.tbxCantidad.Size = new System.Drawing.Size(132, 22);
            this.tbxCantidad.TabIndex = 17;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(113, 112);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(64, 16);
            this.lblCantidad.TabIndex = 16;
            this.lblCantidad.Text = "Cantidad:";
            // 
            // cbxProducto
            // 
            this.cbxProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxProducto.FormattingEnabled = true;
            this.cbxProducto.Location = new System.Drawing.Point(220, 37);
            this.cbxProducto.Name = "cbxProducto";
            this.cbxProducto.Size = new System.Drawing.Size(196, 24);
            this.cbxProducto.TabIndex = 18;
            // 
            // dtpFechaEntrega
            // 
            this.dtpFechaEntrega.Location = new System.Drawing.Point(216, 145);
            this.dtpFechaEntrega.Name = "dtpFechaEntrega";
            this.dtpFechaEntrega.Size = new System.Drawing.Size(200, 22);
            this.dtpFechaEntrega.TabIndex = 19;
            // 
            // dgvEntrega
            // 
            this.dgvEntrega.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvEntrega.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvEntrega.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntrega.Location = new System.Drawing.Point(604, 427);
            this.dgvEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.dgvEntrega.Name = "dgvEntrega";
            this.dgvEntrega.ReadOnly = true;
            this.dgvEntrega.RowHeadersWidth = 51;
            this.dgvEntrega.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvEntrega.Size = new System.Drawing.Size(879, 340);
            this.dgvEntrega.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(604, 401);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar:";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(705, 397);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(707, 22);
            this.textBox2.TabIndex = 11;
            // 
            // VistaStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 780);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.dgvEntrega);
            this.Controls.Add(this.gbxEntrega);
            this.Controls.Add(this.gbxStock);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.dgvStock);
            this.Name = "VistaStock";
            this.Text = "VistaStock";
            this.Load += new System.EventHandler(this.VistaStock_Load);
            this.gbxStock.ResumeLayout(false);
            this.gbxStock.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.gbxEntrega.ResumeLayout(false);
            this.gbxEntrega.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntrega)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbxStock;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxStock;
        private System.Windows.Forms.Label Cantidad;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.GroupBox gbxEntrega;
        private System.Windows.Forms.Button btnLimp;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox tbxEntregado;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox tbxCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxProducto;
        private System.Windows.Forms.DateTimePicker dtpFechaEntrega;
        private System.Windows.Forms.DataGridView dgvEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
    }
}