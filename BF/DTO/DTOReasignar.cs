using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOReasignar
    {
        public int IdPeriodo { get; set; }
        public int IdSocio { get; set; }
        public int IdGerente { get; set; }
        public int IdEmpresa { get; set; }
        public List<DTORelacionServicio> LstServicio { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime FecModificacion { get; set; }
        public int FlgActivo { get; set; }
    }
}
