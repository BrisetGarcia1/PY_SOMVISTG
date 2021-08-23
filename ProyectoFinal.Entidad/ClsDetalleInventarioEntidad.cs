using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidad
{
    public class ClsDetalleInventarioEntidad
    {
        public int id_detalle { get; set; }
        public int id_Inventario { get; set; }
        public string Fecha { get; set; }
        public int Cantidad { get; set; }
        public string nombre { get; set; }
    }
}
