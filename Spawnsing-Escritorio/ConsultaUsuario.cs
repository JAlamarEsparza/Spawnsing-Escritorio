using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace Spawnsing_Escritorio
{
    

    public partial class ConsultaUsuario : Form
    {
        private string identificador;
        private string nombre;
        private string apellido;
        private string dni;
        private string entrada;
        private string salida;




        public ConsultaUsuario()
        {
            InitializeComponent();
        }

        IFirebaseConfig firebaseConf = new FirebaseConfig()
        {
            AuthSecret = "BY3dqAP0Ze3VS4gEEjqwbyiQKLJhq3zWprvJLHN0",
            BasePath = "https://spawnsign-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient cliente;



        private void ConsultaUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(firebaseConf);
            }
            catch
            {
                MessageBox.Show("No se puede conectar con la base de datos actualmente");
            }

            btnUsuario.Enabled = false;
        }


        #region Funcionalidad Botones

        private void btnTodos_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            var datos = cliente.Get("ListaTrabajadores");
            Dictionary<string, Trabajadores> datosTabajadores = datos.ResultAs<Dictionary<string, Trabajadores>>();

            foreach (var Trabajadores in datosTabajadores)
            {
                dataGridView1.Rows.Add(Trabajadores.Value.Identificador, Trabajadores.Value.Nombre, Trabajadores.Value.Apellido, Trabajadores.Value.DNI, Trabajadores.Value.Entrada, Trabajadores.Value.Salida);
            }

        }

        private void btnUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                dataGridView1.Rows.Clear();
                var datos = cliente.Get("ListaTrabajadores/" + txtBoxUsuario.Text);

                //Dictionary<string, Trabajadores> datosTabajadores = datos.ResultAs<Dictionary<string, Trabajadores>>();
                Trabajadores trabajador = datos.ResultAs<Trabajadores>();

                this.identificador = trabajador.Identificador;
                this.nombre = trabajador.Nombre;
                this.apellido = trabajador.Apellido;
                this.dni = trabajador.DNI;
                this.entrada = trabajador.Entrada;
                this.salida = trabajador.Salida;

                dataGridView1.Rows.Add(this.identificador, this.nombre, this.apellido, this.dni, this.entrada, this.salida);
            }
            catch
            {
                MessageBox.Show(" No existe el usuario");
            }
        }
        private void btnSalirConsulta_Click(object sender, EventArgs e)
        {
            Form CambiarFormulario = new Inicio();
            CambiarFormulario.Show();
            this.Close();
        }


        #endregion




        #region Comprobación errores

        private void controlDNI()
        {
            if (txtBoxUsuario.Text.Trim() != string.Empty && txtBoxUsuario.Text.All(Char.IsLetterOrDigit) && txtBoxUsuario.TextLength < 10 && txtBoxUsuario.TextLength > 8)
            {
                btnUsuario.Enabled = true;
                errorProviderDNI.SetError(txtBoxUsuario, "");
            }
            else
            {
                if (!(txtBoxUsuario.Text.All(Char.IsLetterOrDigit)))
                {
                    errorProviderDNI.SetError(txtBoxUsuario, "El Dni solo puede contener letras o Números (Longitud de 9 carácteres)");
                }
                else
                {
                    errorProviderDNI.SetError(txtBoxUsuario, "Debe introducir un DNI (Longitud de 9 carácteres)");
                }
                txtBoxUsuario.Focus();
                btnUsuario.Enabled = false;
            }
        }


        #endregion


        #region Cambios en los textos
        private void txtBoxUsuario_TextChanged(object sender, EventArgs e)
        {
            controlDNI();
        }

        #endregion
    }
}
 