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
    public partial class FrmTrabajadorInvActivo : Form
    {
        public string estado;
        public string local;
        public string nombre;
        public string producto;
        public string codigo;
        public string cantidad;
        int diferencia = 0;
        string dia, hora;
        string id;
        
        public FrmTrabajadorInvActivo()
        {
            InitializeComponent();
            txtLocal.Enabled = false;
            txtPersona.Enabled = false;
            txtCodigoBarras.Enabled = false;
            txtInventario.Enabled = false;
        }

        private void FrmTrabajadorInvActivo_Load(object sender, EventArgs e)
        {
            txtLocal.Text = local;
            txtPersona.Text = nombre;
            txtCodigoBarras.Text = codigo;
            txtInventario.Text = producto;
            txtNombreProducto.Text = producto;
        }


        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtInventario.Clear();
            txtNombreProducto.Clear();
            txtPersona.Clear();
            txtCodigoBarras.Clear();
            txtCantidad.Clear();
            txtLocal.Clear();
            
        }

        public void ObtenerFechaActual()
        {

            DateTime fecha;

            fecha = DateTime.Now;
            dia = fecha.ToString("dd-MM-yyyy");
            hora = fecha.ToString("HH:mm:ss");
            
        }

        public void Valores_Entrar()
        {
            FrmTrabajadorRealizadoInventario MDI = new FrmTrabajadorRealizadoInventario();
            MDI.local = local;
            MDI.nombre = nombre;
            MDI.estado= estado;
            MDI.Show();
            this.Hide();
        }
        public void Valores_Salir()
        {
            FrmSeleccionarInventario MDI = new FrmSeleccionarInventario();
            MDI.local = local;
            MDI.nombre = nombre;
            MDI.Show();
            this.Hide();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Valores_Salir();
        }

        private void registrar_Datos()
        {
            if(txtCantidad.Text == null || txtCodigoBarras.Text == null || txtNombreProducto.Text == null || txtInventario.Text == null)
            {
                MessageBox.Show("Tienes que llenar todos los casilleron en blanco", "Sistema de Almacen - Empleado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (estado.Equals("S"))
                {
                    this.Salida();
                }
                else if (estado.Equals("E"))
                {
                    this.Entrada();
                }
            }
        
        }

        private void Entrada()
        {
            if(Convert.ToInt32(cantidad) > Convert.ToInt32(txtCantidad.Text))
            {
                this.ObtenerFechaActual();

                diferencia = Convert.ToInt32(cantidad) + Convert.ToInt32(txtCantidad.Text);

                ClsProductoNegocio.Actualizar_Salida(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToInt32(txtCantidad.Text));
                ClsInventarioNegocio.Insertar(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToInt32(cantidad), Convert.ToInt32(txtCantidad.Text), diferencia, 0, "Entrada");

                DataTable btn = new DataTable();
                btn = ClsInventarioNegocio.Indentificador();
                id = btn.Rows[0]["id_inventario"].ToString();

                ClsDetalleInventarioNegocio.Insertar(Convert.ToInt32(id), dia + " " + hora, Convert.ToInt32(cantidad), nombre);
                
                MessageBox.Show("Se registro con exito ", "Sistema de Almacen - Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cantidad de salida es mayor a al stock del producto | stock =  "+cantidad, "Sistema de Almacen - Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
           
        }

        private void Salida()
        {
            if (Convert.ToInt32(cantidad) > Convert.ToInt32(txtCantidad.Text))
            {
                this.ObtenerFechaActual();

                diferencia = Convert.ToInt32(cantidad) - Convert.ToInt32(txtCantidad.Text);

                ClsProductoNegocio.Actualizar_Salida(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToInt32(txtCantidad.Text));
                ClsInventarioNegocio.Insertar(Convert.ToInt32(txtCodigoBarras.Text), Convert.ToInt32(cantidad), 0, diferencia, Convert.ToInt32(txtCantidad.Text), "Salida");

                DataTable btn = new DataTable();
                btn = ClsInventarioNegocio.Indentificador();
                id = btn.Rows[0]["id_inventario"].ToString();

                ClsDetalleInventarioNegocio.Insertar(Convert.ToInt32(id), dia + " " + hora, Convert.ToInt32(cantidad), nombre);

                MessageBox.Show("Se registro con exito ", "Sistema de almacen", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("La cantidad de salida es mayor a al stock del producto | stock =  " + cantidad, "Sistema de Almacen - Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            this.registrar_Datos();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            this.Valores_Entrar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            DataTable btn = new DataTable();
            btn = ClsProductoNegocio.Buscar(txtNombreProducto.Text);
            txtInventario.Text = btn.Rows[0]["descripcion"].ToString();
            txtCodigoBarras.Text = btn.Rows[0]["codigo_producto"].ToString();
            cantidad = btn.Rows[0]["cantidad"].ToString();
            txtPersona.Text = nombre;
            txtLocal.Text = local;
        }
    }
}
