using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class VWListarServicio
    {
        [Key]
        public int IdPeriodo { get; set; }
        public int IdServicio { get; set; }
        public string Descripcion{ get; set; }
        public int FlgActivo { get; set; }

        public int IdArea { get; set; }
    }
}
