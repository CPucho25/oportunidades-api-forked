using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StMPersonal
    {
        public StMPersonal()
        {
            StMAsignacionStaffing = new HashSet<StMAsignacionStaffing>();
        }

        public int Id { get; set; }
        public string Gpn { get; set; }
        public int? IdSocioLider { get; set; }
        public int? IdRol { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual StMRolPersonal IdRolNavigation { get; set; }
        public virtual ICollection<StMAsignacionStaffing> StMAsignacionStaffing { get; set; }
    }
}
