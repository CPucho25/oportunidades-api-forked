using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMTipo
    {
        public OpMTipo()
        {
            OpLAuditoria = new HashSet<OpLAuditoria>();
            OpMOportunidad = new HashSet<OpMOportunidad>();
            OpMTipocambio = new HashSet<OpMTipocambio>();
        }

        public int Id { get; set; }
        public string DescripcionLarga { get; set; }
        public string DescripcionCorta { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public int? FlgActivo { get; set; }
        public int? IdArea { get; set; }

        public virtual UsuMArea IdAreaNavigation { get; set; }
        public virtual ICollection<OpLAuditoria> OpLAuditoria { get; set; }
        public virtual ICollection<OpMOportunidad> OpMOportunidad { get; set; }
        public virtual ICollection<OpMTipocambio> OpMTipocambio { get; set; }
    }
}
