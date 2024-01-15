using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWListarSocio
    {
        public int Id { get; set; }
        public int IdSocio { get; set; }
        public int IdPeriodo { get; set; }
        public int IdGerente { get; set; }
        public string Descripcion { get; set; }
        public int IdArea { get; set; }
    }
}
