using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMPeriodo
    {
        public OpMPeriodo()
        {
            OpMMeta = new HashSet<OpMMeta>();
            OpRSocgercli = new HashSet<OpRSocgercli>();
            OpRSocserv = new HashSet<OpRSocserv>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual ICollection<OpMMeta> OpMMeta { get; set; }
        public virtual ICollection<OpRSocgercli> OpRSocgercli { get; set; }
        public virtual ICollection<OpRSocserv> OpRSocserv { get; set; }
    }
}
