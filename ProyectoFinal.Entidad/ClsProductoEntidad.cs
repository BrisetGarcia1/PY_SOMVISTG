using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.Entidad
{
    public class ClsProductoEntidad
    {
        public int id_Producto { get; set; }
        public int id_categoria { get; set; }
        public string Marca { get; set; }
        public string Descripcion { get; set; }
        public int precio { get; set; }
        public int catidad { get; set; }
        public string estado { get; set; }
    }
}
