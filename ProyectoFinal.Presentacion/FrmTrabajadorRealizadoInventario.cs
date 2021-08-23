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
    public partial class FrmTrabajadorRealizadoInventario : Form
    {
        public string estado;
        public string local;
        public string nombre;

        public FrmTrabajadorRealizadoInventario()
        {
            InitializeComponent();
        }
        private void EstablecerColumnas()
        {
            dgvGrilla.Columns[0].Visible = false;
            dgvGrilla.Columns[1].Width = 80;
            dgvGrilla.Columns[2].Width = 80;
            dgvGrilla.Columns[3].Width = 80;
            dgvGrilla.Columns[4].Width = 50;
            dgvGrilla.Columns[5].Width = 120;

            dgvGrilla.Columns[1].HeaderText = "Codigo";
            dgvGrilla.Columns[2].HeaderText = "Id Inventario";
            dgvGrilla.Columns[3].HeaderText = "Fecha"; 
            dgvGrilla.Columns[4].HeaderText = "Cantidad";
            dgvGrilla.Columns[5].HeaderText = "Nombre";
        }
        private void listarGrilla()
        {
            try
            {
                dgvGrilla.DataSource = ClsDetalleInventarioNegocio.Listar();
                this.EstablecerColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Valores_Entrar();
        }
        public void Valores_Entrar()
        {
            FrmTrabajadorInvActivo MDI = new FrmTrabajadorInvActivo();
            MDI.local = local;
            MDI.nombre = nombre;
            MDI.estado = estado;
            MDI.Show();
            this.Hide();
        }

        private void FrmTrabajadorRealizadoInventario_Load(object sender, EventArgs e)
        {
            listarGrilla();
        }
    }
}
