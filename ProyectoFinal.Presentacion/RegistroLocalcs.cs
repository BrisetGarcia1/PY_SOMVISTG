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
    public partial class RegistroLocalcs : Form
    {
        public RegistroLocalcs()
        {
            InitializeComponent();
        }

        private void RegistroLocalcs_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosRegistroLocal.SP_Local_Listar' Puede moverla o quitarla según sea necesario.
            this.sP_Local_ListarTableAdapter.Fill(this.datosRegistroLocal.SP_Local_Listar);

            this.reportViewer1.RefreshReport();
        }

        private void datosRegistroLocalBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
