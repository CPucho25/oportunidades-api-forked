using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMEmpresas
    {
        public OpMEmpresas()
        {
            OpRSocgercli = new HashSet<OpRSocgercli>();
        }

        public int Id { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int IdArea { get; set; }
        //Agregando nuevos campos de la vista de mant de facturacion
        public string datosContacto { get; set; }
        public string condicionesProce { get; set; }

        public virtual ICollection<OpRSocgercli> OpRSocgercli { get; set; }
    }
}
