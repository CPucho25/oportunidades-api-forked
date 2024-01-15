using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOHorasSolicitudStaffing
    {
        public int Id { get; set; }
        public DateTime? FechaSolicitud { get; set; }
        public double? HorasSolicitud { get; set; }
        public int? IdRol { get; set; }
    }
}
