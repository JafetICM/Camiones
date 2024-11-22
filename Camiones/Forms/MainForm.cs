using System;
using System.Windows.Forms;
using Refaccionaria.DAO;
using Refaccionaria.Services;

namespace Refaccionaria.Forms
{
    public partial class MainForm : Form
    {
        private ServicioCamiones servicioCamiones;

        public MainForm()
        {
            InitializeComponent();
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                CamionDAO camionDAO = new CamionDAO();
                var camiones = camionDAO.ObtenerCamiones(); // Llama correctamente al método
                servicioCamiones = new ServicioCamiones(camiones);
                dataGridViewCamiones.DataSource = camiones; // Muestra los datos en el DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            AgregarCamionForm agregarForm = new AgregarCamionForm();
            agregarForm.ShowDialog(); // Abre el formulario para agregar un camión
            CargarDatos(); // Recarga los datos después de agregar
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string criterio = txtBuscar.Text; // Obtener el texto del TextBox
                var resultados = servicioCamiones.BuscarPorNombre(criterio); // Filtrar por nombre
                dataGridViewCamiones.DataSource = resultados; // Mostrar los resultados
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
