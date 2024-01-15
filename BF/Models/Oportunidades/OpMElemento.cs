using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMElemento
    {
        public OpMElemento()
        {
            OpMFormulario = new HashSet<OpMFormulario>();
        }

        public int Id { get; set; }
        public int IdTipoElemento { get; set; }
        public string Descripcion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual OpMTipoElemento IdTipoElementoNavigation { get; set; }
        public virtual ICollection<OpMFormulario> OpMFormulario { get; set; }
    }
}
