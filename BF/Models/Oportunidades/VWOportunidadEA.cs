using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWOportunidadEA
    {
        public int Id { get; set; }
        public int IdEa { get; set; }
        public int IdPeriodo { get; set; }
        public string DetPeriodo { get; set; }
        public int IdSocio { get; set; }
        public string NomSocio { get; set; }
        public int IdGerente { get; set; }
        public string NomGerente { get; set; }
        public int IdEmpresa { get; set; }
        public string Ruc { get; set; }
        public string RazonSocial { get; set; }
        public int IdServicio { get; set; }
        public string DetServicio { get; set; }
        public int IdSubservicio { get; set; }
        public string DetSubservicio { get; set; }
        public int? IdCondicion { get; set; }
        public int? IdGrpeco { get; set; }
        public int? IdSector { get; set; }
        public int? IdEstado { get; set; }
        public int? IdFee { get; set; }
        public int? IdMoneda { get; set; } 
        public decimal? Fee { get; set; }
        public decimal? Itan { get; set; }
        public decimal? Overrun { get; set; }

        public decimal? TarifHoraria { get; set; }
        public decimal? CantHoras { get; set; }
        public decimal? TotalMonto { get; set; }
        public decimal? FeeSublinea { get; set; }
        public decimal? TarifHorariaSublinea { get; set; }
        public decimal? CantHorasSublinea { get; set; }
        public decimal? TotalSublinea { get; set; }
        public int? IdGastos { get; set; }
        public int? GastosFijos { get; set; }
        public int? GastosDetalle { get; set; }
        public string Engagement1 { get; set; }
        public string Engagement2 { get; set; }
        public string CompetenciaRdj { get; set; }
        public string QuienGano { get; set; }
        public string Comentarios { get; set; }
        public int? IdRol { get; set; }
        public int? IdArea { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime? FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }

        public double? Ner { get; set; }
        public int? PsmFlag { get; set; }

        public double? ErpPresupuesto { get; set; }
        public double? Rentabilidad { get; set; }//euscuvil 10-01-2023
        public double? HorasSocio { get; set; }
        public double? HorasManager { get; set; }
        public double? HorasSenior { get; set; }
        public double? HorasStaff { get; set; }
        public double? HorasTrainee { get; set; }

        public double? HorasLider { get; set; }
        public double? HorasSeniormanager { get; set; }
        public string eaf { get; set; }
        public string margen { get; set; }
        public string totalHoras { get; set; }
        public string idOportunidad { get; set; }
        public string propuestaFirmada { get; set; }
        public string numeroPace { get; set; }
        public string rutaGear { get; set; }
        public string rutaWorkSpace { get; set; }

    }
}
