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
    public partial class FrmAdministradorInvDetalle : Form
    {
        public FrmAdministradorInvDetalle()
        {
            InitializeComponent();
        }
        private void EstablecerColumnas()
        {
            dgvGrilla.Columns[0].Visible = false;
            dgvGrilla.Columns[1].Width = 50;
            dgvGrilla.Columns[2].Width = 100;
            dgvGrilla.Columns[3].Width = 80;
            dgvGrilla.Columns[4].Width = 80;
            dgvGrilla.Columns[5].Width = 50;
            dgvGrilla.Columns[6].Width = 80;
            dgvGrilla.Columns[7].Width = 50;

            dgvGrilla.Columns[1].HeaderText = "Codigo";
            dgvGrilla.Columns[2].HeaderText = "Trabajor";
            dgvGrilla.Columns[3].HeaderText = "Fecha";
            dgvGrilla.Columns[4].HeaderText = "Stock";
            dgvGrilla.Columns[5].HeaderText = "Stock Fisico";
            dgvGrilla.Columns[6].HeaderText = "Diferencia";
            dgvGrilla.Columns[7].HeaderText = "Stock Salida";
        }
        private void listarGrilla()
        {
            try
            {
                dgvGrilla.DataSource = ClsDetalleInventarioNegocio.Unir();
                this.EstablecerColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmAdministradorPrincipal MDI = new FrmAdministradorPrincipal();
            MDI.Show();
            this.Hide();
        }

        private void btnRealizarPedidos_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se a comunicado su pedido", "Sistema de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FrmAdministradorInvDetalle_Load(object sender, EventArgs e)
        {
            listarGrilla();
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorPrincipal MDI = new FrmAdministradorPrincipal();
            MDI.Show();
            this.Hide();
        }

        private void btnRealizarPedidos_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Se a comunicado su pedido", "Sistema de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
