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
    public partial class EliminarUsuario : Form
    {
       
        public EliminarUsuario()
        {
            InitializeComponent();
        }

        IFirebaseConfig firebaseConf = new FirebaseConfig()
        {
            AuthSecret = "BY3dqAP0Ze3VS4gEEjqwbyiQKLJhq3zWprvJLHN0",
            BasePath = "https://spawnsign-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient cliente;
 private void EliminarUsuario_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(firebaseConf);
            }
            catch
            {
                MessageBox.Show("No se puede conectar con la base de datos actualmente");
            }

            btnEliminar.Enabled = false;

        }



        #region Cambio en los textos
        private void txtBoxEliminar_TextChanged(object sender, EventArgs e)
        {
            controlDNI();
        }
        #endregion



        #region Comprobacion Errores


        private void controlDNI()
        {
            if (txtBoxEliminar.Text.Trim() != string.Empty && txtBoxEliminar.Text.All(Char.IsLetterOrDigit) && txtBoxEliminar.TextLength < 10 && txtBoxEliminar.TextLength > 8)
            {
                btnEliminar.Enabled = true;
                errorProviderEliminar.SetError(txtBoxEliminar, "");
            }
            else
            {
                if (!(txtBoxEliminar.Text.All(Char.IsLetterOrDigit)))
                {
                    errorProviderEliminar.SetError(txtBoxEliminar, "El Dni solo puede contener letras o Números (Longitud de 9 carácteres)");
                }
                else
                {
                    errorProviderEliminar.SetError(txtBoxEliminar, "Debe introducir un DNI (Longitud de 9 carácteres)");
                }
                txtBoxEliminar.Focus();
                btnEliminar.Enabled = false;
            }
        }

        #endregion 



        #region Funcionalidad Botones
        private void btnSalirEliminar_Click(object sender, EventArgs e)
        {
            Form CambiarFormulario = new Inicio();
            CambiarFormulario.Show();
            this.Close();
        }

  private void btnEliminar_Click(object sender, EventArgs e)
        {

          
                var resultado = cliente.Delete("ListaTrabajadores/" + txtBoxEliminar.Text);

                txtBoxEliminar.Text = "";

                MessageBox.Show("Los datos se han eliminado correctamente");
            
        }


        #endregion


    }
}
