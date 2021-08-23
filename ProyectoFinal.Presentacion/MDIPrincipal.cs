using ProyectoFinal.Presentacion.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.Presentacion
{
    public partial class MDIPrincipal : Form
    {
        public int IDusuario;
        public string Apellido;
        public string Nombre;
        public string Usuario;
        public string Tipo = "";
        public string local;

        public MDIPrincipal()
        {
            InitializeComponent();
        }

        private void localToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmLocal Frm = new FrmLocal();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void MDIPrincipal_Load(object sender, EventArgs e)
        {
            stBarraEstado.Text = "Bienvenido: " + Nombre + ", " + Apellido + ", " + "Rol: [" + Tipo + "]";

            if (this.Tipo.Equals("Administrador"))
            {
                menuPrincipalToolStripMenuItem.Visible = true;
                menuEmpleadoToolStripMenuItem.Visible = true;
                
            }
            else
            {
                if (this.Tipo.Equals("Supervisor"))
                {
                    menuPrincipalToolStripMenuItem.Visible = false;
                    menuEmpleadoToolStripMenuItem.Visible = true;
                    
                }
                else
                {
                    menuPrincipalToolStripMenuItem.Visible = false;
                    menuEmpleadoToolStripMenuItem.Visible = true;
                    
                }
            }
        }

    

        private void dToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult opcion;
            opcion = MessageBox.Show("DESEA SALIR DEL SISTEMA?? ", "Sisteama ABC", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (opcion == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void menuPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAdministradorPrincipal Frm = new FrmAdministradorPrincipal();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void menuEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmSeleccionarInventario Frm = new FrmSeleccionarInventario();
            Frm.local = local;
            Frm.nombre = Nombre +" "+ Apellido;
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void stBarraEstado_Click(object sender, EventArgs e)
        {

        }

        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteInventario Frm = new ReporteInventario();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void productoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProductos Frm = new ReporteProductos();
            Frm.MdiParent = this;
            Frm.Show();
            
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteProductos Frm = new ReporteProductos();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteEmpleado Frm = new ReporteEmpleado();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void detalleDeInventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDetalleInventario Frm = new RegistroDetalleInventario();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroCategoria Frm = new RegistroCategoria();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void localToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RegistroLocalcs Frm = new RegistroLocalcs();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void usuarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmUsuario Frm = new FrmUsuario();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void localToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmLocal Frm = new FrmLocal();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void empleadoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmEmpleado Frm = new FrmEmpleado();
            Frm.MdiParent = this;
            Frm.Show();
        }

        private void inventarioToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormInventario Frm = new FormInventario();
            Frm.MdiParent = this;
            Frm.Show();
        }
    }
}
