using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOFormulario
    {
        public int id { get; set; }
        public int id_elemento { get; set; }
        public int id_grupo { get; set; }
        public string tipo { get; set; }
        public int? area { get; set; }
        public int? flg_activo { get; set; }
        public List<DTOFormularioOpciones> opciones { get; set; }
    }
}
