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
    public partial class RegistroCategoria : Form
    {
        public RegistroCategoria()
        {
            InitializeComponent();
        }

        private void RegistroCategoria_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'datosRegistroCategoria.SP_Categoria_Listar' Puede moverla o quitarla según sea necesario.
            this.sP_Categoria_ListarTableAdapter.Fill(this.datosRegistroCategoria.SP_Categoria_Listar);

            this.reportViewer1.RefreshReport();
        }
    }
}
