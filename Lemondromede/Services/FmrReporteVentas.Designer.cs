namespace Lemondromede.Fomrs
{
    partial class FmrReporteVentas
    {
        
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pnlFiltros = new Panel();
            btnExportar = new Button();
            btnBuscar = new Button();
            lblHasta = new Label();
            dtpHasta = new DateTimePicker();
            dtpDesde = new DateTimePicker();
            lblDesde = new Label();
            lblResumen = new Label();
            dgvReporte = new DataGridView();
            pnlFiltros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).BeginInit();
            SuspendLayout();
     
            pnlFiltros.Controls.Add(btnExportar);
            pnlFiltros.Controls.Add(btnBuscar);
            pnlFiltros.Controls.Add(lblHasta);
            pnlFiltros.Controls.Add(dtpHasta);
            pnlFiltros.Controls.Add(dtpDesde);
            pnlFiltros.Controls.Add(lblDesde);
            pnlFiltros.Dock = DockStyle.Top;
            pnlFiltros.Location = new Point(0, 0);
            pnlFiltros.Name = "pnlFiltros";
            pnlFiltros.Size = new Size(882, 60);
            pnlFiltros.TabIndex = 0;
            
            // btnExportar
     
            btnExportar.Location = new Point(747, 12);
            btnExportar.Name = "btnExportar";
            btnExportar.Size = new Size(94, 29);
            btnExportar.TabIndex = 6;
            btnExportar.Text = "Exportar";
            btnExportar.UseVisualStyleBackColor = true;
           
            // btnBuscar
            
            btnBuscar.Location = new Point(624, 12);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 5;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            
            // lblHasta
            // 
            lblHasta.AutoSize = true;
            lblHasta.Location = new Point(412, 4);
            lblHasta.Name = "lblHasta";
            lblHasta.Size = new Size(47, 20);
            lblHasta.TabIndex = 4;
            lblHasta.Text = "Hasta";
            lblHasta.Click += lblHasta_Click;
            
            // dtpHasta
            
            dtpHasta.Format = DateTimePickerFormat.Short;
            dtpHasta.Location = new Point(313, 27);
            dtpHasta.Name = "dtpHasta";
            dtpHasta.Size = new Size(250, 27);
            dtpHasta.TabIndex = 3;
            
            // dtpDesde
            
            dtpDesde.Format = DateTimePickerFormat.Short;
            dtpDesde.Location = new Point(21, 27);
            dtpDesde.Name = "dtpDesde";
            dtpDesde.Size = new Size(250, 27);
            dtpDesde.TabIndex = 2;
           
            // lblDesde
            
            lblDesde.AutoSize = true;
            lblDesde.Location = new Point(102, 4);
            lblDesde.Name = "lblDesde";
            lblDesde.Size = new Size(51, 20);
            lblDesde.TabIndex = 1;
            lblDesde.Text = "Desde";
            lblDesde.Click += lblDesde_Click;
            
            // lblResumen
            
            lblResumen.Dock = DockStyle.Bottom;
            lblResumen.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblResumen.Location = new Point(0, 483);
            lblResumen.Name = "lblResumen";
            lblResumen.Size = new Size(882, 30);
            lblResumen.TabIndex = 1;
            lblResumen.Text = "Resumen";
             
            // dgvReporte
            
            dgvReporte.AllowUserToAddRows = false;
            dgvReporte.AllowUserToDeleteRows = false;
            dgvReporte.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReporte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReporte.Dock = DockStyle.Fill;
            dgvReporte.Location = new Point(0, 60);
            dgvReporte.Name = "dgvReporte";
            dgvReporte.ReadOnly = true;
            dgvReporte.RowHeadersVisible = false;
            dgvReporte.RowHeadersWidth = 51;
            dgvReporte.Size = new Size(882, 423);
            dgvReporte.TabIndex = 2;
            
            // FmrReporteVentas
            
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(882, 513);
            Controls.Add(dgvReporte);
            Controls.Add(lblResumen);
            Controls.Add(pnlFiltros);
            Name = "FmrReporteVentas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ReporteVentas";
            pnlFiltros.ResumeLayout(false);
            pnlFiltros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReporte).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlFiltros;
        private DateTimePicker dtpDesde;
        private Label lblDesde;
        private Label lblHasta;
        private DateTimePicker dtpHasta;
        private Button btnBuscar;
        private Button btnExportar;
        private Label lblResumen;
        private DataGridView dgvReporte;
    }
}