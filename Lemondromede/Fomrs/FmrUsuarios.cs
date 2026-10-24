using System.Drawing;
using Lemondromede.Models;
using Lemondromede.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace forms_de_el_proyecto_wwwww.Forms
{
    public class FmrUsuarios : Form
    {
        private readonly UsuarioService _usuarioService = new();
        private readonly TextBox _txtId = new();
        private readonly TextBox _txtNombre = new();
        private readonly TextBox _txtCorreo = new();
        private readonly TextBox _txtContrasena = new();
        private readonly TextBox _txtRol = new();
        private readonly TextBox _txtBusqueda = new();
        private readonly CheckBox _chkEstado = new();
        private readonly DataGridView _dgvUsuarios = new();

        public FmrUsuarios()
        {
            Text = "Gestion de usuarios";
            StartPosition = FormStartPosition.CenterScreen;
            MinimumSize = new Size(800, 620);
            Size = new Size(980, 700);
            Font = new Font("Segoe UI", 9f);

            ConstruirInterfaz();
            CargarUsuarios();
        }

        private void ConstruirInterfaz()
        {
            var contenedor = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 1,
                RowCount = 3,
                Padding = new Padding(20),
            };
            contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 45));
            contenedor.RowStyles.Add(new RowStyle(SizeType.Absolute, 230));
            contenedor.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            var titulo = new Label
            {
                Text = "Administracion de usuarios",
                Dock = DockStyle.Fill,
                Font = new Font("Segoe UI", 16f, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleLeft,
            };
            contenedor.Controls.Add(titulo, 0, 0);
            contenedor.Controls.Add(CrearPanelDatos(), 0, 1);
            contenedor.Controls.Add(CrearPanelListado(), 0, 2);
            Controls.Add(contenedor);
        }

        private Control CrearPanelDatos()
        {
            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 4,
                RowCount = 4,
                Padding = new Padding(0, 8, 0, 8),
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 110));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50));
            for (var row = 0; row < 3; row++)
            {
                panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            }
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 58));

            _txtId.ReadOnly = true;
            _txtContrasena.UseSystemPasswordChar = true;
            _chkEstado.Text = "Usuario activo";
            _chkEstado.Checked = true;
            _txtRol.Text = "Vendedor";

            AgregarCampo(panel, "ID:", _txtId, 0, 0);
            AgregarCampo(panel, "Nombre:", _txtNombre, 1, 0);
            AgregarCampo(panel, "Correo:", _txtCorreo, 0, 1);
            AgregarCampo(panel, "Contrasena:", _txtContrasena, 1, 1);
            AgregarCampo(panel, "Rol:", _txtRol, 0, 2);
            panel.Controls.Add(_chkEstado, 2, 2);

            var acciones = new FlowLayoutPanel
            {
                Dock = DockStyle.Fill,
                FlowDirection = FlowDirection.LeftToRight,
                WrapContents = false,
            };
            acciones.Controls.Add(CrearBoton("Nuevo", (_, _) => LimpiarFormulario()));
            acciones.Controls.Add(CrearBoton("Guardar", GuardarUsuario));
            acciones.Controls.Add(CrearBoton("Actualizar", ActualizarUsuario));
            acciones.Controls.Add(CrearBoton("Eliminar", EliminarUsuario));
            panel.Controls.Add(acciones, 0, 3);
            panel.SetColumnSpan(acciones, 4);

            return panel;
        }

        private Control CrearPanelListado()
        {
            var panel = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
            };
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            panel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 120));
            panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 42));
            panel.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

            _txtBusqueda.PlaceholderText = "Buscar por nombre, correo o rol";
            var botonBuscar = CrearBoton("Buscar", BuscarUsuarios);
            botonBuscar.Dock = DockStyle.Fill;
            panel.Controls.Add(_txtBusqueda, 0, 0);
            panel.Controls.Add(botonBuscar, 1, 0);

            _dgvUsuarios.Dock = DockStyle.Fill;
            _dgvUsuarios.ReadOnly = true;
            _dgvUsuarios.AllowUserToAddRows = false;
            _dgvUsuarios.AllowUserToDeleteRows = false;
            _dgvUsuarios.AutoGenerateColumns = false;
            _dgvUsuarios.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            _dgvUsuarios.MultiSelect = false;
            _dgvUsuarios.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            _dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdUsuario",
                HeaderText = "ID",
                DataPropertyName = nameof(Usuario.IdUsuario),
                FillWeight = 40,
            });
            _dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Nombre",
                HeaderText = "Nombre",
                DataPropertyName = nameof(Usuario.Nombre),
            });
            _dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Correo",
                HeaderText = "Correo",
                DataPropertyName = nameof(Usuario.Correo),
            });
            _dgvUsuarios.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Rol",
                HeaderText = "Rol",
                DataPropertyName = nameof(Usuario.Rol),
            });
            _dgvUsuarios.Columns.Add(new DataGridViewCheckBoxColumn
            {
                Name = "Estado",
                HeaderText = "Activo",
                DataPropertyName = nameof(Usuario.Estado),
                FillWeight = 50,
            });
            _dgvUsuarios.SelectionChanged += DgvUsuarios_SelectionChanged;
            panel.Controls.Add(_dgvUsuarios, 0, 1);
            panel.SetColumnSpan(_dgvUsuarios, 2);

            return panel;
        }

        private static void AgregarCampo(
            TableLayoutPanel panel,
            string etiqueta,
            Control control,
            int fila,
            int columna)
        {
            panel.Controls.Add(new Label
            {
                Text = etiqueta,
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft,
            }, columna * 2, fila);
            control.Dock = DockStyle.Fill;
            panel.Controls.Add(control, columna * 2 + 1, fila);
        }

        private static Button CrearBoton(string texto, EventHandler accion)
        {
            var boton = new Button
            {
                Text = texto,
                AutoSize = true,
                MinimumSize = new Size(100, 34),
                Margin = new Padding(0, 4, 8, 4),
            };
            boton.Click += accion;
            return boton;
        }

        private void CargarUsuarios(string? filtro = null)
        {
            _dgvUsuarios.DataSource = _usuarioService.ObtenerUsuarios(filtro);
        }

        private void BuscarUsuarios(object? sender, EventArgs e)
        {
            CargarUsuarios(_txtBusqueda.Text);
        }

        private void DgvUsuarios_SelectionChanged(object? sender, EventArgs e)
        {
            if (_dgvUsuarios.SelectedRows.Count == 0 ||
                _dgvUsuarios.SelectedRows[0].DataBoundItem is not Usuario usuario)
            {
                return;
            }

            _txtId.Text = usuario.IdUsuario.ToString();
            _txtNombre.Text = usuario.Nombre;
            _txtCorreo.Text = usuario.Correo;
            _txtContrasena.Clear();
            _txtRol.Text = usuario.Rol;
            _chkEstado.Checked = usuario.Estado;
        }

        private void GuardarUsuario(object? sender, EventArgs e)
        {
            if (!ValidarFormulario(requiereContrasena: true))
            {
                return;
            }

            try
            {
                _usuarioService.CrearUsuario(ObtenerUsuarioFormulario());
                MessageBox.Show("Usuario guardado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios(_txtBusqueda.Text);
            }
            catch (DbUpdateException ex)
            {
                MostrarErrorBaseDatos(ex);
            }
            catch (SqlException ex)
            {
                MostrarErrorBaseDatos(ex);
            }
        }

        private void ActualizarUsuario(object? sender, EventArgs e)
        {
            if (!int.TryParse(_txtId.Text, out var id))
            {
                MessageBox.Show("Seleccione un usuario de la lista para actualizar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidarFormulario(requiereContrasena: false))
            {
                return;
            }

            var usuario = ObtenerUsuarioFormulario();
            usuario.IdUsuario = id;

            try
            {
                _usuarioService.ActualizarUsuario(usuario);
                MessageBox.Show("Usuario actualizado correctamente.", "Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LimpiarFormulario();
                CargarUsuarios(_txtBusqueda.Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Usuario no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarUsuarios(_txtBusqueda.Text);
            }
            catch (DbUpdateException ex)
            {
                MostrarErrorBaseDatos(ex);
            }
            catch (SqlException ex)
            {
                MostrarErrorBaseDatos(ex);
            }
        }

        private void EliminarUsuario(object? sender, EventArgs e)
        {
            if (!int.TryParse(_txtId.Text, out var id))
            {
                MessageBox.Show("Seleccione un usuario de la lista para eliminar.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var confirmacion = MessageBox.Show(
                "¿Esta seguro de que desea eliminar el usuario seleccionado?",
                "Confirmar eliminacion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (confirmacion != DialogResult.Yes)
            {
                return;
            }

            try
            {
                _usuarioService.EliminarUsuario(id);
                LimpiarFormulario();
                CargarUsuarios(_txtBusqueda.Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Usuario no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarUsuarios(_txtBusqueda.Text);
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(
                    $"No se pudo eliminar el usuario. Puede tener ventas o pedidos asociados.\n\n{ex.GetBaseException().Message}",
                    "Error al eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            catch (SqlException ex)
            {
                MostrarErrorBaseDatos(ex);
            }
        }

        private bool ValidarFormulario(bool requiereContrasena)
        {
            if (string.IsNullOrWhiteSpace(_txtNombre.Text) ||
                string.IsNullOrWhiteSpace(_txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(_txtRol.Text))
            {
                MessageBox.Show("Complete el nombre, correo y rol.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Net.Mail.MailAddress.TryCreate(_txtCorreo.Text.Trim(), out _))
            {
                MessageBox.Show("Ingrese un correo valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (requiereContrasena && string.IsNullOrWhiteSpace(_txtContrasena.Text))
            {
                MessageBox.Show("La contrasena es obligatoria para crear un usuario.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (_txtNombre.Text.Trim().Length > 100 ||
                _txtCorreo.Text.Trim().Length > 100 ||
                _txtContrasena.Text.Length > 50 ||
                _txtRol.Text.Trim().Length > 50)
            {
                MessageBox.Show("Revise la longitud de los campos. El nombre y correo admiten 100 caracteres; el rol y la contrasena, 50.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private Usuario ObtenerUsuarioFormulario()
        {
            return new Usuario
            {
                Nombre = _txtNombre.Text.Trim(),
                Correo = _txtCorreo.Text.Trim(),
                Contrasena = _txtContrasena.Text,
                Rol = _txtRol.Text.Trim(),
                Estado = _chkEstado.Checked,
            };
        }

        private void LimpiarFormulario()
        {
            _txtId.Clear();
            _txtNombre.Clear();
            _txtCorreo.Clear();
            _txtContrasena.Clear();
            _txtRol.Text = "Vendedor";
            _chkEstado.Checked = true;
            _dgvUsuarios.ClearSelection();
            _txtNombre.Focus();
        }

        private static void MostrarErrorBaseDatos(Exception ex)
        {
            MessageBox.Show(
                $"No se pudo completar la operacion en la base de datos.\n\n{ex.GetBaseException().Message}",
                "Error de base de datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
        }
    }
}
