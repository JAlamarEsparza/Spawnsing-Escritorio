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
    public partial class AgregarUsuario : Form
    {


        private bool identificador;
        private bool nombre;
        private bool apellido;
        private bool dni;
        private bool entrada;
        private bool salida;
        private bool existe = false;
        private string identificador1;
        private string nombre1;
        private string apellido1;
        private string dni1;
        private string entrada1;
        private string salida1;


        public AgregarUsuario()
        {
            InitializeComponent();

        }

        IFirebaseConfig firebaseConf = new FirebaseConfig()
        {
            AuthSecret = "BY3dqAP0Ze3VS4gEEjqwbyiQKLJhq3zWprvJLHN0",
            BasePath = "https://spawnsign-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient cliente;


        private void AgregarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(firebaseConf);
            }
            catch
            {
                MessageBox.Show("No se puede conectar con la base de datos actualmente");
            }


            btnAgregar.Enabled = false;

        }


        #region cambio en los textos
        private void txtBoxIdentificador_TextChanged(object sender, EventArgs e)
        {
            controlIdentificador();
        }
        private void txtBoxNombre_TextChanged(object sender, EventArgs e)
        {
            controlNombre(); 
        }
        private void txtBoxApellido_TextChanged(object sender, EventArgs e)
        {
            controlApellido();
            
        }
        private void txtBoxDNI_TextChanged(object sender, EventArgs e)
        {
            controlDNI();
            
        }
        private void txtBoxEntrada_TextChanged(object sender, EventArgs e)
        {
            controlEntrada();
            
        }
        private void txtBoxSalida_TextChanged(object sender, EventArgs e)
        {
            controlSalida();
            
        }
        #endregion


        #region Comprobacion errores

        private void controlIdentificador()
        {
            if (txtBoxIdentificador.Text.Trim() != string.Empty && txtBoxIdentificador.Text.All(Char.IsNumber))
            {
                identificador = true;
                errorProviderIdentificador.SetError(txtBoxIdentificador, "");
            }
            else
            {
                if (!(txtBoxIdentificador.Text.All(Char.IsNumber)))
                {
                    errorProviderIdentificador.SetError(txtBoxIdentificador, "El identificador solo debe contener números");
                }
                else
                {
                    errorProviderIdentificador.SetError(txtBoxIdentificador, "Debe introducir un identificador");
                }
                txtBoxIdentificador.Focus();

            }
        }

        private void controlNombre()
        {
            if (txtBoxNombre.Text.Trim() != string.Empty && txtBoxNombre.Text.All(Char.IsLetter))
            {
                nombre = true;
                errorProviderNombre.SetError(txtBoxNombre, "");
            }
            else
            {
                if (!(txtBoxNombre.Text.All(Char.IsLetter)))
                {
                    errorProviderNombre.SetError(txtBoxNombre, "El nombre solo debe contener letras");
                }
                else
                {
                    errorProviderNombre.SetError(txtBoxNombre, "Debe introducir un nombre");
                }
                txtBoxNombre.Focus();
            }
        }

        private void controlApellido()
        {
            if (txtBoxApellido.Text.Trim() != string.Empty && txtBoxApellido.Text.All(Char.IsLetter))
            {
                apellido = true;
                errorProviderApellido.SetError(txtBoxApellido, "");
            }
            else
            {
                if (!(txtBoxApellido.Text.All(Char.IsLetter)))
                {
                    errorProviderApellido.SetError(txtBoxApellido, "El apellido solo debe contener letras");
                }
                else
                {
                    errorProviderApellido.SetError(txtBoxApellido, "Debe introducir un apellido");
                }
                txtBoxApellido.Focus();
            }
        }

        private void controlDNI()
        {
            if (txtBoxDNI.Text.Trim() != string.Empty && txtBoxDNI.Text.All(Char.IsLetterOrDigit) && txtBoxDNI.TextLength < 10 && txtBoxDNI.TextLength > 8)
            {
                dni = true;
                errorProviderDNI.SetError(txtBoxDNI, "");
            }
            else
            {
                if (!(txtBoxDNI.Text.All(Char.IsLetterOrDigit)))
                {
                    errorProviderDNI.SetError(txtBoxDNI, "El Dni solo puede contener letras o Números (Longitud de 9 carácteres)");
                }
                else
                {
                    errorProviderDNI.SetError(txtBoxDNI, "Debe introducir un DNI (Longitud de 9 carácteres)");
                }
                txtBoxDNI.Focus();
            }
        }

        private void controlEntrada()
        {
            if (txtBoxEntrada.Text.Trim() != string.Empty && txtBoxEntrada.Text.All(Char.IsNumber) && txtBoxEntrada.TextLength <5)
            {
                entrada = true;
                errorProviderEntrada.SetError(txtBoxEntrada, "");
            }
            else
            {
                if (!(txtBoxEntrada.Text.All(Char.IsNumber)))
                {
                    errorProviderEntrada.SetError(txtBoxEntrada, "La entrada solo debe contener 4 números ejemplo: (08 40)");
                }
                else
                {
                    errorProviderEntrada.SetError(txtBoxEntrada, "Debe introducir una entrada debe contener 4 números ejemplo: (08 40)");
                }
                txtBoxEntrada.Focus();

            }
        }

        private void controlSalida()
        {
            if (txtBoxSalida.Text.Trim() != string.Empty && txtBoxSalida.Text.All(Char.IsNumber) && txtBoxSalida.TextLength <5)
            {
                salida = true;
                errorProviderSalida.SetError(txtBoxSalida, "");
            }
            else
            {
                if (!(txtBoxSalida.Text.All(Char.IsNumber)))
                {
                    errorProviderSalida.SetError(txtBoxSalida, "La entrada solo debe contener 4 números ejemplo: (18 40)");
                }
                else
                {
                    errorProviderSalida.SetError(txtBoxSalida, "Debe introducir una salida debe contener 4 números ejemplo: (18 40)");
                }
                txtBoxSalida.Focus();

            }
        }


        #endregion


        #region Botones funcionalidad

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            if (identificador && nombre && apellido && dni && entrada && salida)
            {
                btnAgregar.Enabled = true;
            }
            else
            {
                MessageBox.Show("Introduzca los datos que faltan correctamente");
             
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            comprobarDatos();

            if (existe)
            {
                ingresarDatosBBDD();
                MessageBox.Show("Los datos se han guardado correctamente");
            }
            else
            {
                MessageBox.Show("El usuario ya existe");
            }

            btnAgregar.Enabled = false;
                
    
        
        
        }

        private void btnSalirAgregar_Click(object sender, EventArgs e)
        {
            Form CambiarFormulario = new Inicio();
            CambiarFormulario.Show();
            this.Close();
        }

        #endregion



        #region metodos de comprobación de existencia de usuario y de inserción en la base de datos
        private void comprobarDatos()
        {

            try
            {
                var datos = cliente.Get("ListaTrabajadores/" + txtBoxDNI.Text);
                Trabajadores trabajador = datos.ResultAs<Trabajadores>();
                this.identificador1 = trabajador.Identificador;
                this.nombre1 = trabajador.Nombre;
                this.apellido1 = trabajador.Apellido;
                this.dni1 = trabajador.DNI;
                this.entrada1 = trabajador.Entrada;
                this.salida1 = trabajador.Salida;
            }
            catch
            {
                existe = true;
            }
        }

        private void ingresarDatosBBDD()
        {
            Trabajadores trabajador = new Trabajadores()
            {

                Identificador = txtBoxIdentificador.Text,
                Nombre = txtBoxNombre.Text,
                Apellido = txtBoxApellido.Text,
                DNI = txtBoxDNI.Text,
                Entrada = txtBoxEntrada.Text,
                Salida = txtBoxSalida.Text
            };
            var Guardar = cliente.Set("ListaTrabajadores/" + txtBoxDNI.Text, trabajador);

            txtBoxIdentificador.Text = "";
            txtBoxNombre.Text = "";
            txtBoxApellido.Text = "";
            txtBoxDNI.Text = "";
            txtBoxEntrada.Text = "";
            txtBoxSalida.Text = "";
        }

        #endregion
    }

}

