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
    public partial class FrmSeleccionarInventario : Form
    {
        public string estado;
        public string local;
        public string nombre;
        public string valor = "";
        public string combo = "";
        public string cantidad = "";
        int parche = 1;
        public FrmSeleccionarInventario()
        {
            InitializeComponent();
        }

        private void FrmSeleccionarInventario_Load(object sender, EventArgs e)
        {
            cmbInvActivos.Items.Clear();
            cmbInvActivos.DataSource = ClsProductoNegocio.Listar_Activos();
            cmbInvActivos.DisplayMember = "descripcion";
            cmbInvActivos.ValueMember = "codigo_producto";
        }

        private void buscar()
        {
            combo = cmbInvActivos.GetItemText(cmbInvActivos.SelectedItem);
            DataTable btn = new DataTable();
            btn = ClsProductoNegocio.Buscar(combo);
            valor = btn.Rows[0]["codigo_producto"].ToString();
            cantidad = btn.Rows[0]["cantidad"].ToString();
        }

        public void valores()
        {
            FrmTrabajadorInvActivo MDI = new FrmTrabajadorInvActivo();
            buscar();
            MDI.estado = estado;
            MDI.local = local;
            MDI.nombre = nombre;
            MDI.producto = combo;
            MDI.codigo = valor;
            MDI.cantidad = cantidad;
            MDI.Show();
            this.Hide();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            do
            {
                if (cmbTipo.SelectedItem.ToString() == "Salida")
                {
                    estado = "S";
                    parche = 0;
                }
                else if (cmbTipo.SelectedItem.ToString() == "Entrada")
                {
                    estado = "E";
                    parche = 0;
                }
                else
                {
                    MessageBox.Show("Ingrese una opcion", "Sistema de Almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            } while (parche != 0);

            parche = 1;

            this.valores();
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            Dispose();
        }

        
    }
}
