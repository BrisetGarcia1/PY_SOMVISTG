using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Negocio;

namespace ProyectoFinal.Presentacion
{
    public partial class FrmLogin : Form
    {
        public int IDusuario;
        public string Apellido;
        public string Nombre;
        public string Usuario;
        public string Tipo;
        public string local;

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

            lblLocal.Text = "La Genovesa - " + local;
        }


        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string usuario, password;
                usuario = txtUsuario.Text;
                password = txtPassword.Text;

                DataTable tabla = new DataTable();
                tabla = ClsUsuarioNegocio.Loguear(usuario, password);

                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe BD", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MDIPrincipal MDI = new MDIPrincipal();
                    MDI.IDusuario = Convert.ToInt32(tabla.Rows[0][0]);
                    MDI.Apellido = Convert.ToString(tabla.Rows[0][1]);
                    MDI.Nombre = Convert.ToString(tabla.Rows[0][2]);
                    MDI.Usuario = Convert.ToString(tabla.Rows[0][3]);
                    MDI.Tipo = Convert.ToString(tabla.Rows[0][4]);
                    MDI.local = local;

                    MDI.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnAcceder_Click(object sender, EventArgs e)
        {
            try
            {
                string usuario, password;
                usuario = txtUsuario.Text;
                password = txtPassword.Text;

                DataTable tabla = new DataTable();
                tabla = ClsUsuarioNegocio.Loguear(usuario, password);

                if (tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe BD", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MDIPrincipal MDI = new MDIPrincipal();
                    MDI.IDusuario = Convert.ToInt32(tabla.Rows[0][0]);
                    MDI.Apellido = Convert.ToString(tabla.Rows[0][1]);
                    MDI.Nombre = Convert.ToString(tabla.Rows[0][2]);
                    MDI.Usuario = Convert.ToString(tabla.Rows[0][3]);
                    MDI.Tipo = Convert.ToString(tabla.Rows[0][4]);
                    MDI.local = local;

                    MDI.Show();
                    this.Hide();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
