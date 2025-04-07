using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ArticuloPedido
    {
        public int IdArticulosPedido { get; set; }
        public int PedidoId { get; set; }
        public int ArticuloId { get; set; }
        public int Cantidad { get; set; }
        public string Observacion { get; set; }
        public string NombreArticulo { get; set; }
    }
}
