using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOAuditoria
    {
        public int Id { get; set; }
        public string UsuCreacion { get; set; }
        public int TipoReporte { get; set; }
        public DateTime FecCreacion { get; set; }
    }
}
