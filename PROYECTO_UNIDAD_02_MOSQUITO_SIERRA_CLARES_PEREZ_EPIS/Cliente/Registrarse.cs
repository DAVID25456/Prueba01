using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Clases;

namespace PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Cliente
{
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            //Volver al formulario de inicio de sesion
            InicioSecion inicioSecion = new InicioSecion();
            //this.SuspendLayout();
            this.Hide();
            inicioSecion.Show();
        }

        private void btn_registrarse_Click(object sender, EventArgs e)
        {

        }
    }
}
