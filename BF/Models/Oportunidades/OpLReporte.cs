using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpLReporte
    {
        public int Id { get; set; }
        public int? TipoReporte { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
    }
}
