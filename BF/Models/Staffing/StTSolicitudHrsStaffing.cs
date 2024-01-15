using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StTSolicitudHrsStaffing
    {
        public StTSolicitudHrsStaffing()
        {
            InverseIdSolicitudStaffingNavigation = new HashSet<StTSolicitudHrsStaffing>();
            StMAsignacionStaffing = new HashSet<StMAsignacionStaffing>();
        }

        public int Id { get; set; }
        public int? IdSolicitudStaffing { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public double? HorasSolicitud { get; set; }
        public int? IdRol { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual StMRolPersonal IdRolNavigation { get; set; }
        public virtual StTSolicitudHrsStaffing IdSolicitudStaffingNavigation { get; set; }
        public virtual ICollection<StTSolicitudHrsStaffing> InverseIdSolicitudStaffingNavigation { get; set; }
        public virtual ICollection<StMAsignacionStaffing> StMAsignacionStaffing { get; set; }
    }
}
