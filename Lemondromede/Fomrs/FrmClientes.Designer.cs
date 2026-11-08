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
            labelIdCliente = new Label();
            textIdCliente = new TextBox();
            labelNombre = new Label();
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
            ColIdCliente = new DataGridViewTextBoxColumn();
            ColNombre = new DataGridViewTextBoxColumn();
            ColNumero = new DataGridViewTextBoxColumn();
            ColCorreo = new DataGridViewTextBoxColumn();
            ColDirección = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // labelIdCliente
            // 
            labelIdCliente.AutoSize = true;
            labelIdCliente.Location = new Point(17, 26);
            labelIdCliente.Name = "labelIdCliente";
            labelIdCliente.Size = new Size(92, 25);
            labelIdCliente.TabIndex = 0;
            labelIdCliente.Text = "ID Cliente:";
            // 
            // textIdCliente
            // 
            textIdCliente.Location = new Point(158, 26);
            textIdCliente.Name = "textIdCliente";
            textIdCliente.ReadOnly = true;
            textIdCliente.Size = new Size(200, 31);
            textIdCliente.TabIndex = 1;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(17, 80);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(82, 25);
            labelNombre.TabIndex = 2;
            labelNombre.Text = "Nombre:";
            // 
            // textNombre
            // 
            textNombre.Location = new Point(148, 80);
            textNombre.MaxLength = 100;
            textNombre.Name = "textNombre";
            textNombre.Size = new Size(250, 31);
            textNombre.TabIndex = 3;
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Location = new Point(12, 157);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(177, 25);
            labelNumero.TabIndex = 4;
            labelNumero.Text = "Número de teléfono:";
            // 
            // textNumero
            // 
            textNumero.Location = new Point(236, 157);
            textNumero.MaxLength = 15;
            textNumero.Name = "textNumero";
            textNumero.Size = new Size(250, 31);
            textNumero.TabIndex = 5;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(17, 220);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(161, 25);
            labelCorreo.TabIndex = 6;
            labelCorreo.Text = "Correo Electrónico:";
            // 
            // textCorreo
            // 
            textCorreo.Location = new Point(236, 220);
            textCorreo.MaxLength = 256;
            textCorreo.Name = "textCorreo";
            textCorreo.Size = new Size(250, 31);
            textCorreo.TabIndex = 7;
            // 
            // labelDireccion
            // 
            labelDireccion.AutoSize = true;
            labelDireccion.Location = new Point(20, 282);
            labelDireccion.Name = "labelDireccion";
            labelDireccion.Size = new Size(89, 25);
            labelDireccion.TabIndex = 8;
            labelDireccion.Text = "Dirección:";
            // 
            // textDireccion
            // 
            textDireccion.Location = new Point(182, 269);
            textDireccion.MaxLength = 200;
            textDireccion.Multiline = true;
            textDireccion.Name = "textDireccion";
            textDireccion.Size = new Size(400, 50);
            textDireccion.TabIndex = 9;
            // 
            // buttonNuevo
            // 
            buttonNuevo.Location = new Point(9, 332);
            buttonNuevo.Name = "buttonNuevo";
            buttonNuevo.Size = new Size(100, 35);
            buttonNuevo.TabIndex = 10;
            buttonNuevo.Text = "Nuevo";
            buttonNuevo.UseVisualStyleBackColor = true;
            // 
            // buttonGuardar
            // 
            buttonGuardar.Location = new Point(138, 331);
            buttonGuardar.Name = "buttonGuardar";
            buttonGuardar.Size = new Size(100, 35);
            buttonGuardar.TabIndex = 11;
            buttonGuardar.Text = "Guardar";
            buttonGuardar.UseVisualStyleBackColor = true;
            // 
            // buttonActualizar
            // 
            buttonActualizar.Location = new Point(258, 332);
            buttonActualizar.Name = "buttonActualizar";
            buttonActualizar.Size = new Size(100, 35);
            buttonActualizar.TabIndex = 12;
            buttonActualizar.Text = "Actualizar";
            buttonActualizar.UseVisualStyleBackColor = true;
            // 
            // buttonEliminar
            // 
            buttonEliminar.Location = new Point(385, 332);
            buttonEliminar.Name = "buttonEliminar";
            buttonEliminar.Size = new Size(112, 34);
            buttonEliminar.TabIndex = 13;
            buttonEliminar.Text = "Eliminar";
            buttonEliminar.UseVisualStyleBackColor = true;
            // 
            // buttonBuscar
            // 
            buttonBuscar.Location = new Point(532, 332);
            buttonBuscar.Name = "buttonBuscar";
            buttonBuscar.Size = new Size(112, 34);
            buttonBuscar.TabIndex = 14;
            buttonBuscar.Text = "Buscar";
            buttonBuscar.UseVisualStyleBackColor = true;
            // 
            // buttonLimpiar
            // 
            buttonLimpiar.Location = new Point(683, 332);
            buttonLimpiar.Name = "buttonLimpiar";
            buttonLimpiar.Size = new Size(112, 34);
            buttonLimpiar.TabIndex = 15;
            buttonLimpiar.Text = "Limpiar";
            buttonLimpiar.UseVisualStyleBackColor = true;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.AllowUserToAddRows = false;
            dataGridViewClientes.AllowUserToDeleteRows = false;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewClientes.BorderStyle = BorderStyle.Fixed3D;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { ColIdCliente, ColNombre, ColNumero, ColCorreo, ColDirección });
            dataGridViewClientes.Location = new Point(0, 394);
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersVisible = false;
            dataGridViewClientes.RowHeadersWidth = 62;
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.Size = new Size(1000, 220);
            dataGridViewClientes.TabIndex = 16;
            // 
            // ColIdCliente
            // 
            ColIdCliente.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColIdCliente.HeaderText = "ID Cliente";
            ColIdCliente.MinimumWidth = 8;
            ColIdCliente.Name = "ColIdCliente";
            // 
            // ColNombre
            // 
            ColNombre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNombre.HeaderText = "Nombre";
            ColNombre.MinimumWidth = 8;
            ColNombre.Name = "ColNombre";
            // 
            // ColNumero
            // 
            ColNumero.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColNumero.HeaderText = "Número de teléfono";
            ColNumero.MinimumWidth = 8;
            ColNumero.Name = "ColNumero";
            // 
            // ColCorreo
            // 
            ColCorreo.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColCorreo.HeaderText = "Correo electrónico";
            ColCorreo.MinimumWidth = 8;
            ColCorreo.Name = "ColCorreo";
            // 
            // ColDirección
            // 
            ColDirección.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ColDirección.HeaderText = "Dirección";
            ColDirección.MinimumWidth = 8;
            ColDirección.Name = "ColDirección";
            // 
            // FrmClientes
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1078, 644);
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
            Controls.Add(labelNombre);
            Controls.Add(textIdCliente);
            Controls.Add(labelIdCliente);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FrmClientes";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gestión de Clientes";
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelIdCliente;
        private TextBox textIdCliente;
        private Label labelNombre;
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
        private DataGridViewTextBoxColumn ColIdCliente;
        private DataGridViewTextBoxColumn ColNombre;
        private DataGridViewTextBoxColumn ColNumero;
        private DataGridViewTextBoxColumn ColCorreo;
        private DataGridViewTextBoxColumn ColDirección;
    }
}