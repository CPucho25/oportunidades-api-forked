using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class VWListarSubservicio
    {
        [Key]
        public int IdPeriodo { get; set; }
        public int IdServicio { get; set; }
        public int IdSubservicio { get; set; }
        public string Descripcion{ get; set; }
        public int FlgActivo { get; set; }
    }
}
