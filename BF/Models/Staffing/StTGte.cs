using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StTGte
    {
        public int Id { get; set; }
        public string Job { get; set; }
        public double? HorasCargadas { get; set; }
        public DateTime? Fecha { get; set; }
        public string Gpn { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }
    }
}
