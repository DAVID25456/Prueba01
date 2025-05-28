using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Usuario
{
    public partial class Informacion_personal : Form
    {
        public Informacion_personal()
        {
            InitializeComponent();
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            //Termina el proceso
            //Vuelve al formulario de inicio de sesion
            InicioSecion inicioSecion = new InicioSecion();
            //this.SuspendLayout();
            this.Hide();
            inicioSecion.Show();
        }
    }
}
