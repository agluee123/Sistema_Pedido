namespace Presentacion
{
    partial class Registros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registros));
            this.dgvRegistros = new System.Windows.Forms.DataGridView();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnImprimirVendidos = new System.Windows.Forms.Button();
            this.GbxImpresion = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).BeginInit();
            this.GbxImpresion.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvRegistros
            // 
            this.dgvRegistros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRegistros.Location = new System.Drawing.Point(55, 212);
            this.dgvRegistros.Margin = new System.Windows.Forms.Padding(4);
            this.dgvRegistros.Name = "dgvRegistros";
            this.dgvRegistros.RowHeadersWidth = 51;
            this.dgvRegistros.Size = new System.Drawing.Size(951, 554);
            this.dgvRegistros.TabIndex = 1;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Location = new System.Drawing.Point(91, 60);
            this.btnImprimir.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(177, 31);
            this.btnImprimir.TabIndex = 0;
            this.btnImprimir.Text = "Imprimir Semanal";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnImprimirVendidos
            // 
            this.btnImprimirVendidos.Location = new System.Drawing.Point(417, 60);
            this.btnImprimirVendidos.Margin = new System.Windows.Forms.Padding(4);
            this.btnImprimirVendidos.Name = "btnImprimirVendidos";
            this.btnImprimirVendidos.Size = new System.Drawing.Size(227, 31);
            this.btnImprimirVendidos.TabIndex = 1;
            this.btnImprimirVendidos.Text = "Imprimir Viaje";
            this.btnImprimirVendidos.UseVisualStyleBackColor = true;
            this.btnImprimirVendidos.Click += new System.EventHandler(this.btnImprimirVendidos_Click);
            // 
            // GbxImpresion
            // 
            this.GbxImpresion.Controls.Add(this.btnImprimir);
            this.GbxImpresion.Controls.Add(this.btnImprimirVendidos);
            this.GbxImpresion.Location = new System.Drawing.Point(144, 15);
            this.GbxImpresion.Margin = new System.Windows.Forms.Padding(4);
            this.GbxImpresion.Name = "GbxImpresion";
            this.GbxImpresion.Padding = new System.Windows.Forms.Padding(4);
            this.GbxImpresion.Size = new System.Drawing.Size(783, 146);
            this.GbxImpresion.TabIndex = 0;
            this.GbxImpresion.TabStop = false;
            this.GbxImpresion.Text = "Imprimir";
            // 
            // Registros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1049, 780);
            this.Controls.Add(this.GbxImpresion);
            this.Controls.Add(this.dgvRegistros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Registros";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registros";
            this.Load += new System.EventHandler(this.Registros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRegistros)).EndInit();
            this.GbxImpresion.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvRegistros;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnImprimirVendidos;
        private System.Windows.Forms.GroupBox GbxImpresion;
    }
}