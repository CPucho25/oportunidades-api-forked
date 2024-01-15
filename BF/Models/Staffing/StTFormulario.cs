using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StTFormulario
    {
        public int Id { get; set; }
        public int? IdElemento { get; set; }
        public int? IdGrupo { get; set; }
        public int IdArea { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual StMElemento IdElementoNavigation { get; set; }
        public virtual StMGrupoFormulario IdGrupoNavigation { get; set; }
    }
}
