
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
            dataGridViewClientes.ReadOnly = true;
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
            dataGridViewClientes.CellClick += dataGridViewClientes_CellClick;

            CargarClientes();
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
                        .Select(c => new
                        {
                            c.IdCliente,
                            c.Nombre,
                            c.Numero,
                            c.Correo,
                            c.Direccion
                        })
                        .ToList();

                    dataGridViewClientes.DataSource = clientes;
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
        private void dataGridViewClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            DataGridViewRow fila = dataGridViewClientes.Rows[e.RowIndex];

            textIdCliente.Text = fila.Cells["IdCliente"].Value?.ToString();
            textNombre.Text = fila.Cells["Nombre"].Value?.ToString();
            textNumero.Text = fila.Cells["Numero"].Value?.ToString();
            textCorreo.Text = fila.Cells["Correo"].Value?.ToString();
            textDireccion.Text = fila.Cells["Direccion"].Value?.ToString();
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
            textNombre.Focus();
        }
    }
}