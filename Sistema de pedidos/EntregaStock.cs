using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_pedidos
{
    public class EntregaStock
    {
        public int id { get; set; }
        public int idStock { get; set; }
        public string NombreProducto { get; set; }
        public string entregadoA { get; set; }
        public int cantidadEntregada { get; set; }
        public DateTime fechaEntrega { get; set; }
    }
}
