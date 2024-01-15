using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOGrabarSolicitudStaffing
    {
        public DTOSolicitudStaffing oportunidad { get; set; }
        public List<DTOHorasSolcitadasRank> horasSolcitadasRanks { get; set; }
    }
}
