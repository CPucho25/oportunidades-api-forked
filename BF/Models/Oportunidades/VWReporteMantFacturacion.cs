using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWReporteMantFacturacion
    {
        public int Id { get; set; }
        public int IdPeriodo { get; set; }
        public string DetPeriodo { get; set; }
        public int IdSocio { get; set; }
        public string NomSocio { get; set; }
        public int IdGerente { get; set; }
        public string NomGerente { get; set; }
    }
}
