using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StMFinanzas
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public double? ErpActual { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
    }
}
