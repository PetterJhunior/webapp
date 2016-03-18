using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Entidad
{
    public class Categoria
    {
        public int codigoCategoria { get; set; }
        public List<Subcategoria> subCategoria { get; set; }
        public string nombreCategoria { get; set; }
    }
}
