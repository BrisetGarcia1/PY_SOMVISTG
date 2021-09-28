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
    public partial class FrmAdministradorPrincipal : Form
    {
        public FrmAdministradorPrincipal()
        {
            InitializeComponent();
        }
        private void EstablecerColumnas()
        {
            dgvGrilla.Columns[0].Visible = false; 
            dgvGrilla.Columns[1].Width = 50; 
            dgvGrilla.Columns[2].Width = 90; 
            dgvGrilla.Columns[3].Width = 50; 
            dgvGrilla.Columns[4].Width = 80;
            dgvGrilla.Columns[5].Width = 50;
            dgvGrilla.Columns[6].Width = 80;
            dgvGrilla.Columns[7].Width = 50;

            dgvGrilla.Columns[1].HeaderText = "Codigo"; 
            dgvGrilla.Columns[2].HeaderText = "id Producto"; 
            dgvGrilla.Columns[3].HeaderText = "Stock"; 
            dgvGrilla.Columns[4].HeaderText = "Stock Fisico";
            dgvGrilla.Columns[5].HeaderText = "Diferencia";
            dgvGrilla.Columns[6].HeaderText = "Stock Salida";
            dgvGrilla.Columns[7].HeaderText = "Estado";
        }
        private void listarGrilla()
        {
            try
            {
                dgvGrilla.DataSource = ClsInventarioNegocio.Listar();
                this.EstablecerColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void FrmAdministradorPrincipal_Load(object sender, EventArgs e)
        {
            listarGrilla();
        }

        private void btnMostrarInvDetalle_Click(object sender, EventArgs e)
        {
            FrmAdministradorInvActivos MDI = new FrmAdministradorInvActivos();
            MDI.Show();
            this.Hide();
        }

        private void btnMostrarTrabajadores_Click(object sender, EventArgs e)
        {
            FrmAdministradorMostrarTrabajadores MDI = new FrmAdministradorMostrarTrabajadores();
            MDI.Show();
            this.Hide();
        }

        private void btnMostrarInvActivos_Click(object sender, EventArgs e)
        {
            FrmAdministradorInvActivos MDI = new FrmAdministradorInvActivos();
            MDI.Show();
            this.Hide();
        }

        private void btnRealizarAjuste_Click(object sender, EventArgs e)
        {
            FrmAdministradorInvDetalle MDI = new FrmAdministradorInvDetalle();
            MDI.Show();
            this.Hide();
        }

        private void btnMostrarTrabajadores_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorMostrarTrabajadores MDI = new FrmAdministradorMostrarTrabajadores();
            MDI.Show();
            this.Hide();
        }

        private void btnMostrarInvActivos_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorInvActivos MDI = new FrmAdministradorInvActivos();
            MDI.Show();
            this.Hide();
        }

        private void btnMostrarInvDetalle_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorInvActivos MDI = new FrmAdministradorInvActivos();
            MDI.Show();
            this.Hide();
        }
    }
}
