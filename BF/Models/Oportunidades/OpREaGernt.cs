using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BF.Models
{
    public partial class OpREaGernt
    {
        [Key]
        public int Id { get; set; }
        public int IdEa { get; set; }
        public int IdGerente { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecCreacion { get; set; }
        public int? FlgActivo { get; set; }

        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
    }
}
