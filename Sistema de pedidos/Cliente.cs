using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Cuit { get; set; }
        public string Localidad { get; set; }
        public string Telefono { get; set; }

        public override string ToString()
        {
            return Nombre ;
        }



    }
}
