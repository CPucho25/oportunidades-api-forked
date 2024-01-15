using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpRSocserv
    {
        public int Id { get; set; }
        public int? IdPeriodo { get; set; }
        public int? IdSocio { get; set; }
        public int? IdServicio { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual OpMPeriodo IdPeriodoNavigation { get; set; }
        public virtual OpMServicio IdServicioNavigation { get; set; }
        public virtual UsuMUsuario IdSocioNavigation { get; set; }
    }
}
