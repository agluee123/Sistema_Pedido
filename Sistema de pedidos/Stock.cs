﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_pedidos
{
    public class Stock
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public int cantidad { get; set; }


        public override string ToString()
        {
            return nombre;
        }


    }


}
