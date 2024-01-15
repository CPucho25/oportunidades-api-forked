using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMPrograFacturacion
    {
        public int Id { get; set; }
        public string engagement { get; set; }
        public string tipo { get; set; }
        public string referencia { get; set; }
        public int IdMoneda { get; set; }
        //public string DetMoneda { get; set; }
        public decimal? monto { get; set; }
        public DateTime? fecha_estimacion { get; set; }
        public DateTime? fecha_emision { get; set; }
        public string nroFactura { get; set; }
        public int id_oportunidad { get; set; }
        public int? FlgActivo { get; set; }
        public int? IdFacturado { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? facturaConsolidada { get; set; }
        

        //public string DetFacturado { get; set; }

        //Elementos de Busqueda
        //public int IdSocio { get; set; }
        //public int IdGerente { get; set; }        

    }
}
