namespace Presentacion
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnArticulos = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnPedidos = new System.Windows.Forms.Button();
            this.btnRegistros = new System.Windows.Forms.Button();
            this.pbxImg = new System.Windows.Forms.PictureBox();
            this.btnEmpleados = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnArticulos
            // 
            this.btnArticulos.BackColor = System.Drawing.Color.LightGray;
            this.btnArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnArticulos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArticulos.Location = new System.Drawing.Point(260, 416);
            this.btnArticulos.Margin = new System.Windows.Forms.Padding(4);
            this.btnArticulos.Name = "btnArticulos";
            this.btnArticulos.Size = new System.Drawing.Size(172, 102);
            this.btnArticulos.TabIndex = 1;
            this.btnArticulos.Text = "Articulos";
            this.btnArticulos.UseVisualStyleBackColor = false;
            this.btnArticulos.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.BackColor = System.Drawing.Color.LightGray;
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClientes.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.Location = new System.Drawing.Point(456, 416);
            this.btnClientes.Margin = new System.Windows.Forms.Padding(4);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(172, 102);
            this.btnClientes.TabIndex = 2;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = false;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnPedidos
            // 
            this.btnPedidos.BackColor = System.Drawing.Color.LightGray;
            this.btnPedidos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPedidos.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPedidos.Location = new System.Drawing.Point(653, 416);
            this.btnPedidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnPedidos.Name = "btnPedidos";
            this.btnPedidos.Size = new System.Drawing.Size(172, 102);
            this.btnPedidos.TabIndex = 3;
            this.btnPedidos.Text = "Pedidos";
            this.btnPedidos.UseVisualStyleBackColor = false;
            this.btnPedidos.Click += new System.EventHandler(this.btnPedidos_Click);
            // 
            // btnRegistros
            // 
            this.btnRegistros.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistros.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegistros.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistros.Location = new System.Drawing.Point(845, 416);
            this.btnRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistros.Name = "btnRegistros";
            this.btnRegistros.Size = new System.Drawing.Size(172, 102);
            this.btnRegistros.TabIndex = 4;
            this.btnRegistros.Text = "Registros";
            this.btnRegistros.UseVisualStyleBackColor = false;
            this.btnRegistros.Click += new System.EventHandler(this.btnRegistros_Click);
            // 
            // pbxImg
            // 
            this.pbxImg.Image = ((System.Drawing.Image)(resources.GetObject("pbxImg.Image")));
            this.pbxImg.Location = new System.Drawing.Point(83, 94);
            this.pbxImg.Margin = new System.Windows.Forms.Padding(4);
            this.pbxImg.Name = "pbxImg";
            this.pbxImg.Size = new System.Drawing.Size(896, 210);
            this.pbxImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxImg.TabIndex = 4;
            this.pbxImg.TabStop = false;
            // 
            // btnEmpleados
            // 
            this.btnEmpleados.BackColor = System.Drawing.Color.LightGray;
            this.btnEmpleados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEmpleados.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmpleados.Location = new System.Drawing.Point(68, 416);
            this.btnEmpleados.Margin = new System.Windows.Forms.Padding(4);
            this.btnEmpleados.Name = "btnEmpleados";
            this.btnEmpleados.Size = new System.Drawing.Size(172, 102);
            this.btnEmpleados.TabIndex = 0;
            this.btnEmpleados.Text = "Empleados";
            this.btnEmpleados.UseVisualStyleBackColor = false;
            this.btnEmpleados.Click += new System.EventHandler(this.btnEmpleados_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1083, 544);
            this.Controls.Add(this.btnEmpleados);
            this.Controls.Add(this.pbxImg);
            this.Controls.Add(this.btnRegistros);
            this.Controls.Add(this.btnPedidos);
            this.Controls.Add(this.btnClientes);
            this.Controls.Add(this.btnArticulos);
            this.ForeColor = System.Drawing.SystemColors.WindowText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TransparencyKey = System.Drawing.Color.RosyBrown;
            ((System.ComponentModel.ISupportInitialize)(this.pbxImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnArticulos;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnPedidos;
        private System.Windows.Forms.Button btnRegistros;
        private System.Windows.Forms.PictureBox pbxImg;
        private System.Windows.Forms.Button btnEmpleados;
    }
}

