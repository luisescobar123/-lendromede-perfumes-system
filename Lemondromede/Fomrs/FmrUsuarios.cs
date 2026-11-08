using Lemondromede.Models;
using Lemondromede.Services;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace FmrUsuarioss.Forms
{
    public partial class FmrUsuarios : Form
    {
        private readonly UsuarioService _usuarioService = new();

        public FmrUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();

            // Al abrir el form no debe quedar nada seleccionado
            Shown += (_, _) => LimpiarFormulario();
            ActualizarEstadoBotones();
        }

        // Actualizar y Eliminar solo funcionan si hay un usuario seleccionado (txtId con valor)
        private void txtId_TextChanged(object? sender, EventArgs e)
        {
            ActualizarEstadoBotones();
        }

        private void ActualizarEstadoBotones()
        {
            bool haySeleccion = txtId.Text.Length > 0;
            btnActualizar.Enabled = haySeleccion;
            btnEliminar.Enabled = haySeleccion;
        }

        private void btnNuevo_Click(object? sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void CargarUsuarios(string? filtro = null)
        {
            dgvUsuarios.DataSource = _usuarioService.ObtenerUsuarios(filtro);
        }

        private void BuscarUsuarios(object? sender, EventArgs e)
        {
            CargarUsuarios(txtBusqueda.Text);
        }

        private void DgvUsuarios_SelectionChanged(object? sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null ||
                !dgvUsuarios.CurrentRow.Selected ||
                dgvUsuarios.CurrentRow.DataBoundItem is not Usuario usuario)
            {
                return;
            }

            txtId.Text = usuario.IdUsuario.ToString();
            txtNombre.Text = usuario.Nombre;
            txtCorreo.Text = usuario.Correo;
            txtContrasena.Clear();
            cmbRol.SelectedItem = usuario.Rol.Equals("ADMIN", StringComparison.OrdinalIgnoreCase)
                ? "Administrador"
                : usuario.Rol;
            chkEstado.Checked = usuario.Estado;
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
                CargarUsuarios(txtBusqueda.Text);
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
            if (!int.TryParse(txtId.Text, out var id))
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
                CargarUsuarios(txtBusqueda.Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Usuario no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarUsuarios(txtBusqueda.Text);
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
            if (!int.TryParse(txtId.Text, out var id))
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
                CargarUsuarios(txtBusqueda.Text);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message, "Usuario no disponible", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                CargarUsuarios(txtBusqueda.Text);
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
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                cmbRol.SelectedItem is null)
            {
                MessageBox.Show("Complete el nombre, correo y rol.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!System.Net.Mail.MailAddress.TryCreate(txtCorreo.Text.Trim(), out _))
            {
                MessageBox.Show("Ingrese un correo valido.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (requiereContrasena && string.IsNullOrWhiteSpace(txtContrasena.Text))
            {
                MessageBox.Show("La contrasena es obligatoria para crear un usuario.", "Validacion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (txtNombre.Text.Trim().Length > 100 ||
                txtCorreo.Text.Trim().Length > 100 ||
                txtContrasena.Text.Length > 50 ||
                (cmbRol.SelectedItem is string rolSeleccionado && rolSeleccionado.Length > 50))
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
                Nombre = txtNombre.Text.Trim(),
                Correo = txtCorreo.Text.Trim(),
                Contrasena = string.IsNullOrWhiteSpace(txtContrasena.Text) ? "" : AuthService.HashContrasena(txtContrasena.Text),
                Rol = cmbRol.SelectedItem?.ToString() ?? "",
                Estado = chkEstado.Checked,
            };
        }

        private void LimpiarFormulario()
        {
            txtId.Clear();
            txtNombre.Clear();
            txtCorreo.Clear();
            txtContrasena.Clear();
            cmbRol.SelectedItem = "Vendedor";
            chkEstado.Checked = true;
            dgvUsuarios.ClearSelection();
            dgvUsuarios.CurrentCell = null;
            txtNombre.Focus();
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
