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

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            //Ir al formulario de datos personales
            Informacion_personal informacion_Personal = new Informacion_personal();
            //this.SuspendLayout();
            this.Hide();
            informacion_Personal.Show();
        }
    }
}
