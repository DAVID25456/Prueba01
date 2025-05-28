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
    public partial class Usuario : Form
    {
        string email, contraseña;
        
        public Usuario()
        {
            InitializeComponent();
        }

        private void btn_inicio_s_Click(object sender, EventArgs e)
        {
            email = txt_email.Text;
            contraseña = txt_contraseña.Text;

            if (email.Equals("123"))
            {
                if (contraseña.Equals("123"))
                {
                    MessageBox.Show("OK");
                }
            }
        }
    }
}
