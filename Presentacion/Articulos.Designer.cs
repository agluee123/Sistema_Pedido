namespace Presentacion
{
    partial class Articulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Articulos));
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.tbxFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.cbxPerforacion = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblPerforacion = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.btnModiicar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.tbxNombre = new System.Windows.Forms.TextBox();
            this.gbxArticulo = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.gbxArticulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(588, 94);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 51;
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(879, 638);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // tbxFiltro
            // 
            this.tbxFiltro.Location = new System.Drawing.Point(688, 50);
            this.tbxFiltro.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxFiltro.Name = "tbxFiltro";
            this.tbxFiltro.Size = new System.Drawing.Size(706, 22);
            this.tbxFiltro.TabIndex = 2;
            this.tbxFiltro.TextChanged += new System.EventHandler(this.tbxFiltro_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(588, 54);
            this.lblFiltro.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(52, 16);
            this.lblFiltro.TabIndex = 1;
            this.lblFiltro.Text = "Buscar:";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(42, 225);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(172, 28);
            this.btnAgregar.TabIndex = 5;
            this.btnAgregar.Text = "Agregar articulo";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // cbxPerforacion
            // 
            this.cbxPerforacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxPerforacion.FormattingEnabled = true;
            this.cbxPerforacion.Items.AddRange(new object[] {
            "Tres agujeros",
            "Monocomando",
            "No corresponde"});
            this.cbxPerforacion.Location = new System.Drawing.Point(220, 145);
            this.cbxPerforacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxPerforacion.Name = "cbxPerforacion";
            this.cbxPerforacion.Size = new System.Drawing.Size(160, 24);
            this.cbxPerforacion.TabIndex = 4;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Items.AddRange(new object[] {
            "Mueble",
            "Mesada"});
            this.cbxCategoria.Location = new System.Drawing.Point(220, 88);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(160, 24);
            this.cbxCategoria.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(92, 304);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 28);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblPerforacion
            // 
            this.lblPerforacion.AutoSize = true;
            this.lblPerforacion.Location = new System.Drawing.Point(112, 155);
            this.lblPerforacion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPerforacion.Name = "lblPerforacion";
            this.lblPerforacion.Size = new System.Drawing.Size(76, 16);
            this.lblPerforacion.TabIndex = 3;
            this.lblPerforacion.Text = "Perforacion";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(112, 98);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(66, 16);
            this.lblCategoria.TabIndex = 1;
            this.lblCategoria.Text = "Categoria";
            // 
            // btnModiicar
            // 
            this.btnModiicar.Location = new System.Drawing.Point(279, 225);
            this.btnModiicar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnModiicar.Name = "btnModiicar";
            this.btnModiicar.Size = new System.Drawing.Size(100, 28);
            this.btnModiicar.TabIndex = 6;
            this.btnModiicar.Text = "Modificar";
            this.btnModiicar.UseVisualStyleBackColor = true;
            this.btnModiicar.Click += new System.EventHandler(this.btnModiicar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(112, 44);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(279, 304);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 8;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // tbxNombre
            // 
            this.tbxNombre.Location = new System.Drawing.Point(220, 44);
            this.tbxNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxNombre.Name = "tbxNombre";
            this.tbxNombre.Size = new System.Drawing.Size(132, 22);
            this.tbxNombre.TabIndex = 1;
            // 
            // gbxArticulo
            // 
            this.gbxArticulo.Controls.Add(this.tbxNombre);
            this.gbxArticulo.Controls.Add(this.btnLimpiar);
            this.gbxArticulo.Controls.Add(this.lblNombre);
            this.gbxArticulo.Controls.Add(this.btnModiicar);
            this.gbxArticulo.Controls.Add(this.lblCategoria);
            this.gbxArticulo.Controls.Add(this.lblPerforacion);
            this.gbxArticulo.Controls.Add(this.btnEliminar);
            this.gbxArticulo.Controls.Add(this.cbxCategoria);
            this.gbxArticulo.Controls.Add(this.cbxPerforacion);
            this.gbxArticulo.Controls.Add(this.btnAgregar);
            this.gbxArticulo.Location = new System.Drawing.Point(32, 94);
            this.gbxArticulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxArticulo.Name = "gbxArticulo";
            this.gbxArticulo.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbxArticulo.Size = new System.Drawing.Size(481, 650);
            this.gbxArticulo.TabIndex = 0;
            this.gbxArticulo.TabStop = false;
            this.gbxArticulo.Text = "Cargar Articulo";
            // 
            // Articulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1532, 780);
            this.Controls.Add(this.gbxArticulo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.tbxFiltro);
            this.Controls.Add(this.dgvArticulos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Articulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Articulos";
            this.Load += new System.EventHandler(this.Articulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.gbxArticulo.ResumeLayout(false);
            this.gbxArticulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox tbxFiltro;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ComboBox cbxPerforacion;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblPerforacion;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Button btnModiicar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox tbxNombre;
        private System.Windows.Forms.GroupBox gbxArticulo;
    }
}