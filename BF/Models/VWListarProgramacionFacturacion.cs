using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWListarProgramacionFacturacion
    {
        public int Id { get; set; }
        //Elementos de Busqueda
        public int IdFacturado { get; set; }
        public string DetFacturado { get; set; }
        public int IdSocio { get; set; }
        //
        public int IdGerente { get; set; }
        public string engagement { get; set; }
        public string tipo { get; set; }
        public string referencia { get; set; }
        public int IdMoneda { get; set; }
        public string DetMoneda { get; set; }
        public decimal? monto { get; set; }
        public DateTime? fecha_estimacion { get; set; }
        public DateTime? fecha_emision { get; set; }
        public string nroFactura { get; set; }
        public int? FactConsoli { get; set; }
        public int id_oportunidad { get; set; }

        public int? FlgActivo { get; set; }
        //Se agregó para realizar mejor los filtros en el Where
        //public int IdPeriodo { get; set; }
        //public string DetPeriodo { get; set; }

        //Agregando nuevos campos
        public string rzFacturarDif { get; set; }
        public string rucFacturarDif { get; set; }
        public int? nroCompraOc { get; set; }
        public int? hes { get; set; }
        public int? otroDocumento { get; set; }
        public string condicionesProce { get; set; }
        public string datosContacto { get; set; }


    }
}
