using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMFormulario
    {
        public OpMFormulario()
        {
        }

        public int Id { get; set; }
        public int IdElemento { get; set; }
        public int IdGrupo { get; set; }
        public int Area { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual OpMElemento IdElementoNavigation { get; set; }
        public virtual OpMGrupoFormulario IdGrupoNavigation { get; set; }
    }
}
