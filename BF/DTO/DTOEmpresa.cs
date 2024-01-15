﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOEmpresa
    {
        public int Id { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int FlgActivo { get; set; }
        public int IdArea { get; set; }
    }
}
