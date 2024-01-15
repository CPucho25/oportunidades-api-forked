using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOGrupoFormulario
    {
        public int idGrupo { get; set; }
        public string nombre { get; set; }
        public int? idArea { get; set; }
        public List<DTOFormulario> Formulario { get; set; }
    }
}
