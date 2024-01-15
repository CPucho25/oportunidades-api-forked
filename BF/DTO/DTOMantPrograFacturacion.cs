using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BF.DTO
{
    public class DTOMantPrograFacturacion
    {
        public int Id { get; set; }
        //Elementos de Busqueda
        public int id_oportunidad { get; set; }
        public string engagement { get; set; }
        public int IdFacturado { get; set; }
        public string DetFacturado { get; set; }
        public int IdSocio { get; set; }
        public string nom_socio { get; set; }
        public int IdGerente { get; set; }
        public string nom_gerente { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public int IdServicio { get; set; }
        public string DetServicio { get; set; }
        public int IdMoneda { get; set; }
        public string DetMoneda { get; set; }
        public decimal? Fee { get; set; }
        public decimal? ImporteProgramado { get; set; }
        public decimal? Facturado { get; set; }
        public decimal? SaldoFacturar { get; set; }
        public int? FlgActivo { get; set; }
        public int IdRol { get; set; }//Se usa para realizar la consulta de auerdo al rol solamente, de ahi ya no
        //Se agregó para filtrar por semana
        public int IdSemana { get; set; }
        public int IdFacturacion { get; set; }
        //Se agregó para filtrar por semana euscuvil 09/05/2023
    }
}
