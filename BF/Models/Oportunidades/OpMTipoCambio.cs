using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMTipocambio
    {
        public int Id { get; set; }
        public int? IdMoneda { get; set; }
        public decimal? TipoCambio { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual OpMMoneda IdMonedaNavigation { get; set; }
    }
}
