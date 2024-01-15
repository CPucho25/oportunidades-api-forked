using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMTipoElemento
    {
        public OpMTipoElemento()
        {
            OpMElemento = new HashSet<OpMElemento>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual ICollection<OpMElemento> OpMElemento { get; set; }
    }
}
