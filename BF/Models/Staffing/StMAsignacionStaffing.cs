using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StMAsignacionStaffing
    {
        public int Id { get; set; }
        public int? IdSolicitudStaffing { get; set; }
        public DateTime? Fecha { get; set; }
        public double? HorasCargables { get; set; }
        public double? HorasNocargables { get; set; }
        public int? IdPersonal { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual StMPersonal IdPersonalNavigation { get; set; }
        public virtual StTSolicitudHrsStaffing IdSolicitudStaffingNavigation { get; set; }
    }
}
