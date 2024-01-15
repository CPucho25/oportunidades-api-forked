using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StMRolPersonal
    {
        public StMRolPersonal()
        {
            StMPersonal = new HashSet<StMPersonal>();
            StTSolicitudHrsStaffing = new HashSet<StTSolicitudHrsStaffing>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double? Tarifa { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int? IdArea { get; set; }

        public virtual ICollection<StMPersonal> StMPersonal { get; set; }
        public virtual ICollection<StTSolicitudHrsStaffing> StTSolicitudHrsStaffing { get; set; }
    }
}
