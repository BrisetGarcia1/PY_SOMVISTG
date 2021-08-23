using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion.Reportes
{
    public partial class ReporteInventario : Form
    {
        public ReporteInventario()
        {
            InitializeComponent();
        }

        private void ReporteInventario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'DataSet1.SP_Inventario_Listar' Puede moverla o quitarla según sea necesario.
            this.SP_Inventario_ListarTableAdapter.Fill(this.DataSet1.SP_Inventario_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
