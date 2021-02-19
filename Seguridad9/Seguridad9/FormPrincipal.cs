using System;
using System.Windows.Forms;
using Seguridad9.Clases;
using Seguridad9.Procedimiento;


namespace Seguridad9
{
    public partial class FormPrincipal : Form
    {
        public int validarErrorBDIU = 0;

        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void BtnCrearMandadoNuevo_Click(object sender, EventArgs e)
        {
            CrearMandado();
        }

        public void CrearMandado()
        {

            Mandado mandadito = new Mandado
            {
                Nombre = TxtProducto.Text,
                Cantidad = TxtCantidad.Text
            };

            SPHelper.InsertarMandado(mandadito);
        }

        public void errorUsuario(Boolean validar)
        {
            if (validar)
            {
                MessageBox.Show("Se ha insertado el mandado existosamente");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
