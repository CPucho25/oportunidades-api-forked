using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOOportunidadAcum
    {
        public double? HorasLider { get; set; }
        public double? HorasSocio { get; set; }
        public double? HorasSeniorManager { get; set; }
        public double? HorasManager { get; set; }
        public double? HorasSenior { get; set; }
        public double? HorasStaff { get; set; }
        public double? HorasTrainee { get; set; }
        public double? TNRYTD { get; set; }

        public List<DTOHorasSolicitudStaffing> horasSolicitudStaffing { get; set; }
}
}
