using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Articulo
    {
        public int IdArticulo { get; set; }
        public string Nombre { get; set; }
        public string Categoria { get; set; }
        public string Medida { get; set; }
        public string Perforacion { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
