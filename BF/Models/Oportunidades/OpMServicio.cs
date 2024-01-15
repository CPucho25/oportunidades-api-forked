using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMServicio
    {
        public OpMServicio()
        {
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
        public int IdArea { get; set; }

        public virtual UsuMArea IdAreaNavigation { get; set; }

        public virtual ICollection<OpRSocgercli> OpRSocgercli { get; set; }
        public virtual ICollection<OpRSocserv> OpRSocserv { get; set; }
    }
}
