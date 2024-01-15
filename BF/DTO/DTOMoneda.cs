using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOMoneda {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionCorta { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecCreacion { get; set; }
        public int? FlgActivo { get; set; }
        public int IdArea { get; set; }
    }
}
