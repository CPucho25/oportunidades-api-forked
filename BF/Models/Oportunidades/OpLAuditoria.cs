using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpLAuditoria
    {
        public int Id { get; set; }
        public int? IdOportunidad { get; set; }
        public int? IdCondicion { get; set; }
        public int? IdGrpeco { get; set; }
        public int? IdSector { get; set; }
        public int? IdEstado { get; set; }
        public int? IdFee { get; set; }
        public int? IdMoneda { get; set; }
        public decimal? Fee { get; set; }
        public decimal? Itan { get; set; }
        public decimal? Overrun { get; set; }

        public decimal? TotalMonto { get; set; }
        public int? IdGastos { get; set; }
        public int? GastosFijos { get; set; }
        public int? GastosDetalle { get; set; }
        public string Engagement1 { get; set; }
        public string Engagement2 { get; set; }
        public string CompetenciaRdj { get; set; }
        public string QuienGano { get; set; }
        public string Comentarios { get; set; }
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public int? FlgActivo { get; set; }

        public double? erpPresupuesto { get; set; }
        public double? rentabilidad { get; set; }
        //Inicio nuevos campos 13-04-2023
        public string eaf { get; set; }
        public string margen { get; set; }
        public string totalHoras { get; set; }
        public string idOportunidad { get; set; }
        public string propuestaFirmada { get; set; }
        public string numeroPace { get; set; }
        public string rutaGear { get; set; }
        public string rutaWorkSpace { get; set; }

        //Fin nuevos campos 13-04-2023
        public double? horasSocio { get; set; }
        public double? horasManager { get; set; }
        public double? horasSenior { get; set; }
        public double? horasStaff { get; set; }
        public double? horasTrainee { get; set; }
        public double? horasLider { get; set; }
        public double? horasSeniormanager { get; set; }

        public int? PsmFlag { get; set; }
        public double? PorcentajeEjecucion { get; set; }

        public virtual OpMCondicion IdCondicionNavigation { get; set; }
        public virtual OpMEstado IdEstadoNavigation { get; set; }
        public virtual OpMFee IdFeeNavigation { get; set; }
        public virtual OpMGastos IdGastosNavigation { get; set; }
        public virtual OpMGrpeco IdGrpecoNavigation { get; set; }
        public virtual OpMMoneda IdMonedaNavigation { get; set; }
        public virtual OpMOportunidad IdOportunidadNavigation { get; set; }
        public virtual OpMSector IdSectorNavigation { get; set; }
    }
}
