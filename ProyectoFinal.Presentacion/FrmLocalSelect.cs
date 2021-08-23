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
    public partial class FrmLocalSelect : Form
    {
        public string clocal = "";

        public FrmLocalSelect()
        {
            InitializeComponent();
        }

        private void FrmLocalSelect_Load(object sender, EventArgs e)
        {
            cmbLocales.Items.Clear();
            cmbLocales.DataSource = ClsLocalNegocio.Listar();
            cmbLocales.DisplayMember = "nombre";
            cmbLocales.ValueMember = "id_local";
        }

        private void valores()
        {
            FrmLogin MDI = new FrmLogin();
            MDI.local = clocal;
            MDI.Show();
            this.Hide();
        }

        private void cmbLocales_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAcceder_Click_1(object sender, EventArgs e)
        {
            try
            {
                DataTable tablaLocal = new DataTable();
                tablaLocal = ClsLocalNegocio.Listar();
                clocal = cmbLocales.GetItemText(cmbLocales.SelectedItem);
                if (tablaLocal.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no existe BD", "Acceso al sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    this.valores();
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
    }
}
