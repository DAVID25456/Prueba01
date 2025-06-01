using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Clases;

namespace PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Cliente
{
    public partial class InicioSecion : Form
    {
        //Instanciar la clase Usuario
        //Comentario para Marco
        //Comentario 02

        //Comentario Luis

        //Marco xD
        //Alfin lanchipa
        Usuario objusuario = new Usuario();
        
        public InicioSecion()
        {
            InitializeComponent();
            lb_aviso.Visible = false;
        }

        private void btn_registro_Click(object sender, EventArgs e)
        {
            //Salir del formulario actual e ir al formulario de registro
            Registrarse fmrregistrarse = new Registrarse();
            this.Hide();
            fmrregistrarse.Show();

        }

        private void btn_salir_Click(object sender, EventArgs e)
        {
            //Cerrar el programa
            Application.Exit();
        }

        private void btn_inicio_s_Click(object sender, EventArgs e)
        {
            //Verificar Si el Email existe en la base de datos
            //Verificar si la contraseña es correspondiente al email de la base de datos

            //TRIM: Quita los espacios finales e iniciales
            string email = txt_email.Text.Trim();
            string contraseña = txt_contraseña.Text;

            //Verificar si no esta vacio el TextBox Email
            if (string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Ingrese su Email", "Espacio en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificar si no esta vacio el TextBox contraseña
            if (string.IsNullOrEmpty(contraseña))
            {
                MessageBox.Show("Ingrese su Contraseña", "Espacio en blanco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //Verificar si el usuario existe
            if (objusuario.VerificarUsuario(email,contraseña))
            {
                MessageBox.Show("Bienvenido", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cuenta no existe", "Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
