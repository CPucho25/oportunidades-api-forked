using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StTRrhh
    {
        public int Id { get; set; }
        public double? HorasNocargables { get; set; }
        public DateTime? Fecha { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }
    }
}
