using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWListarMeta
    {
        public int Id { get; set; }
        public int IdPeriodo { get; set; }
        public string DetPeriodo { get; set; }
        public int IdUsuario { get; set; }
        public string Descripcion { get; set; }
        public int IdRol { get; set; }
        public decimal Meta{ get; set; }
        public int? FlgActivo { get; set; }
    }
}
