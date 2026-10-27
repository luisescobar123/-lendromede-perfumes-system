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
            panel1 = new Panel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            textProducto = new TextBox();
            textCodigo = new TextBox();
            label4 = new Label();
            label5 = new Label();
            textNombre = new TextBox();
            label6 = new Label();
            comboBoxMarca = new ComboBox();
            label7 = new Label();
            comboBoxGenero = new ComboBox();
            label8 = new Label();
            numericUpDownTamano = new NumericUpDown();
            buttonAgregar = new Button();
            buttonNuevo = new Button();
            button1 = new Button();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            label15 = new Label();
            numericUpDownPrecio = new NumericUpDown();
            buttonGuardar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamano).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(282, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(325, 86);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 47);
            label2.Name = "label2";
            label2.Size = new Size(176, 25);
            label2.TabIndex = 1;
            label2.Text = "Tus aromas favoritas";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(92, 22);
            label1.Name = "label1";
            label1.Size = new Size(131, 25);
            label1.TabIndex = 0;
            label1.Text = "L'ENDROMEDE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 162);
            label3.Name = "label3";
            label3.Size = new Size(141, 25);
            label3.TabIndex = 1;
            label3.Text = "ID del Producto:";
            label3.Click += label3_Click;
            // 
            // textProducto
            // 
            textProducto.Location = new Point(200, 159);
            textProducto.Name = "textProducto";
            textProducto.Size = new Size(150, 31);
            textProducto.TabIndex = 2;
            // 
            // textCodigo
            // 
            textCodigo.Location = new Point(579, 153);
            textCodigo.Name = "textCodigo";
            textCodigo.Size = new Size(150, 31);
            textCodigo.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(452, 159);
            label4.Name = "label4";
            label4.Size = new Size(75, 25);
            label4.TabIndex = 4;
            label4.Text = "Código:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(9, 251);
            label5.Name = "label5";
            label5.Size = new Size(178, 25);
            label5.TabIndex = 5;
            label5.Text = "Nombre de la loción:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(231, 245);
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(150, 31);
            textNombre.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 338);
            label6.Name = "label6";
            label6.Size = new Size(64, 25);
            label6.TabIndex = 7;
            label6.Text = "Marca:";
            // 
            // comboBoxMarca
            // 
            comboBoxMarca.FormattingEnabled = true;
            comboBoxMarca.Location = new Point(136, 330);
            comboBoxMarca.Name = "comboBoxMarca";
            comboBoxMarca.Size = new Size(182, 33);
            comboBoxMarca.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 398);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 9;
            label7.Text = "Género:";
            // 
            // comboBoxGenero
            // 
            comboBoxGenero.FormattingEnabled = true;
            comboBoxGenero.Location = new Point(117, 390);
            comboBoxGenero.Name = "comboBoxGenero";
            comboBoxGenero.Size = new Size(182, 33);
            comboBoxGenero.TabIndex = 10;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(475, 248);
            label8.Name = "label8";
            label8.Size = new Size(113, 25);
            label8.TabIndex = 11;
            label8.Text = "Tamaño (ml):";
            // 
            // numericUpDownTamano
            // 
            numericUpDownTamano.Location = new Point(633, 242);
            numericUpDownTamano.Name = "numericUpDownTamano";
            numericUpDownTamano.Size = new Size(180, 31);
            numericUpDownTamano.TabIndex = 12;
            // 
            // buttonAgregar
            // 
            buttonAgregar.Location = new Point(117, 458);
            buttonAgregar.Name = "buttonAgregar";
            buttonAgregar.Size = new Size(112, 34);
            buttonAgregar.TabIndex = 14;
            buttonAgregar.Text = "Agregar";
            buttonAgregar.UseVisualStyleBackColor = true;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(334, 455);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(112, 34);
            buttonNuevo.TabIndex = 16;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(566, 463);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 18;
            button1.Text = "Actualizar";
            button1.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(793, 459);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 34);
            buttonEliminar.TabIndex = 20;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(998, 463);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(112, 34);
            buttonBuscar.TabIndex = 22;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(429, 316);
            label15.Name = "label15";
            label15.Size = new Size(60, 25);
            label15.TabIndex = 25;
            label15.Text = "Precio";
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.DecimalPlaces = 2;
            numericUpDownPrecio.Location = new Point(543, 314);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(180, 31);
            numericUpDownPrecio.TabIndex = 26;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(1218, 462);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(112, 34);
            buttonGuardar.TabIndex = 27;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            buttonGuardar.Click += buttonGuardar_Click;
            // 
            // FrmProductos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1342, 545);
            Controls.Add(buttonGuardar);
            Controls.Add(numericUpDownPrecio);
            Controls.Add(label15);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(button1);
            Controls.Add(buttonNuevo);
            Controls.Add(buttonAgregar);
            Controls.Add(numericUpDownTamano);
            Controls.Add(label8);
            Controls.Add(comboBoxGenero);
            Controls.Add(label7);
            Controls.Add(comboBoxMarca);
            Controls.Add(label6);
            Controls.Add(textNombre);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(textCodigo);
            Controls.Add(textProducto);
            Controls.Add(label3);
            Controls.Add(panel1);
            Name = "FrmProductos";
            Text = "Productos";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownTamano).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox textProducto;
        private TextBox textCodigo;
        private Label label4;
        private Label label5;
        private TextBox textNombre;
        private Label label6;
        private ComboBox comboBoxMarca;
        private Label label7;
        private ComboBox comboBoxGenero;
        private Label label8;
        private NumericUpDown numericUpDownTamano;
        private Button buttonAgregar;
        private Button buttonNuevo;
        private Button button1;
        private Button buttonEliminar;
        private Button buttonBuscar;
        private Label label15;
        private NumericUpDown numericUpDownPrecio;
        private Button buttonGuardar;
    }
}