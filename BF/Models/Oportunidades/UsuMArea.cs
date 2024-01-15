﻿using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class UsuMArea
    {
        public UsuMArea()
        {
            OpMServicio = new HashSet<OpMServicio>();
            OpMEstado = new HashSet<OpMEstado>();
            OpMMoneda = new HashSet<OpMMoneda>();
            UsuMUsuario = new HashSet<UsuMUsuario>();
        }

        public int Id { get; set; }
        public string Descripcion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public string UsuModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public virtual ICollection<OpMServicio> OpMServicio { get; set; }
        public virtual ICollection<OpMEstado> OpMEstado { get; set; }
        public virtual ICollection<OpMMoneda> OpMMoneda { get; set; }
        public virtual ICollection<UsuMUsuario> UsuMUsuario { get; set; }
    }
}
