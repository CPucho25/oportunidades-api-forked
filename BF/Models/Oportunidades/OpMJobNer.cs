using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace BF.Models
{
    public partial class OpMJobner
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Job { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        
        public double? Ner { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
    }
}
