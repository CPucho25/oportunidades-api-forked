using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOCambioClave
    {
        public int IdUsuario { get; set; }
        public string OldPassword { get; set; }
        public string NewPassword { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
    }

}
