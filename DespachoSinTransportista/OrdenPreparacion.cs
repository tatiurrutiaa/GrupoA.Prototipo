﻿using GrupoA.Prototipo.Archivos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrupoA.Prototipo.DespachoSinTransportista
{
    internal class OrdenPreparacion
    {
        public int NroOrdenPrep { get; internal set; }
        public string CuitCliente { get; internal set; }
        public EstadoOrdenPreparacion Estado { get; internal set; }
        public DateTime Fecha { get; internal set; }
        public int? DNITransportista { get; internal set; }
        public int NroDeposito { get; internal set; }
        public List<MercaderiasDetalle> mercaderiaDetalle { get; set; } = new List<MercaderiasDetalle>();
    }
}
