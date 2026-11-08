
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
    public partial class FrmProductos : Form
    {
        public FrmProductos()git config user.name "luisescobar123"
        {
            InitializeComponent();

            // Conectar los botones
            buttonNuevo.Click += buttonNuevo_Click;
            buttonGuardar.Click += buttonGuardar_Click;
            buttonActualizar.Click += buttonActualizar_Click;
            buttonEliminar.Click += buttonEliminar_Click;
            buttonBuscar.Click += buttonBuscar_Click;

            // Seleccionar productos desde la tabla
            dataGridViewProductos.CellClick += dataGridViewProductos_CellClick;

            // Cargar productos al abrir
            this.Load += FrmProductos_Load;
        }

        private void FrmProductos_Load(object sender, EventArgs e)
        {
            CargarProductos();
            LimpiarCampos();
        }

        // MOSTRAR PRODUCTOS
        private void CargarProductos()
        {
            try
            {
                using (var context = new LendromedeContext())
                {
                    var productos = context.Productos
                        .AsNoTracking()
                        .Select(p => new
                        {
                            p.IdProducto,
                            p.Nombre,
                            p.Aroma,
                            p.Tamano,
                            p.Precio,
                            p.Estado,
                            p.Stock
                        })
                        .ToList();

                    dataGridViewProductos.DataSource = productos;
                    if (dataGridViewProductos.Columns.Contains(nameof(Producto.IdProducto)))
                        dataGridViewProductos.Columns[nameof(Producto.IdProducto)].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los productos:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // LIMPIAR CAMPOS
        private void LimpiarCampos()
        {
            textProducto.Clear();
            textNombre.Clear();
            textAroma.Clear();
            textTamano.Clear();

            numericUpDownPrecio.Value = 0;
            numericUpDownStock.Value = 0;

            checkBoxEstado.Checked = true;

            dataGridViewProductos.ClearSelection();
            textNombre.Focus();
        }

        // BOTÓN NUEVO
        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        // BOTÓN GUARDAR
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Escribe el nombre del producto.");
                textNombre.Focus();
                return;
            }

            try
            {
                using (var context = new LendromedeContext())
                {
                    // Categoría predeterminada: Florales (ID 1)
                    bool existeCategoria = context.Categorias
                        .Any(c => c.IdCategoria == 1);

                    if (!existeCategoria)
                    {
                        MessageBox.Show(
                            "No existe la categoría predeterminada. Verifica que las categorías estén cargadas en la base de datos.");
                        return;
                    }

                    Producto producto = new Producto
                    {
                        Nombre = textNombre.Text.Trim(),
                        Aroma = textAroma.Text.Trim(),
                        Tamano = textTamano.Text.Trim(),
                        Precio = numericUpDownPrecio.Value,
                        Estado = checkBoxEstado.Checked,
                        Stock = Convert.ToInt32(numericUpDownStock.Value),
                        IdCategoria = 1
                    };

                    context.Productos.Add(producto);
                    context.SaveChanges();

                    MessageBox.Show(
                        "Producto guardado correctamente.",
                        "Éxito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo guardar el producto:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // SELECCIONAR UN PRODUCTO DE LA TABLA
        private void dataGridViewProductos_CellClick(
            object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var fila = dataGridViewProductos.Rows[e.RowIndex];

                textProducto.Text = fila.Cells["IdProducto"].Value.ToString();
                textNombre.Text = fila.Cells["Nombre"].Value.ToString();
                textAroma.Text = fila.Cells["Aroma"].Value?.ToString() ?? "";
                textTamano.Text = fila.Cells["Tamano"].Value?.ToString() ?? "";

                numericUpDownPrecio.Value =
                    Convert.ToDecimal(fila.Cells["Precio"].Value);

                checkBoxEstado.Checked =
                    Convert.ToBoolean(fila.Cells["Estado"].Value);

                numericUpDownStock.Value =
                    Convert.ToDecimal(fila.Cells["Stock"].Value);
            }
        }

        // BOTÓN ACTUALIZAR
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textProducto.Text, out int id))
            {
                MessageBox.Show("Selecciona un producto de la lista.");
                return;
            }

            try
            {
                using (var context = new LendromedeContext())
                {
                    var producto = context.Productos
                        .FirstOrDefault(p => p.IdProducto == id);

                    if (producto == null)
                    {
                        MessageBox.Show("No se encontró el producto.");
                        return;
                    }

                    producto.Nombre = textNombre.Text.Trim();
                    producto.Aroma = textAroma.Text.Trim();
                    producto.Tamano = textTamano.Text.Trim();
                    producto.Precio = numericUpDownPrecio.Value;
                    producto.Estado = checkBoxEstado.Checked;
                    producto.Stock = Convert.ToInt32(numericUpDownStock.Value);

                    context.SaveChanges();
                }

                MessageBox.Show("Producto actualizado correctamente.");

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo actualizar el producto:\n" + ex.Message);
            }
        }

        // BOTÓN ELIMINAR
        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(textProducto.Text, out int id))
            {
                MessageBox.Show("Selecciona un producto de la lista.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Estás seguro de eliminar este producto?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (var context = new LendromedeContext())
                {
                    var producto = context.Productos
                        .FirstOrDefault(p => p.IdProducto == id);

                    if (producto == null)
                    {
                        MessageBox.Show("No se encontró el producto.");
                        return;
                    }

                    context.Productos.Remove(producto);
                    context.SaveChanges();
                }

                MessageBox.Show("Producto eliminado correctamente.");

                CargarProductos();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo eliminar el producto. Puede estar relacionado con ventas o inventario.\n\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        // BOTÓN BUSCAR POR NOMBRE
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textNombre.Text))
            {
                MessageBox.Show("Escribe el nombre del producto que deseas buscar.");
                textNombre.Focus();
                return;
            }

            try
            {
                using (var context = new LendromedeContext())
                {
                    var producto = context.Productos
                        .AsNoTracking()
                        .FirstOrDefault(p =>
                            p.Nombre.Contains(textNombre.Text.Trim()));

                    if (producto == null)
                    {
                        MessageBox.Show("No se encontró el producto.");
                        return;
                    }

                    textProducto.Text = producto.IdProducto.ToString();
                    textNombre.Text = producto.Nombre;
                    textAroma.Text = producto.Aroma;
                    textTamano.Text = producto.Tamano;
                    numericUpDownPrecio.Value = producto.Precio;
                    checkBoxEstado.Checked = producto.Estado;
                    numericUpDownStock.Value = producto.Stock;

                    // Seleccionar el producto encontrado en la tabla
                    foreach (DataGridViewRow fila in dataGridViewProductos.Rows)
                    {
                        if (Convert.ToInt32(fila.Cells["IdProducto"].Value)
                            == producto.IdProducto)
                        {
                            fila.Selected = true;
                            dataGridViewProductos.CurrentCell =
                                fila.Cells["Nombre"];
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el producto:\n" + ex.Message);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}