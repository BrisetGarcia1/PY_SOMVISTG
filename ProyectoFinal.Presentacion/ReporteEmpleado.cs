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
    public partial class ReporteEmpleado : Form
    {
        public ReporteEmpleado()
        {
            InitializeComponent();
        }

        private void ReporteEmpleado_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosRegistroEmpleado.SP_Empleado_Listar' Puede moverla o quitarla según sea necesario.
            this.sP_Empleado_ListarTableAdapter.Fill(this.datosRegistroEmpleado.SP_Empleado_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
