using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class VWReporteGeneral
    {
        public int Id { get; set; }
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
        public int IdCondicion { get; set; }
        public string DetCondicion { get; set; }
        public string DetGrpeco { get; set; }
        public string DetSector { get; set; }
        public int IdEstado { get; set; }
        public string DetEstado { get; set; }
        public string DetFee { get; set; }
        public string DetMoneda { get; set; }
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
        public string DetGastos { get; set; }
        public int? GastosFijos { get; set; }
        public int? GastosDetalle { get; set; }
        public string Engagement1 { get; set; }
        public string Engagement2 { get; set; }
        public string CompetenciaRdj { get; set; }
        public string QuienGano { get; set; }
        public string Comentarios { get; set; }
        public int? FlgActivo { get; set; }
        public int IdArea { get; set; }
        public string Eaf { get; set; }
        public string Margen { get; set; }
        public string TotalHoras { get; set; }
        public string IdOportunidad2 { get; set; }
        public string PropuestaFirmada { get; set; }
        public string NumeroPace { get; set; }
        public string RutaGear { get; set; }
        public string RutaWorkSpace { get; set; }

    }
}
