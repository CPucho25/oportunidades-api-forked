using System;
using System.Collections.Generic;

namespace BF.Models.Staffing
{
    public partial class StMElemento
    {
        public StMElemento()
        {
            StTFormulario = new HashSet<StTFormulario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual ICollection<StTFormulario> StTFormulario { get; set; }
    }
}
