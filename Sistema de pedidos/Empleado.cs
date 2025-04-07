using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_pedidos
{
    public class Empleado
    {
        public int Id { get; set; }          
        public string Nombre { get; set; }    
        public string Apellido { get; set; } 
        public string DNI { get; set; }     
        public int Edad { get; set; }        
        public string Nacionalidad { get; set; } 
        public string Domicilio { get; set; }    
        public string Contacto { get; set; }     
        public string Tarea { get; set; }      
        public DateTime FechaIngreso { get; set; } 
    }
}
