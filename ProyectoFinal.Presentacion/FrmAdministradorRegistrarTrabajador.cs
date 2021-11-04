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
    public partial class FrmAdministradorRegistrarTrabajador : Form
    {
        public FrmAdministradorRegistrarTrabajador()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {

        }

        private void Limpiar()
        {
            txtApellido.Clear();
            txtDNI.Clear();
            txtCelular.Clear();
            txtNombre.Clear();
            txtPassword1.Clear();
            txtPassword2.Clear();
        }

        private void Visualizar()
        {
            
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
            Limpiar();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta completar datos de algun campo..");
                    //control error
                    errorAlerta.SetError(txtNombre, "Ingrese nombre del Empleado");
                }
                else
                {
                    Rpta = ClsEmpleadoNegocio.Insertar(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCelular.Text, txtCargo.Text);
                    if(txtPassword1.Text == txtPassword2.Text)
                    {
                        string valor = "";
                        DataTable btn = new DataTable();
                        btn = ClsEmpleadoNegocio.Buscar(txtApellido.Text);
                        valor = btn.Rows[0]["id_empleado"].ToString();
                        ClsUsuarioNegocio.Insertar(Convert.ToInt32(valor), txtUser.Text, txtPassword1.Text);

                        if (Rpta.Equals("OK se inserto en el registra"))
                        {
                            this.MensajeCorrecto("Se inserto correctamente el registro BD");
                            this.Limpiar();
                            this.Visualizar();
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coincide vuelva a intentar ...", "Menu registrar empleado" , MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmAdministradorRegistrarTrabajador_Load(object sender, EventArgs e)
        {

        }

        private void btnRegistrar_Click_1(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";

                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Falta completar datos de algun campo..");
                    //control error
                    errorAlerta.SetError(txtNombre, "Ingrese nombre del Empleado");
                }
                else
                {
                    Rpta = ClsEmpleadoNegocio.Insertar(txtNombre.Text, txtApellido.Text, txtDNI.Text, txtCelular.Text, txtCargo.Text);
                    if (txtPassword1.Text == txtPassword2.Text)
                    {
                        string valor = "";
                        DataTable btn = new DataTable();
                        btn = ClsEmpleadoNegocio.Buscar(txtApellido.Text);
                        valor = btn.Rows[0]["id_empleado"].ToString();
                        ClsUsuarioNegocio.Insertar(Convert.ToInt32(valor), txtUser.Text, txtPassword1.Text);

                        if (Rpta.Equals("OK se inserto en el registro"))
                        {
                            this.MensajeCorrecto("Se inserto correctamente el registro BD");
                            this.Limpiar();
                            this.Visualizar();
                        }
                        else
                        {
                            this.MensajeError(Rpta);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Las contraseñas no coincide vuelva a intentar ...", "Menu registrar empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
