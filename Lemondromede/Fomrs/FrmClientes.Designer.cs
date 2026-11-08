namespace Lemondromede.Fomrs
{
    partial class FrmClientes
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
            labelNombre = new Label();
            textIdCliente = new TextBox();
            textNombre = new TextBox();
            labelNumero = new Label();
            textNumero = new TextBox();
            labelCorreo = new Label();
            textCorreo = new TextBox();
            labelDireccion = new Label();
            textDireccion = new TextBox();
            buttonNuevo = new Button();
            buttonGuardar = new Button();
            buttonActualizar = new Button();
            buttonEliminar = new Button();
            buttonBuscar = new Button();
            buttonLimpiar = new Button();
            dataGridViewClientes = new DataGridView();
            ColNombre = new DataGridViewTextBoxColumn();
            ColNumero = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColDirección = new DataGridViewTextBoxColumn();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textIdCliente (oculto: solo guarda el id del cliente seleccionado)
            // 
            textIdCliente.Location = new Point(750, 83);
            textIdCliente.Name = "textIdCliente";
            textIdCliente.ReadOnly = true;
            textIdCliente.Size = new Size(60, 27);
            textIdCliente.TabIndex = 1;
            textIdCliente.TabStop = false;
            textIdCliente.Visible = false;
            textIdCliente.TextChanged += textIdCliente_TextChanged;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(29, 83);
            labelNombre.Margin = new Padding(2, 0, 2, 0);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(67, 20);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(110, 83);
            textNombre.Margin = new Padding(2, 2, 2, 2);
            textNombre.MaxLength = 100;
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(234, 27);
            textNombre.TabIndex = 3;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(368, 90);
            labelNumero.Margin = new Padding(2, 0, 2, 0);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(147, 20);
            labelNumero.TabIndex = 4;
            labelNumero.Text = "Número de teléfono:";
            // 
            // textNumero
            // 
            textNumero.Location = new Point(519, 87);
            textNumero.Margin = new Padding(2, 2, 2, 2);
            textNumero.MaxLength = 15;
            textNumero.Name = "textNumero";
            textNumero.PlaceholderText = "Ej: 2222-7777";
            textNumero.Size = new Size(201, 27);
            textNumero.TabIndex = 5;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(368, 133);
            labelCorreo.Margin = new Padding(2, 0, 2, 0);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(135, 20);
            labelCorreo.TabIndex = 6;
            labelCorreo.Text = "Correo Electrónico:";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(519, 130);
            textCorreo.Margin = new Padding(2, 2, 2, 2);
            textCorreo.MaxLength = 256;
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(201, 27);
            textCorreo.TabIndex = 7;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(22, 133);
            labelDireccion.Margin = new Padding(2, 0, 2, 0);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(75, 20);
            labelDireccion.TabIndex = 8;
            labelDireccion.Text = "Dirección:";
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(101, 130);
            textDireccion.Margin = new Padding(2, 2, 2, 2);
            textDireccion.MaxLength = 200;
            textDireccion.Multiline = true;
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(243, 89);
            textDireccion.TabIndex = 9;
            // 
            // buttonNuevo
            // 
            buttonNuevo.BackColor = Color.Purple;
            buttonNuevo.ForeColor = SystemColors.ButtonHighlight;
            buttonNuevo.Location = new Point(7, 266);
            buttonNuevo.Margin = new Padding(2, 2, 2, 2);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(80, 28);
            buttonNuevo.TabIndex = 10;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = false;
            // 
            // buttonGuardar
            // 
            buttonGuardar.BackColor = Color.Purple;
            buttonGuardar.ForeColor = SystemColors.ButtonHighlight;
            buttonGuardar.Location = new Point(110, 265);
            buttonGuardar.Margin = new Padding(2, 2, 2, 2);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(80, 28);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = false;
            // 
            // buttonActualizar
            // 
            buttonActualizar.BackColor = Color.Purple;
            buttonActualizar.ForeColor = SystemColors.ButtonHighlight;
            buttonActualizar.Location = new Point(206, 266);
            buttonActualizar.Margin = new Padding(2, 2, 2, 2);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(80, 28);
            buttonActualizar.TabIndex = 12;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = false;
            // 
            // buttonEliminar
            // 
            buttonEliminar.BackColor = Color.Purple;
            buttonEliminar.ForeColor = SystemColors.ButtonHighlight;
            buttonEliminar.Location = new Point(308, 266);
            buttonEliminar.Margin = new Padding(2, 2, 2, 2);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(90, 27);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = false;
            // 
            // buttonBuscar
            // 
            buttonBuscar.BackColor = Color.Purple;
            buttonBuscar.ForeColor = SystemColors.ButtonHighlight;
            buttonBuscar.Location = new Point(426, 266);
            buttonBuscar.Margin = new Padding(2, 2, 2, 2);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(90, 27);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = false;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.BackColor = Color.Purple;
            buttonLimpiar.ForeColor = SystemColors.ButtonHighlight;
            buttonLimpiar.Location = new Point(546, 266);
            buttonLimpiar.Margin = new Padding(2, 2, 2, 2);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(90, 27);
            buttonLimpiar.TabIndex = 15;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = false;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColNombre, ColNumero, ColCorreo, ColDirección });
            dataGridViewClientes.Location = new Point(7, 315);
            dataGridViewClientes.Margin = new Padding(2, 2, 2, 2);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.ReadOnly = true;
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(844, 176);
            dataGridViewClientes.TabIndex = 16;
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNombre.DataPropertyName = "Nombre";
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 8;
            ColNombre.Name = "ColNombre";
            ColNombre.ReadOnly = true;
            // 
            // ColNumero
            // 
            ColNumero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNumero.DataPropertyName = "Numero";
            ColNumero.HeaderText = "Número de teléfono";
            ColNumero.MinimumWidth = 8;
            ColNumero.Name = "ColNumero";
            ColNumero.ReadOnly = true;
            // 
            // ColCorreo
            // 
            ColCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCorreo.DataPropertyName = "Correo";
            ColCorreo.HeaderText = "Correo electrónico";
            ColCorreo.MinimumWidth = 8;
            ColCorreo.Name = "ColCorreo";
            ColCorreo.ReadOnly = true;
            // 
            // ColDirección
            // 
            ColDirección.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDirección.DataPropertyName = "Direccion";
            ColDirección.HeaderText = "Dirección";
            ColDirección.MinimumWidth = 8;
            ColDirección.Name = "ColDirección";
            ColDirección.ReadOnly = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(50, 10, 80);
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(332, 18);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(194, 28);
            label1.TabIndex = 17;
            label1.Text = "Gestion de Clientes";
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 10, 80);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 65);
            panel1.TabIndex = 18;
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(862, 515);
            Controls.Add(dataGridViewClientes);
            Controls.Add(buttonLimpiar);
            Controls.Add(buttonBuscar);
            Controls.Add(buttonEliminar);
            Controls.Add(buttonActualizar);
            Controls.Add(buttonGuardar);
            Controls.Add(buttonNuevo);
            Controls.Add(textDireccion);
            Controls.Add(labelDireccion);
            Controls.Add(textCorreo);
            Controls.Add(labelCorreo);
            Controls.Add(textNumero);
            Controls.Add(labelNumero);
            Controls.Add(textNombre);
            Controls.Add(textIdCliente);
            Controls.Add(labelNombre);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(2, 2, 2, 2);
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelNombre;
        private TextBox textIdCliente;
        private TextBox textNombre;
        private Label labelNumero;
        private TextBox textNumero;
        private Label labelCorreo;
        private TextBox textCorreo;
        private Label labelDireccion;
        private TextBox textDireccion;
        private Button buttonNuevo;
        private Button buttonGuardar;
        private Button buttonActualizar;
        private Button buttonEliminar;
        private Button buttonBuscar;
        private Button buttonLimpiar;
        private DataGridView dataGridViewClientes;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColNumero;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColDirección;
        private Label label1;
        private Panel panel1;
    }
}