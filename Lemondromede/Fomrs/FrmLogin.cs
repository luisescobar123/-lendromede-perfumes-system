using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Lemondromede.Services;

namespace Login.Forms
{
    public partial class FrmLogin : Form
    {
        private Label lblTitulo;
        private Label lblCorreo;
        private TextBox txtCorreo;
        private Label lblContrasena;
        private TextBox txtContrasena;
        private CheckBox chkMostrar;
        private Button btIngresar;
        private Button btCancelar;

        private readonly AuthService _auth;
        private int _intentos = 0;
        private PictureBox pctLogin;
        private const int MaxIntentos = 3;

        public FrmLogin()
        {
            InitializeComponent();
            Font = new Font("Segoe UI", 9f);
            _auth = new AuthService();

            btIngresar.Click += btIngresar_Click;
            chkMostrar.CheckedChanged += chkMostrar_CheckedChanged;

            pctLogin.Image = Image.FromFile(Path.Combine(Application.StartupPath, "Resources", "login.png"));
            pctLogin.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void InitializeComponent()
        {
            lblTitulo = new Label();
            lblCorreo = new Label();
            txtCorreo = new TextBox();
            lblContrasena = new Label();
            txtContrasena = new TextBox();
            chkMostrar = new CheckBox();
            btIngresar = new Button();
            btCancelar = new Button();
            pctLogin = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pctLogin).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitulo.Location = new Point(95, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(165, 32);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "Iniciar sesion";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // lblCorreo
            // 
            lblCorreo.AutoSize = true;
            lblCorreo.Location = new Point(30, 135);
            lblCorreo.Name = "lblCorreo";
            lblCorreo.Size = new Size(57, 20);
            lblCorreo.TabIndex = 1;
            lblCorreo.Text = "Correo:";
            // 
            // txtCorreo
            // 
            txtCorreo.Location = new Point(30, 158);
            txtCorreo.MaxLength = 100;
            txtCorreo.Name = "txtCorreo";
            txtCorreo.Size = new Size(280, 27);
            txtCorreo.TabIndex = 2;
            // 
            // lblContrasena
            // 
            lblContrasena.AutoSize = true;
            lblContrasena.Location = new Point(30, 200);
            lblContrasena.Name = "lblContrasena";
            lblContrasena.Size = new Size(86, 20);
            lblContrasena.TabIndex = 3;
            lblContrasena.Text = "Contrasena:";
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(30, 223);
            txtContrasena.MaxLength = 50;
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(280, 27);
            txtContrasena.TabIndex = 4;
            txtContrasena.UseSystemPasswordChar = true;
            // 
            // chkMostrar
            // 
            chkMostrar.AutoSize = true;
            chkMostrar.Location = new Point(30, 265);
            chkMostrar.Name = "chkMostrar";
            chkMostrar.Size = new Size(158, 24);
            chkMostrar.TabIndex = 5;
            chkMostrar.Text = "Mostrar contrasena";
            // 
            // btIngresar
            // 
            btIngresar.Location = new Point(30, 318);
            btIngresar.Name = "btIngresar";
            btIngresar.Size = new Size(135, 33);
            btIngresar.TabIndex = 6;
            btIngresar.Text = "Ingresar";
            btIngresar.UseVisualStyleBackColor = true;
            // 
            // btCancelar
            // 
            btCancelar.DialogResult = DialogResult.Cancel;
            btCancelar.Location = new Point(175, 318);
            btCancelar.Name = "btCancelar";
            btCancelar.Size = new Size(135, 33);
            btCancelar.TabIndex = 7;
            btCancelar.Text = "Cancelar";
            btCancelar.UseVisualStyleBackColor = true;
            // 
            // pctLogin
            // 
            pctLogin.Location = new Point(122, 55);
            pctLogin.Name = "pctLogin";
            pctLogin.Size = new Size(100, 50);
            pctLogin.TabIndex = 0;
            pctLogin.TabStop = false;
            // 
            // FrmLogin
            // 
            AcceptButton = btIngresar;
            BackColor = SystemColors.ButtonHighlight;
            CancelButton = btCancelar;
            ClientSize = new Size(340, 431);
            Controls.Add(pctLogin);
            Controls.Add(lblTitulo);
            Controls.Add(lblCorreo);
            Controls.Add(txtCorreo);
            Controls.Add(lblContrasena);
            Controls.Add(txtContrasena);
            Controls.Add(chkMostrar);
            Controls.Add(btIngresar);
            Controls.Add(btCancelar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            ImeMode = ImeMode.Disable;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Lendromede - Login";
            ((System.ComponentModel.ISupportInitialize)pctLogin).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private void chkMostrar_CheckedChanged(object? sender, EventArgs e)
        {
            txtContrasena.UseSystemPasswordChar = !chkMostrar.Checked;
        }

        private void btIngresar_Click(object? sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string contrasena = txtContrasena.Text;

            if (correo.Length == 0 || contrasena.Length == 0)
            {
                MessageBox.Show("Ingrese correo y contrasena.", "Validacion",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var usuario = _auth.Autenticar(correo, contrasena);

                if (usuario == null)
                {
                    _intentos++;
                    if (_intentos >= MaxIntentos)
                    {
                        MessageBox.Show("Demasiados intentos fallidos. La aplicacion se cerrara.",
                            "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        DialogResult = DialogResult.Cancel;
                        Close();
                        return;
                    }

                    MessageBox.Show(
                        $"Correo o contrasena incorrectos (o usuario inactivo). Intento {_intentos} de {MaxIntentos}.",
                        "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    txtContrasena.Clear();
                    txtContrasena.Focus();
                    return;
                }

                // Login correcto: se guarda el usuario y se cierra el login con OK
                Sesion.UsuarioActual = usuario;
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                // Por ejemplo: la base de datos no esta disponible
                MessageBox.Show("No se pudo validar el acceso: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }
    }
}
