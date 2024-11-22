using System;
using System.Windows.Forms;
using Refaccionaria.DAO;
using Refaccionaria.Models;

namespace Refaccionaria.Forms
{
    public partial class AgregarCamionForm : Form
    {
        public AgregarCamionForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear el objeto Camion con los datos ingresados
                Camion nuevoCamion = new Camion
                {
                    Nombre = txtNombre.Text,
                    TotalAlmacenaje = decimal.Parse(txtTotalAlmacenaje.Text),
                    Placas = txtPlacas.Text,
                    Marca = txtMarca.Text
                };

                // Llamar al método AgregarCamion
                CamionDAO camionDAO = new CamionDAO();
                camionDAO.AgregarCamion(nuevoCamion);

                MessageBox.Show("Camión agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Cierra el formulario después de guardar
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar el camión: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
