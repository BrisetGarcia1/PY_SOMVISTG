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
    public partial class FormInventario : Form
    {
        public FormInventario()
        {
            InitializeComponent();
        }
        private void EstablecerColumnas()
        {
            dgvGrilla.Columns[0].Visible = false; //columna seleccionar
            dgvGrilla.Columns[1].Width = 50;
            dgvGrilla.Columns[2].Width = 50;
            dgvGrilla.Columns[3].Width = 50;
            dgvGrilla.Columns[4].Width = 50;
            dgvGrilla.Columns[5].Width = 50;
            dgvGrilla.Columns[6].Width = 50;
            dgvGrilla.Columns[7].Width = 80;
            dgvGrilla.Columns[8].Width = 80;


            dgvGrilla.Columns[1].HeaderText = "Codigo";
            dgvGrilla.Columns[2].HeaderText = "ID producto";
            dgvGrilla.Columns[3].HeaderText = "Stock";
            dgvGrilla.Columns[4].HeaderText = "Stock Fisico";
            dgvGrilla.Columns[5].HeaderText = "Diferencia";
            dgvGrilla.Columns[6].HeaderText = "Stock Salida";
            dgvGrilla.Columns[7].HeaderText = "Fecha";
            dgvGrilla.Columns[8].HeaderText = "Estado";
        }
        private void listarGrilla()
        {
            try
            {
                dgvGrilla.DataSource = ClsInventarioNegocio.Listar();
                this.EstablecerColumnas();
                lbltotal.Text = "Total de Registros" + Convert.ToString(dgvGrilla.RowCount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            this.listarGrilla();
        }
        private void Buscar()
        {
            try
            {
                string busqueda;
                busqueda = txtBusqueda.Text;
                dgvGrilla.DataSource = ClsInventarioNegocio.Buscar(busqueda);
                this.EstablecerColumnas();
                lbltotal.Text = "Total de Registros: " + Convert.ToString(dgvGrilla.RowCount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        //metodo limpiar 
        private void Limpiar()
        {
            txtBusqueda.Clear();
            txtIdProducto.Clear();
            txtID.Clear();
            txtStockFisico.Clear();
            txtStock.Clear();
            txtStockSalida.Clear();
            txtEstado.Clear();
            txtDiferencia.Clear();
        }

        private void Visualizar()
        {
            btnActualizar.Visible = true;
        }

        //metodo mensaje error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Gestion de almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //metodo mensaje correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema Gestion de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnCancelarA_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Visualizar();
            tabControl1.SelectedIndex = 0;
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    string Rpta = "";
            //    if (txtID.Text == string.Empty)
            //    {
            //        this.MensajeError("Falta completar datos de algun campo..");
            //        //control error
            //        errorAlerta.SetError(txtID, " Ingrese nombre del Empleado");
            //    }
            //    else
            //    {
            //        Rpta = ClsInventarioNegocio.Actualizar(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtIdProducto.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtStockFisico.Text), Convert.ToInt32(txtDiferencia.Text), Convert.ToInt32(txtStockSalida.Text), txtEstado.Text);
            //        if (Rpta.Equals("OK se inserto en el registra"))
            //        {
            //            this.MensajeCorrecto("Se inserto correctamente el registro BD");
            //            this.Limpiar();
            //            this.Visualizar();
            //            this.listarGrilla();
            //        }
            //        else
            //        {
            //            this.MensajeError(Rpta);
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message + ex.StackTrace);
            //}
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el(los) registros(s)", "Sistema de Almacen - Administrador ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsLocalNegocio.Eliminar(codigo);


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
                chkSeleccionar.Checked = false;
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
                dgvGrilla.Columns[0].Visible = true;
            }
            else
            {
                dgvGrilla.Columns[0].Visible = false;
            }
        }

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnEliminar_Click_1(object sender, EventArgs e)
        {
            try
            {
                DialogResult opcion;
                opcion = MessageBox.Show("Esta seguro de eliminar el(los) registros(s)", "Sistema de Almacen - Administrador ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (opcion == DialogResult.OK)
                {
                    int codigo;
                    string Rpta = "";

                    foreach (DataGridViewRow row in dgvGrilla.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            Rpta = ClsLocalNegocio.Eliminar(codigo);


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
                chkSeleccionar.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCancelarA_Click_1(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Visualizar();
            tabControl1.SelectedIndex = 0;
        }

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtID.Text == string.Empty)
                {
                    this.MensajeError("Falta completar datos de algun campo..");
                    //control error
                    errorAlerta.SetError(txtID, " Ingrese nombre del Empleado");
                }
                else
                {
                    Rpta = ClsInventarioNegocio.Actualizar(Convert.ToInt32(txtID.Text), Convert.ToInt32(txtIdProducto.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtStockFisico.Text), Convert.ToInt32(txtDiferencia.Text), Convert.ToInt32(txtStockSalida.Text), txtEstado.Text);
                    if (Rpta.Equals("OK se inserto en el registra"))
                    {
                        this.MensajeCorrecto("Se inserto correctamente el registro BD");
                        this.Limpiar();
                        this.Visualizar();
                        this.listarGrilla();
                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }
    }

}
