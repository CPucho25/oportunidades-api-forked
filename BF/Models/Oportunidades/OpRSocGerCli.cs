using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpRSocgercli
    {
        public OpRSocgercli()
        {
            OpMOportunidad = new HashSet<OpMOportunidad>();
        }

        public int Id { get; set; }
        public int? IdPeriodo { get; set; }
        public int? IdSocio { get; set; }
        public int? IdGerente { get; set; }
        public int? IdEmpresa { get; set; }
        public int? IdServicio { get; set; }
        public int? IdSubservicio { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual OpMEmpresas IdEmpresaNavigation { get; set; }
        public virtual UsuMUsuario IdGerenteNavigation { get; set; }
        public virtual OpMPeriodo IdPeriodoNavigation { get; set; }
        public virtual OpMServicio IdServicioNavigation { get; set; }
        public virtual UsuMUsuario IdSocioNavigation { get; set; }
        public virtual OpMSubservicio IdSubservicioNavigation { get; set; }
        public virtual ICollection<OpMOportunidad> OpMOportunidad { get; set; }
    }
}
