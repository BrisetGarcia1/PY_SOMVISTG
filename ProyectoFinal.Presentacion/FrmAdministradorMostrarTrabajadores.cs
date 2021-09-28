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
    public partial class FrmAdministradorMostrarTrabajadores : Form
    {
        public FrmAdministradorMostrarTrabajadores()
        {
            InitializeComponent();
            
        }
        private void EstablecerColumnas()
        {
            dgvGrilla1.Columns[0].Visible = false;
            dgvGrilla1.Columns[1].Width = 50;
            dgvGrilla1.Columns[2].Width = 70;
            dgvGrilla1.Columns[3].Width = 100;

            dgvGrilla1.Columns[1].HeaderText = "Codigo";
            dgvGrilla1.Columns[2].HeaderText = "Nombre";
            dgvGrilla1.Columns[3].HeaderText = "Apellido";
            dgvGrilla1.Columns[4].Visible = false;
            dgvGrilla1.Columns[5].Visible = false;
            dgvGrilla1.Columns[6].Visible = false;

        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Gestion de almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Gestion de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void listarGrilla()
        {
            try
            {
                DataTable empleado = new DataTable();
                dgvGrilla1.DataSource = ClsEmpleadoNegocio.Listar();
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

        private void btnAgregarTrabajador_Click(object sender, EventArgs e)
        {
            FrmAdministradorRegistrarTrabajador MDI = new FrmAdministradorRegistrarTrabajador();
            MDI.Show();
            this.Hide();
        }

        private void FrmAdministradorMostrarTrabajadores_Load(object sender, EventArgs e)
        {
            listarGrilla();
        }

        private void btnQuitarTrabajador_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el(los) registros(s)", "Sistema ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsEmpleadoNegocio.Eliminar(codigo);


                            if (Rpta == "OK se Elimino")
                            {
                                this.MensajeCorrecto("Se a eliminado" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);

                            }
                        }
                    }
                }
                this.listarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvGrilla1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGrilla1.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvGrilla1.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvGrilla1.Columns[0].Visible = true; 
            }
            else
            {
                dgvGrilla1.Columns[0].Visible = false; 
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorPrincipal MDI = new FrmAdministradorPrincipal();
            MDI.Show();
            this.Hide();
        }

        private void btnAgregarTrabajador_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorRegistrarTrabajador MDI = new FrmAdministradorRegistrarTrabajador();
            MDI.Show();
            this.Hide();
        }

        private void btnQuitarTrabajador_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el(los) registros(s)", "Sistema ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla1.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsEmpleadoNegocio.Eliminar(codigo);


                            if (Rpta == "OK se Elimino")
                            {
                                this.MensajeCorrecto("Se a eliminado" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);

                            }
                        }
                    }
                }
                this.listarGrilla();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }
}
