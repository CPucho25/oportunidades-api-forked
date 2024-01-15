using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class UsuMUsuario
    {
        public UsuMUsuario()
        {
            OpMMeta = new HashSet<OpMMeta>();
            OpRSocgercliIdGerenteNavigation = new HashSet<OpRSocgercli>();
            OpRSocgercliIdSocioNavigation = new HashSet<OpRSocgercli>();
            OpRSocserv = new HashSet<OpRSocserv>();
        }

        public int Id { get; set; }
        public int? IdRol { get; set; }
        public int? IdArea { get; set; }
        public string Descripcion { get; set; }
        public string DescripcionLarga { get; set; }
        public string Password { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int? FlgAdmin { get; set; }

        public virtual UsuMArea IdAreaNavigation { get; set; }
        public virtual UsuMRol IdRolNavigation { get; set; }
        public virtual ICollection<OpMMeta> OpMMeta { get; set; }
        public virtual ICollection<OpRSocgercli> OpRSocgercliIdGerenteNavigation { get; set; }
        public virtual ICollection<OpRSocgercli> OpRSocgercliIdSocioNavigation { get; set; }
        public virtual ICollection<OpRSocserv> OpRSocserv { get; set; }
    }
}
