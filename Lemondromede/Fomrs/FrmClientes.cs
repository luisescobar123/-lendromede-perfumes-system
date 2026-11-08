
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Lemondromede.Data;
using Lemondromede.Models;
using Microsoft.EntityFrameworkCore;

namespace Lemondromede.Fomrs
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();

            // Configuración de la tabla
            dataGridViewClientes.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewClientes.MultiSelect = false;
            dataGridViewClientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Conectar los botones
            buttonNuevo.Click += buttonNuevo_Click;
            buttonGuardar.Click += buttonGuardar_Click;
            buttonActualizar.Click += buttonActualizar_Click;
            buttonEliminar.Click += buttonEliminar_Click;
            buttonBuscar.Click += buttonBuscar_Click;
            buttonLimpiar.Click += buttonLimpiar_Click;

            // Detectar selección de la tabla
            dataGridViewClientes.SelectionChanged += dataGridViewClientes_SelectionChanged;

            CargarClientes();

            // Al abrir el formulario no debe quedar nada seleccionado
            Shown += (_, _) => LimpiarCampos();
            ActualizarEstadoBotones();
        }

        // true mientras se llena la tabla, para que la selección automática
        // de la primera fila no rellene los campos
        private bool _cargando;

        // Actualizar y Eliminar solo funcionan si hay un cliente seleccionado
        private void textIdCliente_TextChanged(object sender, EventArgs e)
        {
            ActualizarEstadoBotones();
        }

        private void ActualizarEstadoBotones()
        {
            bool haySeleccion = textIdCliente.Text.Length > 0;
            buttonActualizar.Enabled = haySeleccion;
            buttonEliminar.Enabled = haySeleccion;
        }

        // MOSTRAR CLIENTES
        private void CargarClientes(string filtro = "")
        {
            try
            {
                using (var context = new LendromedeContext())
                {
                    var consulta = context.Clientes.AsNoTracking().AsQueryable();

                    if (!string.IsNullOrWhiteSpace(filtro))
                    {
                        consulta = consulta.Where(c =>
                            c.Nombre.Contains(filtro) ||
                            c.Numero.Contains(filtro) ||
                            c.Correo.Contains(filtro));
                    }

                    var clientes = consulta
                        .OrderBy(c => c.IdCliente)
                        .ToList();

                    _cargando = true;
                    dataGridViewClientes.DataSource = clientes;
                    _cargando = false;

                    // Después de cargar no queda ninguna fila seleccionada
                    dataGridViewClientes.ClearSelection();
                    dataGridViewClientes.CurrentCell = null;
                    textIdCliente.Clear();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los clientes: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // NUEVO
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // GUARDAR
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Debes ingresar el nombre del cliente.");
                textNombre.Focus();
                return;
            }

            try
            {
                using (var context = new LendromedeContext())
                {
                    Cliente nuevoCliente = new Cliente
                    {
                        Nombre = textNombre.Text.Trim(),
                        Numero = textNumero.Text.Trim(),
                        Correo = textCorreo.Text.Trim(),
                        Direccion = textDireccion.Text.Trim()
                    };

                    context.Clientes.Add(nuevoCliente);
                    context.SaveChanges();
                }

                MessageBox.Show("Cliente guardado correctamente.");

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ACTUALIZAR
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textIdCliente.Text, out int id))
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Debes ingresar el nombre del cliente.");
                return;
            }

            try
            {
                using (var context = new LendromedeContext())
                {
                    var cliente = context.Clientes.Find(id);

                    if (cliente == null)
                    {
                        MessageBox.Show("No se encontró el cliente.");
                        return;
                    }

                    cliente.Nombre = textNombre.Text.Trim();
                    cliente.Numero = textNumero.Text.Trim();
                    cliente.Correo = textCorreo.Text.Trim();
                    cliente.Direccion = textDireccion.Text.Trim();

                    context.SaveChanges();
                }

                MessageBox.Show("Cliente actualizado correctamente.");

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al actualizar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // ELIMINAR
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textIdCliente.Text, out int id))
            {
                MessageBox.Show("Selecciona un cliente de la tabla.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás segura de que deseas eliminar este cliente?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (var context = new LendromedeContext())
                {
                    // Verificar si el cliente tiene ventas
                    bool tieneVentas = context.Set<Venta>()
                        .Any(v => v.IdCliente == id);

                    if (tieneVentas)
                    {
                        MessageBox.Show(
                            "No se puede eliminar este cliente porque tiene ventas registradas.",
                            "Operación no permitida",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);
                        return;
                    }

                    var cliente = context.Clientes.Find(id);

                    if (cliente == null)
                    {
                        MessageBox.Show("No se encontró el cliente.");
                        return;
                    }

                    context.Clientes.Remove(cliente);
                    context.SaveChanges();
                }

                MessageBox.Show("Cliente eliminado correctamente.");

                LimpiarCampos();
                CargarClientes();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al eliminar el cliente: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // BUSCAR
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string filtro = textNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(filtro))
            {
                MessageBox.Show("Escribe un nombre, número o correo en el campo Nombre para buscar.");
                return;
            }

            CargarClientes(filtro);
        }

        // SELECCIONAR CLIENTE DE LA TABLA
        private void dataGridViewClientes_SelectionChanged(object sender, EventArgs e)
        {
            if (_cargando)
                return;

            if (dataGridViewClientes.CurrentRow == null ||
                !dataGridViewClientes.CurrentRow.Selected ||
                dataGridViewClientes.CurrentRow.DataBoundItem is not Cliente cliente)
                return;

            textIdCliente.Text = cliente.IdCliente.ToString();
            textNombre.Text = cliente.Nombre;
            textNumero.Text = cliente.Numero;
            textCorreo.Text = cliente.Correo;
            textDireccion.Text = cliente.Direccion;
        }

        // LIMPIAR
        private void buttonLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            CargarClientes();
        }

        private void LimpiarCampos()
        {
            textIdCliente.Clear();
            textNombre.Clear();
            textNumero.Clear();
            textCorreo.Clear();
            textDireccion.Clear();

            dataGridViewClientes.ClearSelection();
            dataGridViewClientes.CurrentCell = null;
            textNombre.Focus();
        }
    }
}