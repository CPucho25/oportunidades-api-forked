using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMGrupoFormulario
    {
        public OpMGrupoFormulario()
        {
            OpMFormulario = new HashSet<OpMFormulario>();
        }

        public int Id { get; set; }
        public string Nombre { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual ICollection<OpMFormulario> OpMFormulario { get; set; }
    }
}
