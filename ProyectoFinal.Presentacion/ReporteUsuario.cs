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
    public partial class ReporteUsuario : Form
    {
        public ReporteUsuario()
        {
            InitializeComponent();
        }

        private void ReporteUsuario_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosReporteUsuario.SP_Usuario_Listar' Puede moverla o quitarla según sea necesario.
            this.sP_Usuario_ListarTableAdapter.Fill(this.datosReporteUsuario.SP_Usuario_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
