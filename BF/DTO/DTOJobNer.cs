using System;
using System.Collections.Generic;

namespace BF.DTO
{
    public  class DTOJobNer
    {
        public int  Id { get;set; }
        public int jobID { get; set; }
        public double? ner { get; set; }
        public int ? FlgActivo { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public string UsuCreacion { get; set; }

    }
}
