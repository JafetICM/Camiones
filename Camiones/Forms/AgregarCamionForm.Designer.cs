
namespace Refaccionaria.Forms
{
    partial class AgregarCamionForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTotalAlmacenaje;
        private System.Windows.Forms.Label lblPlacas;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtTotalAlmacenaje;
        private System.Windows.Forms.TextBox txtPlacas;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Button btnGuardar;

        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTotalAlmacenaje = new System.Windows.Forms.Label();
            this.lblPlacas = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtTotalAlmacenaje = new System.Windows.Forms.TextBox();
            this.txtPlacas = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.Text = "Nombre:";
            this.lblNombre.Location = new System.Drawing.Point(12, 9);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(120, 6);
            // 
            // lblTotalAlmacenaje
            // 
            this.lblTotalAlmacenaje.Text = "Total Almacenaje:";
            this.lblTotalAlmacenaje.Location = new System.Drawing.Point(12, 40);
            // 
            // txtTotalAlmacenaje
            // 
            this.txtTotalAlmacenaje.Location = new System.Drawing.Point(120, 37);
            // 
            // lblPlacas
            // 
            this.lblPlacas.Text = "Placas:";
            this.lblPlacas.Location = new System.Drawing.Point(12, 71);
            // 
            // txtPlacas
            // 
            this.txtPlacas.Location = new System.Drawing.Point(120, 68);
            // 
            // lblMarca
            // 
            this.lblMarca.Text = "Marca:";
            this.lblMarca.Location = new System.Drawing.Point(12, 102);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(120, 99);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Location = new System.Drawing.Point(120, 140);
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // AgregarCamionForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 181);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTotalAlmacenaje);
            this.Controls.Add(this.txtTotalAlmacenaje);
            this.Controls.Add(this.lblPlacas);
            this.Controls.Add(this.txtPlacas);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.btnGuardar);
            this.Name = "AgregarCamionForm";
            this.Text = "Agregar Camión";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
