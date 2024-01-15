using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWListarSocxServ
    {
        public int Id { get; set; }
        public int IdPeriodo { get; set; }
        public int IdSocio { get; set; }
        public int IdServicio { get; set; }
        public string Descripcion { get; set; }
        public int? FlgActivo { get; set; }
    }
}
