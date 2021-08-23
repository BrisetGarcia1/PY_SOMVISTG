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
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            txtID.Enabled = false;
        }

        private void EstablecerColumnas()
        {
            dgvGrilla.Columns[0].Visible = false; //columna seleccionar
            dgvGrilla.Columns[1].Width = 50; //ID
            dgvGrilla.Columns[2].Width = 100; //Nombre
            dgvGrilla.Columns[3].Width = 150; //Direccion
            dgvGrilla.Columns[4].Width = 100; //Telefono


            dgvGrilla.Columns[1].HeaderText = "Codigo"; //ID
            dgvGrilla.Columns[2].HeaderText = "id Persona"; //Nombre
            dgvGrilla.Columns[3].HeaderText = "User"; //Clave
            dgvGrilla.Columns[4].HeaderText = "Contraseña"; //Rol
        }

        //metodo listar
        private void listarGrilla()
        {
            try
            {
                dgvGrilla.DataSource = ClsUsuarioNegocio.Listar();
                this.EstablecerColumnas();
                lbltotal.Text = "Total de Registros" + Convert.ToString(dgvGrilla.RowCount);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            this.listarGrilla();
        }

        //metodo buscar
        private void Buscar()
        {
            try
            {
                string busqueda;
                busqueda = txtBusqueda.Text;
                dgvGrilla.DataSource = ClsUsuarioNegocio.Buscar(busqueda);
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
            txtID.Clear();
            txtBusqueda.Clear();
            txtidEmpleado.Clear();
            txtuser.Clear();
            txtIdA.Clear();
            txtCaontrasena.Clear();
            txtidEmpleadoA.Clear();
            txtUserA.Clear();
            txtContrasenaA.Clear();
        }

        private void Visualizar()
        {
            btnGrabar.Visible = true;
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Visualizar();
            tabControl1.SelectedIndex = 0;
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtidEmpleado.Text == string.Empty)
                {
                    this.MensajeError("Falta completar datos de algun campo..");
                    //control error
                    errorAlerta.SetError(txtidEmpleado, "Ingrese nombre del semestre");
                }
                else
                {
                    Rpta = ClsUsuarioNegocio.Insertar(Convert.ToInt32(txtidEmpleado.Text), txtuser.Text, txtCaontrasena.Text);
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

        private void btnCancelarA_Click(object sender, EventArgs e)
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
                if (txtidEmpleadoA.Text == string.Empty)
                {
                    this.MensajeError("Falta completar datos de algun campo..");
                    //control error
                    errorAlerta.SetError(txtidEmpleadoA, "Ingrese nombre del Usuario");
                }
                else
                {
                    Rpta = ClsUsuarioNegocio.Actualizar(Convert.ToInt32(txtIdA.Text), Convert.ToInt32(txtidEmpleadoA.Text), txtUserA.Text, txtContrasenaA.Text);
                    if (Rpta.Equals("OK RESGITRO SE ACTUALIZO"))
                    {
                        this.MensajeCorrecto("Se Actualizo correctamente el registro BD");
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

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            this.Buscar();
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
                            Rpta = ClsUsuarioNegocio.Eliminar(codigo);


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

        private void dgvGrilla_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvGrilla.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvGrilla.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }
    }
}
