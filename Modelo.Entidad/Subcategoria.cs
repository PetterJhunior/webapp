using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidad
{
    public class Subcategoria
    {
        public int codigoSubCategoria { get; set; }
        public List<LineaCategoria> lineaCategoria { get; set; }
        public string nombreSubCategoria { get; set; }
    }
}
