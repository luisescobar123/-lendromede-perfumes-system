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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
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
            label10 = new Label();
            dataGridViewProductos = new DataGridView();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(238, 11);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(316, 69);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 32);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(150, 20);
            label2.TabIndex = 1;
            label2.Text = "Gestion de Productos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 12);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 0;
            label1.Text = "L'ENDROMEDE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(37, 122);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 1;
            label3.Text = "ID Producto";
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(398, 124);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
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
            label5.Size = new Size(54, 20);
            label5.TabIndex = 5;
            label5.Text = "Aroma";
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
            label6.Size = new Size(61, 20);
            label6.TabIndex = 7;
            label6.Text = "Tamaño";
            // 
            // textTamano
            // 
            textTamano.Location = new Point(474, 189);
            textTamano.Margin = new Padding(2);
            textTamano.Name = "textTamano";
            textTamano.Size = new Size(121, 27);
            textTamano.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(75, 253);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(50, 20);
            label7.TabIndex = 9;
            label7.Text = "Precio";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Location = new Point(156, 251);
            numericUpDownPrecio.Margin = new Padding(2);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(144, 27);
            numericUpDownPrecio.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(71, 317);
            label8.Margin = new Padding(2, 0, 2, 0);
            label8.Name = "label8";
            label8.Size = new Size(54, 20);
            label8.TabIndex = 11;
            label8.Text = "Estado";
            // 
            // checkBoxEstado
            // 
            checkBoxEstado.AutoSize = true;
            checkBoxEstado.Checked = true;
            checkBoxEstado.CheckState = CheckState.Checked;
            checkBoxEstado.Location = new Point(156, 317);
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
            label9.Size = new Size(45, 20);
            label9.TabIndex = 13;
            label9.Text = "Stock";
            // 
            // numericUpDownStock
            // 
            numericUpDownStock.Location = new Point(474, 253);
            numericUpDownStock.Margin = new Padding(2);
            numericUpDownStock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            numericUpDownStock.Name = "numericUpDownStock";
            numericUpDownStock.Size = new Size(144, 27);
            numericUpDownStock.TabIndex = 14;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(22, 490);
            label10.Margin = new Padding(2, 0, 2, 0);
            label10.Name = "label10";
            label10.Size = new Size(39, 20);
            label10.TabIndex = 15;
            label10.Text = "Lista";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(75, 412);
            dataGridViewProductos.Margin = new Padding(2);
            dataGridViewProductos.MultiSelect = false;
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersVisible = false;
            dataGridViewProductos.RowHeadersWidth = 62;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(792, 230);
            dataGridViewProductos.TabIndex = 16;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(71, 366);
            buttonNuevo.Margin = new Padding(2);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(90, 27);
            buttonNuevo.TabIndex = 17;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(201, 366);
            buttonGuardar.Margin = new Padding(2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(90, 27);
            buttonGuardar.TabIndex = 18;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(332, 366);
            buttonActualizar.Margin = new Padding(2);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(90, 27);
            buttonActualizar.TabIndex = 19;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(464, 366);
            buttonEliminar.Margin = new Padding(2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(90, 27);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(589, 366);
            buttonBuscar.Margin = new Padding(2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(90, 27);
            buttonBuscar.TabIndex = 21;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(878, 653);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(dataGridViewProductos);
            Controls.Add(label10);
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
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(2);
            Name = "FrmProductos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownStock).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
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
        private Label label10;
        private DataGridView dataGridViewProductos;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonActualizar;
        private Button buttonEliminar;
        private Button buttonBuscar;
    }
}