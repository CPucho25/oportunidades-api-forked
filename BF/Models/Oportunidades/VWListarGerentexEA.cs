using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class VWListarGerentexEA
    {
        [Key]
        public int IdEa{ get; set; }
        public int IdGerente { get; set; }
        public string Descripcion { get; set; }
        public int FlgActivo { get; set; }

    }
}
