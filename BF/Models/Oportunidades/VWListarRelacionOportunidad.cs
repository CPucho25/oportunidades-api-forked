using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class VWListarRelacionOportunidad
    {
        [Key]
        public int IdPeriodo { get; set; }
        public string DetPeriodo { get; set; }
        public int IdSocio { get; set; }
        public string NomSocio { get; set; }
        public int IdGerente { get; set; }
        public string NomGerente { get; set; }
        public int IdEmpresa { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public int IdArea { get; set; }
    }
}
