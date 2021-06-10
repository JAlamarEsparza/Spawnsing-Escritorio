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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        IFirebaseConfig firebaseConf = new FirebaseConfig()
        {
            AuthSecret = "BY3dqAP0Ze3VS4gEEjqwbyiQKLJhq3zWprvJLHN0",
            BasePath = "https://spawnsign-default-rtdb.firebaseio.com/"
        };
        IFirebaseClient cliente;

        private void btnConsultaUsuario_Click(object sender, EventArgs e)
        {
            Form CambiarFormulario = new ConsultaUsuario();
            CambiarFormulario.Show();
            this.Hide();
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            Form CambiarFormulario = new AgregarUsuario();
            CambiarFormulario.Show();
            this.Hide();
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            Form CambiarFormulario = new EliminarUsuario();
            CambiarFormulario.Show();
            this.Hide();
        }

        private void btnCerrarInicio_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            try
            {
                cliente = new FireSharp.FirebaseClient(firebaseConf);
            }
            catch
            {
                MessageBox.Show("No se puede conectar con la base de datos actualmente");
            }


        }
    }
}
