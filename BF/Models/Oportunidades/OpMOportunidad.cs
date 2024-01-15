using System;
using System.Collections.Generic;

namespace BF.Models
{
    public partial class OpMOportunidad
    {
        public OpMOportunidad()
        {
           OpLAuditoria = new HashSet<OpLAuditoria>();
        }

        public int Id { get; set; }
        public int? IdSocgercli { get; set; }
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
        public string UsuCreacion { get; set; }
        public DateTime FecCreacion { get; set; }
        public string UsuModificacion { get; set; }
        public DateTime? FecModificacion { get; set; }
        public int? FlgActivo { get; set; }
        public int? PsmFlag { get; set; }

        public double? erpPresupuesto { get; set; }
        public double? rentabilidad { get; set; }//euscuvil 11-01-2023
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
        public double? PorcentajeEjecucion { get; set; }
        //Ini - Agregando nuevos campos, salen de mant detalle facturacion
        public string rzFacturarDif { get; set; }
        public string rucFacturarDif { get; set; }
        public int? nroCompraOc { get; set; }
        public int? hes { get; set; }
        public int? otroDocumento { get; set; }
        public int? OpMTipoId { get; set; }
        
        //Fin - Agregando nuevos campos, salen de mant detalle facturacion

        public virtual OpMCondicion IdCondicionNavigation { get; set; }
        public virtual OpMEstado IdEstadoNavigation { get; set; }
        public virtual OpMFee IdFeeNavigation { get; set; }
        public virtual OpMGastos IdGastosNavigation { get; set; }
        public virtual OpMGrpeco IdGrpecoNavigation { get; set; }
        public virtual OpMMoneda IdMonedaNavigation { get; set; }
        public virtual OpMSector IdSectorNavigation { get; set; }
        public virtual OpRSocgercli IdSocgercliNavigation { get; set; }
        public virtual ICollection<OpLAuditoria> OpLAuditoria { get; set; }
    }
}
