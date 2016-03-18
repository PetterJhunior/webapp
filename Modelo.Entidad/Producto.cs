using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidad
{
    public class Producto
    {
        public int codigoProducto { get; set; }
        public string nombreProducto { get; set; }
        public string descripcionProducto { get; set; }
        public double precioProducto { get; set; }
        public string detalleProducto { get; set; }
        public List<ImagenProducto> imagenProducto { get; set; }
        public LineaCategoria lineaCategoria { get; set; }
    }
}
