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
    public partial class RegistroDetalleInventario : Form
    {
        public RegistroDetalleInventario()
        {
            InitializeComponent();
        }

        private void RegistroDetalleInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosReporteDetalleInventario.SP_DetalleInventario_Listar' Puede moverla o quitarla según sea necesario.
            this.sP_DetalleInventario_ListarTableAdapter.Fill(this.datosReporteDetalleInventario.SP_DetalleInventario_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
