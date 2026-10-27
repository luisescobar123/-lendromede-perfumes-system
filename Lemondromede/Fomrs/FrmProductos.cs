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
        public FrmProductos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Validar los campos obligatorios
            if (string.IsNullOrWhiteSpace(textNombre.Text) ||
                string.IsNullOrWhiteSpace(textCodigo.Text) ||
                string.IsNullOrWhiteSpace(comboBoxMarca.Text) ||
                string.IsNullOrWhiteSpace(comboBoxGenero.Text))
            {
                MessageBox.Show(
                    "Completa el nombre, código, marca y género.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                using (var context = new LendromedeContext())
                {
                    // Comprobar si existen categorías registradas
                    bool existeCategoria = context.Categorias.Any();

                    if (!existeCategoria)
                    {
                        MessageBox.Show(
                            "No hay categorías registradas. " +
                            "Debemos preparar las categorías antes de guardar productos.",
                            "Falta una categoría",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning);

                        return;
                    }

                    MessageBox.Show(
                        "Validación correcta. Los campos están completos " +
                        "y existen categorías en la base de datos.",
                        "Validación exitosa",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo comprobar la base de datos:\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
    }
}
