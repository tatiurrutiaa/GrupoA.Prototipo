﻿using GrupoA.Prototipo.Empaquetar;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.Empaquetado
{
    internal class EmpaquetarModelo
    {
        public List<Pedido> Empaquetar {  get; set; }

        public EmpaquetarModelo()
        {
            Empaquetar = new List<Pedido>();
            new Pedido { NroPedido = "Ref", Mercaderia = "zapatos" };
        }
    }
}
