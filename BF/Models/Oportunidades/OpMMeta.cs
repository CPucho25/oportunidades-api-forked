using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMMeta
    {
        public int Id { get; set; }
        public int? IdPeriodo { get; set; }
        public int? IdUsuario { get; set; }
        public decimal? Meta { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual OpMPeriodo IdPeriodoNavigation { get; set; }
        public virtual UsuMUsuario IdUsuarioNavigation { get; set; }
    }
}
