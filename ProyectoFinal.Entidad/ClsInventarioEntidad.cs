using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidad
{
    public class ClsInventarioEntidad
    {
        public int id_Inventario { get; set; }
        public int id_producto { get; set; }
        public int Stock { get; set; }
        public int Stock_Fisico { get; set; }
        public int Diferencia { get; set; }
        public int Stock_Salida { get; set; }
        public string Estado { get; set; }
    }
}
