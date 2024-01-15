﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOPrograFacturacion
    {
        public int Id { get; set; }
        //Elementos de Busqueda
        public int IdFacturado { get; set; }
        public string DetFacturado { get; set; }
        public int IdSocio { get; set; }//Se usa para filtrar

        public int IdGerente { get; set; }//Se usa para filtrar
        public string engagement { get; set; }//Se usa para filtrar
        public string tipo { get; set; }
        public string referencia { get; set; }
        public int IdMoneda { get; set; }
        public string DetMoneda { get; set; }
        public decimal? monto { get; set; }
        public int? factConsoli { get; set; }
        public DateTime? fecha_estimacion { get; set; }
        public DateTime? fecha_emision { get; set; }
        public string nroFactura { get; set; }
        public int id_oportunidad { get; set; }
        public int IdRol { get; set; }
        public int? FlgActivo { get; set; }
        //Se agregó para realizar mejor las consultas
        //public int IdPeriodo { get; set; }//Se usa para filtrar
        //public string DetPeriodo { get; set; }//Se usa para filtrar


    }
}
