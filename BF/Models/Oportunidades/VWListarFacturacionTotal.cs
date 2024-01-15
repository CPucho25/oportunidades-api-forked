using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWListarFacturacionTotal
    {
        //Elementos de Busqueda
        public int id { get; set; }
        public string engagement { get; set; }
        public int? IdFacturado { get; set; }
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
        public int? IdMoneda { get; set; }
        public string DetMoneda { get; set; }
        public decimal? Fee { get; set; }
        public decimal? ImporteProgramado{ get; set; }
        public decimal? Facturado { get; set; }
        public decimal? SaldoFacturar{ get; set; }
        public int? FlgActivo { get; set; }
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
