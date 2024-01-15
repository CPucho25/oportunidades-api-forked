using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWListarReporteFacturacion
    {
        public int Id { get; set; }
        //Elementos de Busqueda
        public int id_oportunidad { get; set; }
        public string engagement { get; set; }
        //Ingresando nuevos columnas del reporte
        public DateTime? fechaEstimada { get; set; }//Nuevo euscuvilca 09/05/2023
        public decimal? importeFactura { get; set; }//Nuevo euscuvilca 09/05/2023
        public int IdFacturado { get; set; }
        public string DetFacturado { get; set; }
        public int IdSocio { get; set; }
        public string nom_socio { get; set; }
        public int IdGerente { get; set; }
        public string nom_gerente { get; set; }
        //

        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public int IdServicio { get; set; }
        public string DetServicio { get; set; }
        public int IdMoneda { get; set; }
        public string DetMoneda { get; set; }
        public decimal? Fee { get; set; }
        public decimal? ImporteProgramado{ get; set; }
        public decimal? Facturado { get; set; }

        public decimal? SaldoFacturar{ get; set; }
        public int? FlgActivo { get; set; }
        public int? FactConsoli { get; set; }
        public string referencia{ get; set; }
        public string nroFactura { get; set; }
        
    }
}
