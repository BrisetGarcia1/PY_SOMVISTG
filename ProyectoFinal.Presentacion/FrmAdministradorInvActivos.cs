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
    public partial class FrmAdministradorInvActivos : Form
    {
        public FrmAdministradorInvActivos()
        {
            InitializeComponent();
        }
        private void EstablecerColumnas()
        {
            dgvGrilla.Columns[0].Visible = false; //columna seleccionar
            dgvGrilla.Columns[1].Width = 80; //ID
            dgvGrilla.Columns[2].Width = 100; //Nombre
            dgvGrilla.Columns[3].Width = 80; //Año
            dgvGrilla.Columns[4].Width = 100; //Estado
            dgvGrilla.Columns[1].HeaderText = "Codigo"; //ID
            dgvGrilla.Columns[2].Visible = false;
            dgvGrilla.Columns[3].HeaderText = "Marca"; //Nombre
            dgvGrilla.Columns[4].HeaderText = "Descripcion"; //Año
            dgvGrilla.Columns[5].Visible = false;
            dgvGrilla.Columns[6].Visible = false;
            dgvGrilla.Columns[7].HeaderText = "Estado"; //Estado
        }
        private void listarGrilla()
        {
            try
            {
                dgvGrilla.DataSource = ClsProductoNegocio.Listar();
                this.EstablecerColumnas();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void combo()
        {
            cmbInventario.Items.Clear();
            cmbInventario.DataSource = ClsProductoNegocio.Listar_Activos();
            cmbInventario.DisplayMember = "descripcion";
        }
        private void btnRegresar_Click(object sender, EventArgs e)
        {
            FrmAdministradorPrincipal MDI = new FrmAdministradorPrincipal();
            MDI.Show();
            this.Hide();
        }

        private void FrmAdministradorInvActivos_Load(object sender, EventArgs e)
        {
            this.listarGrilla();
            this.combo();
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Desktop ABC", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo mensaje correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Desktop ABC", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnActivarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de Activar el(los) registros(s)", "Sistema ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsProductoNegocio.Activar(codigo);

                            if (Rpta == "OK se activar el inventario del producto")
                            {
                                this.MensajeCorrecto("Se a Activado" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);

                            }
                        }
                    }
                }
                this.listarGrilla();
                this.combo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnDesactivarInventario_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de Desactivar el(los) registros(s)", "Sistema ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsProductoNegocio.Desactivar(codigo);

                            if (Rpta == "OK se desactivo el inventario del producto")
                            {
                                this.MensajeCorrecto("Se a Desactivado" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);

                            }
                        }
                    }
                }
                this.listarGrilla();
                this.combo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGrilla.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvGrilla.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvGrilla.Columns[0].Visible = true; //columna de seleccion
            }
            else
            {
                dgvGrilla.Columns[0].Visible = false; //columna de seleccion
            }
        }

        private void btnActivarInventario_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de Activar el(los) registros(s)", "Sistema ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsProductoNegocio.Activar(codigo);

                            if (Rpta == "OK se activar el inventario del producto")
                            {
                                this.MensajeCorrecto("Se a Activado" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);

                            }
                        }
                    }
                }
                this.listarGrilla();
                this.combo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de Desactivar el(los) registros(s)", "Sistema ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsProductoNegocio.Desactivar(codigo);

                            if (Rpta == "OK se desactivo el inventario del producto")
                            {
                                this.MensajeCorrecto("Se a Desactivado" + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(Rpta);

                            }
                        }
                    }
                }
                this.listarGrilla();
                this.combo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            FrmAdministradorPrincipal MDI = new FrmAdministradorPrincipal();
            MDI.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
