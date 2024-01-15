using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class VWRelacionServicio
    {
        [Key]
        public int Value { get; set; }
        public String Label { get; set; }
        public int IdPeriodo { get; set; }
        public int IdSocio { get; set; }
        public int IdGerente { get; set; }
        public int IdEmpresa { get; set; }

    }
}
