using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOOportunidadEmpresa
    {
        public int IdCondicionKey { get; set; }
        public int IdGrpecoKey { get; set; }
        public int IdSectorKey { get; set; }
        public int IdRol { get; set; }
        public int IdPeriodo { get; set; }
        public int IdRuc { get; set; }
        public int IdCondicion { get; set; }
        public int IdGrpeco { get; set; }
        public int IdSector { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int IdArea { get; set; }

    }
}
