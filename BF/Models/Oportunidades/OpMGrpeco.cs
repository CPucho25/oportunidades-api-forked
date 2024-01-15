using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMGrpeco
    {
        public OpMGrpeco()
        {
            OpLAuditoria = new HashSet<OpLAuditoria>();
            OpMOportunidad = new HashSet<OpMOportunidad>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int IdArea { get; set; }

        public virtual ICollection<OpLAuditoria> OpLAuditoria { get; set; }
        public virtual ICollection<OpMOportunidad> OpMOportunidad { get; set; }
    }
}
