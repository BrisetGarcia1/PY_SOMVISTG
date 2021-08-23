using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class ReporteProductos : Form
    {
        public ReporteProductos()
        {
            InitializeComponent();
        }

        private void ReporteProductos_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'dataSet2.SP_Producto_Listar' Puede moverla o quitarla según sea necesario.
            this.sP_Producto_ListarTableAdapter.Fill(this.dataSet2.SP_Producto_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
