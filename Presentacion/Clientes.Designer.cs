namespace Presentacion
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbxCuit = new System.Windows.Forms.TextBox();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.lblCuit = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbxLocalidad = new System.Windows.Forms.TextBox();
            this.tbxDireccion = new System.Windows.Forms.TextBox();
            this.tbxTelefono = new System.Windows.Forms.TextBox();
            this.gbxCliente = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.gbxCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(292, 393);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 0;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(292, 321);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(100, 28);
            this.btnModificar.TabIndex = 12;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click_1);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(587, 54);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 16);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Buscar:";
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(688, 50);
            this.tbxFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(707, 22);
            this.tbxFiltro.TabIndex = 2;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(116, 394);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(587, 94);
            this.dgvClientes.Margin = new System.Windows.Forms.Padding(4);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(879, 638);
            this.dgvClientes.TabIndex = 3;
            this.dgvClientes.SelectionChanged += new System.EventHandler(this.dgvClientes_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(60, 322);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 28);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar cliente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // tbxCuit
            // 
            this.tbxCuit.Location = new System.Drawing.Point(220, 149);
            this.tbxCuit.Margin = new System.Windows.Forms.Padding(4);
            this.tbxCuit.Name = "tbxCuit";
            this.tbxCuit.Size = new System.Drawing.Size(132, 22);
            this.tbxCuit.TabIndex = 6;
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(220, 44);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(132, 22);
            this.tbxNombre.TabIndex = 2;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(112, 270);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(61, 16);
            this.lblTelefono.TabIndex = 9;
            this.lblTelefono.Text = "Telefono";
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(112, 210);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(67, 16);
            this.lblLocalidad.TabIndex = 7;
            this.lblLocalidad.Text = "Localidad";
            // 
            // lblCuit
            // 
            this.lblCuit.AutoSize = true;
            this.lblCuit.Location = new System.Drawing.Point(112, 153);
            this.lblCuit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCuit.Name = "lblCuit";
            this.lblCuit.Size = new System.Drawing.Size(29, 16);
            this.lblCuit.TabIndex = 5;
            this.lblCuit.Text = "Cuit";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(112, 102);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(64, 16);
            this.lblDireccion.TabIndex = 3;
            this.lblDireccion.Text = "Direccion";
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
            // tbxLocalidad
            // 
            this.tbxLocalidad.Location = new System.Drawing.Point(220, 210);
            this.tbxLocalidad.Margin = new System.Windows.Forms.Padding(4);
            this.tbxLocalidad.Name = "tbxLocalidad";
            this.tbxLocalidad.Size = new System.Drawing.Size(132, 22);
            this.tbxLocalidad.TabIndex = 8;
            // 
            // tbxDireccion
            // 
            this.tbxDireccion.Location = new System.Drawing.Point(220, 102);
            this.tbxDireccion.Margin = new System.Windows.Forms.Padding(4);
            this.tbxDireccion.Name = "tbxDireccion";
            this.tbxDireccion.Size = new System.Drawing.Size(132, 22);
            this.tbxDireccion.TabIndex = 4;
            // 
            // tbxTelefono
            // 
            this.tbxTelefono.Location = new System.Drawing.Point(220, 260);
            this.tbxTelefono.Margin = new System.Windows.Forms.Padding(4);
            this.tbxTelefono.Name = "tbxTelefono";
            this.tbxTelefono.Size = new System.Drawing.Size(132, 22);
            this.tbxTelefono.TabIndex = 10;
            // 
            // gbxCliente
            // 
            this.gbxCliente.Controls.Add(this.btnModificar);
            this.gbxCliente.Controls.Add(this.tbxTelefono);
            this.gbxCliente.Controls.Add(this.lblNombre);
            this.gbxCliente.Controls.Add(this.tbxDireccion);
            this.gbxCliente.Controls.Add(this.lblDireccion);
            this.gbxCliente.Controls.Add(this.tbxLocalidad);
            this.gbxCliente.Controls.Add(this.lblCuit);
            this.gbxCliente.Controls.Add(this.btnLimpiar);
            this.gbxCliente.Controls.Add(this.lblLocalidad);
            this.gbxCliente.Controls.Add(this.lblTelefono);
            this.gbxCliente.Controls.Add(this.tbxNombre);
            this.gbxCliente.Controls.Add(this.tbxCuit);
            this.gbxCliente.Controls.Add(this.btnEliminar);
            this.gbxCliente.Controls.Add(this.btnAgregar);
            this.gbxCliente.Location = new System.Drawing.Point(32, 94);
            this.gbxCliente.Margin = new System.Windows.Forms.Padding(4);
            this.gbxCliente.Name = "gbxCliente";
            this.gbxCliente.Padding = new System.Windows.Forms.Padding(4);
            this.gbxCliente.Size = new System.Drawing.Size(481, 650);
            this.gbxCliente.TabIndex = 0;
            this.gbxCliente.TabStop = false;
            this.gbxCliente.Text = "Cargar Cliente";
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1532, 780);
            this.Controls.Add(this.gbxCliente);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.dgvClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.gbxCliente.ResumeLayout(false);
            this.gbxCliente.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbxCuit;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.Label lblCuit;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbxLocalidad;
        private System.Windows.Forms.TextBox tbxDireccion;
        private System.Windows.Forms.TextBox tbxTelefono;
        private System.Windows.Forms.GroupBox gbxCliente;
    }
}