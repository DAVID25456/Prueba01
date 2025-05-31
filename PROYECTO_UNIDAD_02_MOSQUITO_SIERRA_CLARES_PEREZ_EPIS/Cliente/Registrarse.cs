using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Clases;

namespace PROYECTO_UNIDAD_02_MOSQUITO_SIERRA_CLARES_PEREZ_EPIS.Cliente
{
    public partial class Registrarse : Form
    {
        //Instanciar la clase Usuario
        Usuario objusuario = new Usuario();

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
            //En la variable genero se guardara en string si es "M", "F" o null
            string genero = GeneroSelecionado();

            //Verificar si la contraseña es igual
            if (txtcontraseña.Text != txtconfirmar.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Finalizar ejecucion de la funcion
                return;
            }

            if(string.IsNullOrEmpty(txtnombre.Text) || string.IsNullOrEmpty(txtapellido.Text))
            {
                MessageBox.Show("Los campos obligatorios deben estar llenos");
                return;
            }

            var nuevousuario = new Usuario
            {
                Nombres = txtnombre.Text,
                Apellidos = txtapellido.Text,
                Email = txtemail.Text,
                Contraseña = txtcontraseña.Text,
                DNI = txtconfirmar.Text,
                Telefono = txttelefono.Text,
                FechaNacimiento = dtpnacimiento.Value,
                Genero = genero,

            };

            //Insertar nuevo usuario a la base de datos
            if (objusuario.IngresarDatos(nuevousuario))
            {
                MessageBox.Show("Registro exitoso");
            }
            else
            {

            }
        }

        public void Limpiarelementos()
        {
            txtnombre.Text = string.Empty;
            txtapellido.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtcontraseña.Text = string.Empty; 
            txtconfirmar.Text = string.Empty;
            txttelefono.Text = string.Empty;

        }

        private string GeneroSelecionado()
        {
            if (rbt_hombre.Checked)
            {
                return "M";
            }
            else if (rbt_hombre.Checked)
            {
                return "F";
            }
            else
            {
                //No se ha selecionado ningun RadioButton
                return null;
            }
        }
    }
}
