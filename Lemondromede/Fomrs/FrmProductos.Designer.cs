namespace Lemondromede.Fomrs
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            label3 = new Label();
            textProducto = new TextBox();
            label4 = new Label();
            textNombre = new TextBox();
            label5 = new Label();
            textAroma = new TextBox();
            label6 = new Label();
            textTamano = new TextBox();
            label7 = new Label();
            numericUpDownPrecio = new NumericUpDown();
            label8 = new Label();
            checkBoxEstado = new CheckBox();
            label9 = new Label();
            numericUpDownStock = new NumericUpDown();
            dataGridViewProductos = new DataGridView();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            pnlProductos = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            grpProducto = new GroupBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            pnlProductos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(101, 124);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 20);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            label3.Click += label3_Click;
            // 
            // textProducto
            // 
            textProducto.Location = new Point(156, 122);
            textProducto.Margin = new Padding(2);
            textProducto.Name = "textProducto";
            textProducto.ReadOnly = true;
            textProducto.Size = new Size(121, 27);
            textProducto.TabIndex = 2;
            textProducto.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 124);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(474, 122);
            textNombre.Margin = new Padding(2);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(121, 27);
            textNombre.TabIndex = 4;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(71, 189);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(57, 20);
            label5.TabIndex = 5;
            label5.Text = "Aroma:";
            // 
            // textAroma
            // 
            textAroma.Location = new Point(156, 182);
            textAroma.Margin = new Padding(2);
            textAroma.Name = "textAroma";
            textAroma.Size = new Size(121, 27);
            textAroma.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(398, 189);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 7;
            label6.Text = "Tamaño:";
            // 
            // textTamano
            // 
            textTamano.Location = new Point(474, 189);
            textTamano.Margin = new Padding(2);
            textTamano.Name = "textTamano";
            textTamano.PlaceholderText = "Ej: 10.4cm";
            textTamano.Size = new Size(121, 27);
            textTamano.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 253);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(53, 20);
            label7.TabIndex = 9;
            label7.Text = "Precio:";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Location = new Point(156, 251);
            numericUpDownPrecio.Margin = new Padding(2);
            numericUpDownPrecio.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(144, 27);
            numericUpDownPrecio.TabIndex = 10;
            numericUpDownPrecio.ThousandsSeparator = true;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(72, 296);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(57, 20);
            label8.TabIndex = 11;
            label8.Text = "Estado:";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Checked = true;
            checkBoxEstado.CheckState = CheckState.Checked;
            checkBoxEstado.Location = new Point(157, 296);
            checkBoxEstado.Margin = new Padding(2);
            checkBoxEstado.Name = "checkBoxEstado";
            checkBoxEstado.Size = new Size(73, 24);
            checkBoxEstado.TabIndex = 12;
            checkBoxEstado.Text = "Activo";
            checkBoxEstado.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(398, 251);
            label9.Margin = new Padding(2, 0, 2, 0);
            label9.Name = "label9";
            label9.Size = new Size(48, 20);
            label9.TabIndex = 13;
            label9.Text = "Stock:";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(474, 253);
            numericUpDownStock.Margin = new Padding(2);
            numericUpDownStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(144, 27);
            numericUpDownStock.TabIndex = 14;
            numericUpDownStock.ThousandsSeparator = true;
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(11, 412);
            dataGridViewProductos.Margin = new Padding(2);
            dataGridViewProductos.MultiSelect = false;
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(856, 230);
            dataGridViewProductos.TabIndex = 16;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = Color.Purple;
            buttonNuevo.ForeColor = SystemColors.ButtonHighlight;
            buttonNuevo.Location = new Point(71, 345);
            buttonNuevo.Margin = new Padding(2);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(90, 27);
            buttonNuevo.TabIndex = 17;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.Purple;
            buttonGuardar.ForeColor = SystemColors.ButtonHighlight;
            buttonGuardar.Location = new Point(202, 345);
            buttonGuardar.Margin = new Padding(2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(90, 27);
            buttonGuardar.TabIndex = 18;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.Purple;
            buttonActualizar.Enabled = false;
            buttonActualizar.ForeColor = SystemColors.ButtonHighlight;
            buttonActualizar.Location = new Point(333, 345);
            buttonActualizar.Margin = new Padding(2);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(90, 27);
            buttonActualizar.TabIndex = 19;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Purple;
            buttonEliminar.Enabled = false;
            buttonEliminar.ForeColor = SystemColors.ButtonHighlight;
            buttonEliminar.Location = new Point(465, 345);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(90, 27);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Purple;
            buttonBuscar.ForeColor = SystemColors.ButtonHighlight;
            buttonBuscar.Location = new Point(590, 345);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(90, 27);
            buttonBuscar.TabIndex = 21;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // pnlProductos
            // 
            pnlProductos.BackColor = Color.FromArgb(50, 10, 80);
            pnlProductos.Controls.Add(pictureBox1);
            pnlProductos.Controls.Add(label1);
            pnlProductos.Location = new Point(-8, -6);
            pnlProductos.Name = "pnlProductos";
            pnlProductos.Size = new Size(887, 94);
            pnlProductos.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(340, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(214, 28);
            label1.TabIndex = 22;
            label1.Text = "Gestion de productos";
            // 
            // grpProducto
            // 
            grpProducto.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            grpProducto.Location = new Point(12, 94);
            grpProducto.Name = "grpProducto";
            grpProducto.Size = new Size(668, 246);
            grpProducto.TabIndex = 22;
            grpProducto.TabStop = false;
            grpProducto.Text = "Nuevo Producto:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(12, 387);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(194, 23);
            label2.TabIndex = 23;
            label2.Text = "Productos Registrados:";
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 653);
            Controls.Add(label2);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(pnlProductos);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(dataGridViewProductos);
            Controls.Add(numericUpDownStock);
            Controls.Add(label9);
            Controls.Add(checkBoxEstado);
            Controls.Add(label8);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(label7);
            Controls.Add(textTamano);
            Controls.Add(label6);
            Controls.Add(textAroma);
            Controls.Add(label5);
            Controls.Add(textNombre);
            Controls.Add(label4);
            Controls.Add(textProducto);
            Controls.Add(label3);
            Controls.Add(grpProducto);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmProductos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            pnlProductos.ResumeLayout(false);
            pnlProductos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label3;
        private TextBox textProducto;
        private Label label4;
        private TextBox textNombre;
        private Label label5;
        private TextBox textAroma;
        private Label label6;
        private TextBox textTamano;
        private Label label7;
        private NumericUpDown numericUpDownPrecio;
        private Label label8;
        private CheckBox checkBoxEstado;
        private Label label9;
        private NumericUpDown numericUpDownStock;
        private DataGridView dataGridViewProductos;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonActualizar;
        private Button buttonEliminar;
        private Button buttonBuscar;
        private Panel pnlProductos;
        private Label label1;
        private GroupBox grpProducto;
        private Label label2;
        private PictureBox pictureBox1;
    }
}