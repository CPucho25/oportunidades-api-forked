using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class UsuMIdioma
    {
        public UsuMIdioma()
        {
            UsuMUsuario = new HashSet<UsuMUsuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual ICollection<UsuMUsuario> UsuMUsuario { get; set; }
    }
}
