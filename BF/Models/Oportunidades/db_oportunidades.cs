using System;
using BF.Controllers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BF.Models.Opotunidades
{
    public partial class db_oportunidades : DbContext
    {
        public db_oportunidades()
        {
        }

        public db_oportunidades(DbContextOptions<db_oportunidades> options)
            : base(options)
        {
        }

        #region Table DBset
        public virtual DbSet<UsuMRol> UsuMRol { get; set; }
        public virtual DbSet<OpMFacturacion> OpMFacturacion { get; set; }
        public virtual DbSet<UsuMArea> UsuMArea { get; set; }
        public virtual DbSet<UsuMUsuario> UsuMUsuario { get; set; }
        public virtual DbSet<OpMEmpresas> OpMEmpresas { get; set; }
        public virtual DbSet<OpMMoneda> OpMMoneda { get; set; }
        public virtual DbSet<OpMTipo> OpMTipo { get; set; }
        public virtual DbSet<OpMTipocambio> OpMTipocambio { get; set; }
        public virtual DbSet<OpMCondicion> OpMCondicion { get; set; }
        public virtual DbSet<OpMGrpeco> OpMGrpeco { get; set; }
        public virtual DbSet<OpMSector> OpMSector { get; set; }
        public virtual DbSet<OpMEstado> OpMEstado { get; set; }
        public virtual DbSet<OpMPrograFacturacion> OpMPrograFacturacion { get; set; }
         
        public virtual DbSet<OpMServicio> OpMServicio { get; set; }
        public virtual DbSet<OpMSubservicio> OpMSubservicio { get; set; }
        public virtual DbSet<OpMPeriodo> OpMPeriodo { get; set; }
        public virtual DbSet<OpMFee> OpMFee { get; set; }
        public virtual DbSet<OpMGastos> OpMGastos { get; set; }
        public virtual DbSet<OpRSocgercli> OpRSocGerCli { get; set; }
        public virtual DbSet<OpMOportunidad> OpMOportunidad { get; set; }
        public virtual DbSet<OpREaGernt> OpREaGernt { get; set; }
        public virtual DbSet<OpLReporte> OpLReporte { get; set; }
        public virtual DbSet<OpLAuditoria> OpLAuditoria { get; set; }
        public virtual DbSet<OpMMeta> OpMMeta { get; set; }
        public virtual DbSet<OpMJobner> OpMJobner { get; set; }
        public virtual DbSet<OpMFormulario> OpMFormulario { get; set; }
        public virtual DbSet<OpMGrupoFormulario> OpMGrupoFormulario { get; set; }
        public virtual DbSet<OpMElemento> OpMElemento { get; set; }
        public virtual DbSet<OpMTipoElemento> OpMTipoElementos { get; set; }
        #endregion

        #region View DBset
        public virtual DbSet<VWListarTC> VWListarTC { get; set; }
        public virtual DbSet<VWListarServicio> VWListarServicio { get; set; }
        public virtual DbSet<VWListarSubservicio> VWListarSubservicio { get; set; }
        public virtual DbSet<VWListarGerente> VWListarGerente { get; set; }
        public virtual DbSet<VWListarSocio> VWListarSocio { get; set; }
        public virtual DbSet<VWListarGerentexEA> VWListarGerentexEA { get; set; }
        public virtual DbSet<VWListarOportunidad> VWListarOportunidad { get; set; }
        //euscuvilca 24-04-2023
        public virtual DbSet<VWListarProgramacionFacturacion> VWListarProgramacionFacturacion { get; set; }
        public virtual DbSet<VWListarMantProgramacionFacturacion> VWListarMantProgramacionFacturacion { get; set; }
        public virtual DbSet<VWListarReporteFacturacion> VWListarReporteFacturacion { get; set; }
        
        public virtual DbSet<VWListarOportunidadXempresa> VWListarOportunidadXempresas { get; set; }
        public virtual DbSet<VWListarOportunidadXempresaPT> VWListarOportunidadXempresasPT { get; set; }
        public virtual DbSet<VWListarSocxServ> VWListarSocxServ { get; set; }
        public virtual DbSet<VWOportunidadEA> VWOportunidadEA { get; set; }
        public virtual DbSet<VWReporteGeneral> VWReporteGeneral { get; set; }
        public virtual DbSet<VWReporteMantFacturacion> VWReporteMantFacturacion { get; set; }
        public virtual DbSet<VWListarFacturacionTotal> VWListarFacturacionTotal { get; set; }
        public virtual DbSet<VWReporteCuentas> VWReporteCuentas { get; set; }
        public virtual DbSet<VWListarRelacionOportunidad> VWListarRelacionOportunidad { get; set; }
        public virtual DbSet<VWRelacionServicio> VWRelacionServicio { get; set; }
        public virtual DbSet<VWListarMeta> VWListarMeta { get; set; }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            #region Nuevos cuadros de busqueda
            //euscuvilca 24-04-2023 Nuevos Procedimientos Almacenados
            modelBuilder.Entity<VWListarProgramacionFacturacion>(entity =>
            {
                entity.ToTable("Listar_Facturacion");
                entity.Property(e => e.Id).HasColumnName("id");
                //entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                //entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.engagement).HasColumnName("engagement");
                entity.Property(e => e.tipo).HasColumnName("tipo");
                entity.Property(e => e.referencia).HasColumnName("referencia");
                entity.Property(e => e.IdMoneda).HasColumnName("IdMoneda");//Realizar inner con la otra tabla
                entity.Property(e => e.DetMoneda).HasColumnName("DetMoneda");//Realizar inner
                entity.Property(e => e.IdFacturado).HasColumnName("IdFacturado");
                entity.Property(e => e.DetFacturado).HasColumnName("DetFacturado");
                entity.Property(e => e.monto).HasColumnName("monto");
                entity.Property(e => e.fecha_estimacion).HasColumnName("fecha_estimacion");
                entity.Property(e => e.fecha_emision).HasColumnName("fecha_emision");
                entity.Property(e => e.nroFactura).HasColumnName("nroFactura");
                entity.Property(e => e.FactConsoli).HasColumnName("facturaConsolidada");
                entity.Property(e => e.id_oportunidad).HasColumnName("id_oportunidad");
                //Agregando los filtros de busqueda
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.engagement).HasColumnName("engagement");
                //entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
                //Agregando nuevos campos
                entity.Property(e => e.rzFacturarDif).HasColumnName("rzFacturarDif");
                entity.Property(e => e.rucFacturarDif).HasColumnName("rucFacturarDif");
                entity.Property(e => e.nroCompraOc).HasColumnName("nroCompraOc");
                entity.Property(e => e.hes).HasColumnName("hes");
                entity.Property(e => e.otroDocumento).HasColumnName("otroDocumento");
                entity.Property(e => e.condicionesProce).HasColumnName("condicionesProce");
                entity.Property(e => e.datosContacto).HasColumnName("datosContacto");
            });

            modelBuilder.Entity<OpMPrograFacturacion>(entity =>
            {
                entity.ToTable("op_m_progra_facturacion");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.engagement)
                    .HasColumnName("engagement")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.tipo)
                    .HasColumnName("tipo")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.referencia)
                    .HasColumnName("referencia")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.IdMoneda)
                    .HasColumnName("id_moneda");//Realizar inner con la otra tabla

                entity.Property(e => e.IdFacturado)
                    .HasColumnName("id_facturado");

                entity.Property(e => e.monto)
                    .HasColumnName("monto");

                entity.Property(e => e.fecha_estimacion)
                    .HasColumnName("fecha_estimacion");

                entity.Property(e => e.fecha_emision)
                    .HasColumnName("fecha_emision");

                entity.Property(e => e.nroFactura)
                    .HasColumnName("nroFactura");

                entity.Property(e => e.id_oportunidad)
                    .HasColumnName("id_oportunidad");

                entity.Property(e => e.engagement)
                    .HasColumnName("engagement");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.facturaConsolidada)
                    .HasColumnName("facturaConsolidada")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                //entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
            });


            modelBuilder.Entity<VWListarMantProgramacionFacturacion>(entity =>
            {
                entity.ToTable("Listar_MantFacturacion");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.id_oportunidad).HasColumnName("id_oportunidad");
                entity.Property(e => e.engagement).HasColumnName("engagement");
                entity.Property(e => e.IdFacturado).HasColumnName("IdFacturado");
                entity.Property(e => e.DetFacturado).HasColumnName("DetFacturado");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.nom_gerente).HasColumnName("nom_gerente");
                entity.Property(e => e.Ruc).HasColumnName("Ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("RazonSocial");
                entity.Property(e => e.IdServicio).HasColumnName("IdServicio");
                entity.Property(e => e.DetServicio).HasColumnName("DetServicio");
                //entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                //entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");

                entity.Property(e => e.IdMoneda).HasColumnName("IdMoneda");//Realizar inner con la otra tabla
                entity.Property(e => e.DetMoneda).HasColumnName("DetMoneda");//Realizar inner
                entity.Property(e => e.Fee).HasColumnName("fee");
                entity.Property(e => e.ImporteProgramado).HasColumnName("ImporteProgramado");
                entity.Property(e => e.Facturado).HasColumnName("Facturado");
                entity.Property(e => e.SaldoFacturar).HasColumnName("SaldoFacturar");

                //Agregando nuevos campos
                entity.Property(e => e.rzFacturarDif).HasColumnName("rzFacturarDif");
                entity.Property(e => e.rucFacturarDif).HasColumnName("rucFacturarDif");
                entity.Property(e => e.nroCompraOc).HasColumnName("nroCompraOc");
                entity.Property(e => e.hes).HasColumnName("hes");
                entity.Property(e => e.otroDocumento).HasColumnName("otroDocumento");
                entity.Property(e => e.condicionesProce).HasColumnName("condicionesProce");
                entity.Property(e => e.datosContacto).HasColumnName("datosContacto");


                //entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
            });

            // DataCompleta de Facturación
            modelBuilder.Entity<VWListarFacturacionTotal>(entity =>
            {
                entity.ToTable("Listar_FacturacionTotal");
                entity.Property(e => e.id).HasColumnName("id");
                entity.Property(e => e.engagement).HasColumnName("engagement");
                entity.Property(e => e.IdFacturado).HasColumnName("IdFacturado");
                entity.Property(e => e.DetFacturado).HasColumnName("DetFacturado");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.nom_gerente).HasColumnName("nom_gerente");
                entity.Property(e => e.Ruc).HasColumnName("Ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("RazonSocial");
                entity.Property(e => e.IdServicio).HasColumnName("IdServicio");
                entity.Property(e => e.DetServicio).HasColumnName("DetServicio");
                //entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                //entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");

                entity.Property(e => e.IdMoneda).HasColumnName("IdMoneda");//Realizar inner con la otra tabla
                entity.Property(e => e.DetMoneda).HasColumnName("DetMoneda");//Realizar inner
                entity.Property(e => e.Fee).HasColumnName("fee");
                entity.Property(e => e.ImporteProgramado).HasColumnName("ImporteProgramado");
                entity.Property(e => e.Facturado).HasColumnName("Facturado");
                entity.Property(e => e.SaldoFacturar).HasColumnName("SaldoFacturar");

                //Agregando nuevos campos
                entity.Property(e => e.rzFacturarDif).HasColumnName("rzFacturarDif");
                entity.Property(e => e.rucFacturarDif).HasColumnName("rucFacturarDif");
                entity.Property(e => e.nroCompraOc).HasColumnName("nroCompraOc");
                entity.Property(e => e.hes).HasColumnName("hes");
                entity.Property(e => e.otroDocumento).HasColumnName("otroDocumento");
                entity.Property(e => e.condicionesProce).HasColumnName("condicionesProce");
                entity.Property(e => e.datosContacto).HasColumnName("datosContacto");


                //entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
            });

            //euscuvil 09/05/2023 creacion de vista para reportes de facturacion
            modelBuilder.Entity<VWListarReporteFacturacion>(entity =>
            {
                entity.ToTable("Listar_ReporteFacturacion");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.id_oportunidad).HasColumnName("id_oportunidad");
                entity.Property(e => e.engagement).HasColumnName("engagement");
                entity.Property(e => e.fechaEstimada).HasColumnName("fechaEstimada");//Nuevo euscuvilca 09/05/2023
                entity.Property(e => e.importeFactura).HasColumnName("importeFactura");//Nuevo euscuvilca 09/05/2023
                entity.Property(e => e.IdFacturado).HasColumnName("IdFacturado");
                entity.Property(e => e.DetFacturado).HasColumnName("DetFacturado");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.nom_gerente).HasColumnName("nom_gerente");
                entity.Property(e => e.Ruc).HasColumnName("Ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("RazonSocial");
                entity.Property(e => e.IdServicio).HasColumnName("IdServicio");
                entity.Property(e => e.DetServicio).HasColumnName("DetServicio");
                //entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                //entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");

                entity.Property(e => e.IdMoneda).HasColumnName("IdMoneda");//Realizar inner con la otra tabla
                entity.Property(e => e.DetMoneda).HasColumnName("DetMoneda");//Realizar inner
                entity.Property(e => e.Fee).HasColumnName("Fee");
                entity.Property(e => e.ImporteProgramado).HasColumnName("ImporteProgramado");
                entity.Property(e => e.Facturado).HasColumnName("Facturado");
                entity.Property(e => e.SaldoFacturar).HasColumnName("SaldoFacturar");                
                entity.Property(e => e.FactConsoli).HasColumnName("facturaConsolidada");
                entity.Property(e => e.referencia).HasColumnName("referencia");
                entity.Property(e => e.nroFactura).HasColumnName("nroFactura");
                //Agregando los filtros de busqueda


                //entity.Property(e => e.nom_socio).HasColumnName("nom_socio");
            });

            #endregion

            #region Table
            modelBuilder.Entity<OpLAuditoria>(entity =>
            {
                entity.ToTable("op_l_auditoria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentarios)
                    .HasColumnName("comentarios")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompetenciaRdj)
                    .HasColumnName("competencia_rdj")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Engagement1)
                    .HasColumnName("engagement_1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Engagement2)
                    .HasColumnName("engagement_2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PsmFlag)
                    .HasColumnName("psm_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentajeEjecucion)
                    .HasColumnName("percent_ejecucion");

                entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");

                entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");

                entity.Property(e => e.IdCondicion).HasColumnName("id_condicion");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdFee).HasColumnName("id_fee");

                entity.Property(e => e.IdGastos).HasColumnName("id_gastos");

                entity.Property(e => e.IdGrpeco).HasColumnName("id_grpeco");

                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");

                entity.Property(e => e.IdOportunidad).HasColumnName("id_oportunidad");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.Itan)
                    .HasColumnName("itan")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Overrun)
                    .HasColumnName("overrun")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.QuienGano)
                    .HasColumnName("quien_gano")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TotalMonto)
                    .HasColumnName("total_monto")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.HasOne(d => d.IdCondicionNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdCondicion)
                    .HasConstraintName("FK__op_l_audi__id_co__7C4F7684");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK__op_l_audi__id_es__7F2BE32F");

                entity.HasOne(d => d.IdFeeNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdFee)
                    .HasConstraintName("FK__op_l_audi__id_fe__00200768");

                entity.HasOne(d => d.IdGastosNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdGastos)
                    .HasConstraintName("FK__op_l_audi__id_ga__02084FDA");

                entity.HasOne(d => d.IdGrpecoNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdGrpeco)
                    .HasConstraintName("FK__op_l_audi__id_gr__7D439ABD");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK__op_l_audi__id_mo__01142BA1");

                entity.HasOne(d => d.IdOportunidadNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdOportunidad)
                    .HasConstraintName("FK__op_l_audi__id_op__7B5B524B");

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.OpLAuditoria)
                    .HasForeignKey(d => d.IdSector)
                    .HasConstraintName("FK__op_l_audi__id_se__7E37BEF6");

                entity.Property(e => e.erpPresupuesto)
                    .HasColumnName("erp_presupuesto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.rentabilidad)
                    .HasColumnName("rentabilidad")
                    .HasDefaultValueSql("((0))");//euscuvil 11-01-2023

                entity.Property(e => e.horasSocio)
                    .HasColumnName("hrs_socio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasManager)
                    .HasColumnName("hrs_manager")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasSenior)
                    .HasColumnName("hrs_senior")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasStaff)
                    .HasColumnName("hrs_staff")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasTrainee)
                    .HasColumnName("hrs_trainee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasLider)
                    .HasColumnName("hrs_lider")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasSeniormanager)
                    .HasColumnName("hrs_seniormanager")
                    .HasDefaultValueSql("((0))");
                entity.Property(e => e.eaf).HasColumnName("eaf");
                entity.Property(e => e.margen).HasColumnName("margen");
                entity.Property(e => e.totalHoras).HasColumnName("totalHoras");
                entity.Property(e => e.idOportunidad).HasColumnName("idOportunidad");
                entity.Property(e => e.propuestaFirmada).HasColumnName("propuestaFirmada");
                entity.Property(e => e.numeroPace).HasColumnName("numeroPace");
                entity.Property(e => e.rutaGear).HasColumnName("rutaGear");
                entity.Property(e => e.rutaWorkSpace).HasColumnName("rutaWorkSpace");
            });

            modelBuilder.Entity<OpLReporte>(entity =>
            {
                entity.ToTable("op_l_reporte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TipoReporte).HasColumnName("tipo_reporte");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");
            });

            modelBuilder.Entity<OpMCondicion>(entity =>
            {
                entity.ToTable("op_m_condicion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });

            modelBuilder.Entity<OpMElemento>(entity =>
            {
                entity.ToTable("op_m_elemento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdTipoElemento).HasColumnName("id_tipo_elemento");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdTipoElementoNavigation)
                    .WithMany(p => p.OpMElemento)
                    .HasForeignKey(d => d.IdTipoElemento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__op_m_elem__id_ti__3AD6B8E2");
            });

            modelBuilder.Entity<OpMEmpresas>(entity =>
            {
                entity.ToTable("op_m_empresas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.RazonSocial)
                    .HasColumnName("razon_social")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Ruc)
                    .HasColumnName("ruc")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area");

                entity.Property(e => e.datosContacto)
                    .HasColumnName("datosContacto")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.condicionesProce)
                    .HasColumnName("condicionesProce")
                    .HasMaxLength(150)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMEstado>(entity =>
            {
                entity.ToTable("op_m_estado");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.OpMEstado)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_id_area");
            });

            modelBuilder.Entity<OpMFee>(entity =>
            {
                entity.ToTable("op_m_fee");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMFormulario>(entity =>
            {
                entity.ToTable("op_m_formulario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Area).HasColumnName("area");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.IdElemento).HasColumnName("id_elemento");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digiltaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdElementoNavigation)
                    .WithMany(p => p.OpMFormulario)
                    .HasForeignKey(d => d.IdElemento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__op_m_form__id_el__3BCADD1B");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.OpMFormulario)
                    .HasForeignKey(d => d.IdGrupo)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__op_m_form__id_gr__3CBF0154");
            });

            
            modelBuilder.Entity<OpMGastos>(entity =>
            {
                entity.ToTable("op_m_gastos");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMGrpeco>(entity =>
            {
                entity.ToTable("op_m_grpeco");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area");
            });

            modelBuilder.Entity<OpMGrupoFormulario>(entity =>
            {
                entity.ToTable("op_m_grupo_formulario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnName("nombre")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMJobner>(entity =>
            {
                entity.HasKey(e => e.Job)
                    .HasName("PK__op_m_job__DC90FCA15058F179");

                entity.ToTable("op_m_jobner");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .ValueGeneratedNever();

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ner)
                    .HasColumnName("ner");

                entity.Property(e => e.Id)
                    .HasColumnName("id");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMMeta>(entity =>
            {
                entity.ToTable("op_m_meta");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");

                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");

                entity.Property(e => e.Meta)
                    .HasColumnName("meta")
                    .HasColumnType("decimal(12, 4)");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany(p => p.OpMMeta)
                    .HasForeignKey(d => d.IdPeriodo)
                    .HasConstraintName("FK__op_m_meta__id_pe__2B0A656D");

                entity.HasOne(d => d.IdUsuarioNavigation)
                    .WithMany(p => p.OpMMeta)
                    .HasForeignKey(d => d.IdUsuario)
                    .HasConstraintName("FK__op_m_meta__id_us__2BFE89A6");
            });

            modelBuilder.Entity<OpMMoneda>(entity =>
            {
                entity.ToTable("op_m_moneda");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescripcionCorta)
                    .HasColumnName("descripcion_corta")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .HasColumnName("descripcion_larga")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.OpMMoneda)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("Fk_id_area_moneda");
            });

            modelBuilder.Entity<OpMTipo>(entity =>
            {
                entity.ToTable("op_m_tipo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.DescripcionCorta)
                    .HasColumnName("descripcion_corta")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .HasColumnName("descripcion_larga")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                /*entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.OpMTipo)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("Fk_id_area_moneda");*/
            });

            modelBuilder.Entity<OpMOportunidad>(entity =>
            {
                entity.ToTable("op_m_oportunidad");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CantHoras)
                    .HasColumnName("cant_horas")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.CantHorasSublinea)
                    .HasColumnName("cant_horas_sublinea")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Comentarios)
                    .HasColumnName("comentarios")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CompetenciaRdj)
                    .HasColumnName("competencia_rdj")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Engagement1)
                    .HasColumnName("engagement_1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Engagement2)
                    .HasColumnName("engagement_2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fee)
                    .HasColumnName("fee")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.FeeSublinea)
                    .HasColumnName("fee_sublinea")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.PsmFlag)
                    .HasColumnName("psm_flag")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");

                entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");

                entity.Property(e => e.IdCondicion).HasColumnName("id_condicion");

                entity.Property(e => e.IdEstado).HasColumnName("id_estado");

                entity.Property(e => e.IdFee).HasColumnName("id_fee");

                entity.Property(e => e.IdGastos).HasColumnName("id_gastos");

                entity.Property(e => e.IdGrpeco).HasColumnName("id_grpeco");

                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");

                entity.Property(e => e.IdSector).HasColumnName("id_sector");

                entity.Property(e => e.IdSocgercli).HasColumnName("id_socgercli");

                entity.Property(e => e.Itan)
                    .HasColumnName("itan")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.Overrun)
                    .HasColumnName("overrun")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.QuienGano)
                    .HasColumnName("quien_gano")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.TarifHoraria)
                    .HasColumnName("tarif_horaria")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TarifHorariaSublinea)
                    .HasColumnName("tarif_horaria_sublinea")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TotalMonto)
                    .HasColumnName("total_monto")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.TotalSublinea)
                    .HasColumnName("total_sublinea")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
                //INI - Nuevos campos a agregar en Mant Facturacion
                entity.Property(e => e.rzFacturarDif)
                    .HasColumnName("rzFacturarDif")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.rucFacturarDif)
                                    .HasColumnName("rucFacturarDif")
                                    .HasMaxLength(15)
                                    .IsUnicode(false);

                entity.Property(e => e.nroCompraOc)
                                    .HasColumnName("nroCompraOc")
                                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.hes)
                                    .HasColumnName("hes")
                                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.otroDocumento)
                                    .HasColumnName("otroDocumento")
                                    .HasDefaultValueSql("((0))");
                //FIN - Nuevos campos a agregar en Mant Facturacion

                entity.HasOne(d => d.IdCondicionNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdCondicion)
                    .HasConstraintName("FK__op_m_opor__id_co__6C190EBB");

                entity.HasOne(d => d.IdEstadoNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdEstado)
                    .HasConstraintName("FK__op_m_opor__id_es__6EF57B66");

                entity.HasOne(d => d.IdFeeNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdFee)
                    .HasConstraintName("FK__op_m_opor__id_fe__6FE99F9F");

                entity.HasOne(d => d.IdGastosNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdGastos)
                    .HasConstraintName("FK__op_m_opor__id_ga__71D1E811");

                entity.HasOne(d => d.IdGrpecoNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdGrpeco)
                    .HasConstraintName("FK__op_m_opor__id_gr__6D0D32F4");

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK__op_m_opor__id_mo__70DDC3D8");

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdSector)
                    .HasConstraintName("FK__op_m_opor__id_se__6E01572D");

                entity.HasOne(d => d.IdSocgercliNavigation)
                    .WithMany(p => p.OpMOportunidad)
                    .HasForeignKey(d => d.IdSocgercli)
                    .HasConstraintName("FK__op_m_opor__id_so__6B24EA82");

                entity.Property(e => e.erpPresupuesto)
                    .HasColumnName("erp_presupuesto")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.rentabilidad)
                    .HasColumnName("rentabilidad")
                    .HasDefaultValueSql("((0))"); //euscuvil 11-01-2023

                entity.Property(e => e.horasSocio)
                    .HasColumnName("hrs_socio")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasManager)
                    .HasColumnName("hrs_manager")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasSenior)
                    .HasColumnName("hrs_senior")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasStaff)
                    .HasColumnName("hrs_staff")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasTrainee)
                    .HasColumnName("hrs_trainee")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasLider)
                    .HasColumnName("hrs_lider")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.horasSeniormanager)
                    .HasColumnName("hrs_seniormanager")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PorcentajeEjecucion).HasColumnName("percent_ejecucion");
            });

            modelBuilder.Entity<OpMPeriodo>(entity =>
            {
                entity.ToTable("op_m_periodo");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMSector>(entity =>
            {
                entity.ToTable("op_m_sector");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMServicio>(entity =>
            {
                entity.ToTable("op_m_servicio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.IdArea).HasColumnName("id_area");
                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.OpMServicio)
                    .HasForeignKey(d => d.IdArea)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("Fk_id_area_servicio");
            });

            modelBuilder.Entity<OpMSubservicio>(entity =>
            {
                entity.ToTable("op_m_subservicio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMTipoElemento>(entity =>
            {
                entity.ToTable("op_m_tipo_elemento");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .IsRequired()
                    .HasColumnName("descripcion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<OpMTipocambio>(entity =>
            {
                entity.ToTable("op_m_tipocambio");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");

                entity.Property(e => e.TipoCambio)
                    .HasColumnName("tipo_cambio")
                    .HasColumnType("decimal(10, 3)");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdMonedaNavigation)
                    .WithMany(p => p.OpMTipocambio)
                    .HasForeignKey(d => d.IdMoneda)
                    .HasConstraintName("FK__op_m_tipo__id_mo__2A4B4B5E");
            });
            modelBuilder.Entity<OpREaGernt>(entity => {
                entity.ToTable("op_r_eagernt");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");

                entity.Property(e => e.IdEa).HasColumnName("id_ea");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");


                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
                

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");
            });
            modelBuilder.Entity<OpRSocgercli>(entity =>
            {
                entity.ToTable("op_r_socgercli");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");

                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");

                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.IdSocio).HasColumnName("id_socio");

                entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdEmpresaNavigation)
                    .WithMany(p => p.OpRSocgercli)
                    .HasForeignKey(d => d.IdEmpresa)
                    .HasConstraintName("FK__op_r_socg__id_em__5DCAEF64");

                entity.HasOne(d => d.IdGerenteNavigation)
                    .WithMany(p => p.OpRSocgercliIdGerenteNavigation)
                    .HasForeignKey(d => d.IdGerente)
                    .HasConstraintName("FK__op_r_socg__id_ge__5CD6CB2B");

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany(p => p.OpRSocgercli)
                    .HasForeignKey(d => d.IdPeriodo)
                    .HasConstraintName("FK__op_r_socg__id_pe__5AEE82B9");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.OpRSocgercli)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK__op_r_socg__id_se__5EBF139D");

                entity.HasOne(d => d.IdSocioNavigation)
                    .WithMany(p => p.OpRSocgercliIdSocioNavigation)
                    .HasForeignKey(d => d.IdSocio)
                    .HasConstraintName("FK__op_r_socg__id_so__5BE2A6F2");

                entity.HasOne(d => d.IdSubservicioNavigation)
                    .WithMany(p => p.OpRSocgercli)
                    .HasForeignKey(d => d.IdSubservicio)
                    .HasConstraintName("FK__op_r_socg__id_su__5FB337D6");
            });

            modelBuilder.Entity<OpRSocserv>(entity =>
            {
                entity.ToTable("op_r_socserv");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");

                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");

                entity.Property(e => e.IdSocio).HasColumnName("id_socio");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPeriodoNavigation)
                    .WithMany(p => p.OpRSocserv)
                    .HasForeignKey(d => d.IdPeriodo)
                    .HasConstraintName("FK__op_r_socs__id_pe__07C12930");

                entity.HasOne(d => d.IdServicioNavigation)
                    .WithMany(p => p.OpRSocserv)
                    .HasForeignKey(d => d.IdServicio)
                    .HasConstraintName("FK__op_r_socs__id_se__09A971A2");

                entity.HasOne(d => d.IdSocioNavigation)
                    .WithMany(p => p.OpRSocserv)
                    .HasForeignKey(d => d.IdSocio)
                    .HasConstraintName("FK__op_r_socs__id_so__08B54D69");
            });

            modelBuilder.Entity<UsuMArea>(entity =>
            {
                entity.ToTable("usu_m_area");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<UsuMRol>(entity =>
            {
                entity.ToTable("usu_m_rol");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            //INI euscuvil 18-04-2023
            modelBuilder.Entity<OpMFacturacion>(entity =>
            {
                entity.ToTable("op_m_facturacion");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });
            //FIN euscuvil 18-04-2023

            modelBuilder.Entity<UsuMUsuario>(entity =>
            {
                entity.ToTable("usu_m_usuario");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
                    .HasColumnName("descripcion")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DescripcionLarga)
                    .HasColumnName("descripcion_larga")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.FlgAdmin).HasColumnName("flg_admin");

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdAreaNavigation)
                    .WithMany(p => p.UsuMUsuario)
                    .HasForeignKey(d => d.IdArea)
                    .HasConstraintName("FK__usu_m_usu__id_ar__1B0907CE");

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.UsuMUsuario)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__usu_m_usu__id_ro__1A14E395");
            });
            #endregion

            #region View
            modelBuilder.Entity<VWListarTC>(entity =>
            {
                entity.ToTable("Listar_TC");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
                entity.Property(e => e.Descripcion).HasColumnName("descripcion");
                entity.Property(e => e.TipoCambio).HasColumnName("tipo_cambio");
                entity.Property(e => e.UsuCreacion).HasColumnName("usu_creacion");
                entity.Property(e => e.FecCreacion).HasColumnName("fec_creacion");
                entity.Property(e => e.UsuModificacion).HasColumnName("usu_modificacion");
                entity.Property(e => e.FecModificacion).HasColumnName("fec_modificacion");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
            });

            modelBuilder.Entity<VWListarServicio>(entity =>
            {
                entity.ToTable("Listar_Servicio");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.Descripcion).HasColumnName("descripcion");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });

            modelBuilder.Entity<VWListarSubservicio>(entity =>
            {
                entity.ToTable("Listar_Subservicio");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");
                entity.Property(e => e.Descripcion).HasColumnName("descripcion");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
            });

            modelBuilder.Entity<VWListarGerente>(entity =>
            {
                entity.ToTable("Listar_Gerente");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.Descripcion).HasColumnName("nom_gerente");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });

            modelBuilder.Entity<VWListarSocio>(entity =>
            {
                entity.ToTable("Listar_Socio");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.Descripcion).HasColumnName("nom_socio");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });

            modelBuilder.Entity<VWListarGerentexEA>(entity =>
            {
                entity.ToTable("Listar_GerentexEA");
                entity.Property(e => e.IdEa).HasColumnName("id_ea");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.Descripcion).HasColumnName("nom_gerente");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
            });

            modelBuilder.Entity<VWListarOportunidad>(entity =>
            {
                entity.ToTable("Listar_Oportunidad");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.NomSocio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.NomGerente).HasColumnName("nom_gerente");
                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.DetServicio).HasColumnName("det_servicio");
                entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");
                entity.Property(e => e.DetSubservicio).HasColumnName("det_subservicio");
                entity.Property(e => e.IdCondicion).HasColumnName("id_condicion");
                entity.Property(e => e.IdGrpeco).HasColumnName("id_grpeco");
                entity.Property(e => e.IdSector).HasColumnName("id_sector");
                entity.Property(e => e.IdEstado).HasColumnName("id_estado");
                entity.Property(e => e.IdFee).HasColumnName("id_fee");
                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
                entity.Property(e => e.Fee).HasColumnName("fee");
                entity.Property(e => e.Itan).HasColumnName("itan");
                entity.Property(e => e.Overrun).HasColumnName("overrun");
                entity.Property(e => e.TarifHoraria).HasColumnName("tarif_horaria");
                entity.Property(e => e.CantHoras).HasColumnName("cant_horas");
                entity.Property(e => e.TotalMonto).HasColumnName("total_monto");
                entity.Property(e => e.FeeSublinea).HasColumnName("fee_sublinea");
                entity.Property(e => e.TarifHorariaSublinea).HasColumnName("tarif_horaria_sublinea");
                entity.Property(e => e.CantHorasSublinea).HasColumnName("cant_horas_sublinea");
                entity.Property(e => e.TotalSublinea).HasColumnName("total_sublinea");
                entity.Property(e => e.IdGastos).HasColumnName("id_gastos");
                entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");
                entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");
                entity.Property(e => e.Engagement1).HasColumnName("engagement_1");
                entity.Property(e => e.Engagement2).HasColumnName("engagement_2");
                entity.Property(e => e.CompetenciaRdj).HasColumnName("competencia_rdj");
                entity.Property(e => e.QuienGano).HasColumnName("quien_gano");
                entity.Property(e => e.Comentarios).HasColumnName("comentarios");
                entity.Property(e => e.IdRol).HasColumnName("id_rol");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
                entity.Property(e => e.UsuCreacion).HasColumnName("usu_creacion");
                entity.Property(e => e.FecCreacion).HasColumnName("fec_creacion");
                entity.Property(e => e.UsuModificacion).HasColumnName("usu_modificacion");
                entity.Property(e => e.FecModificacion).HasColumnName("fec_modificacion");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
                entity.Property(e => e.Ner).HasColumnName("ner");
                entity.Property(e => e.PsmFlag).HasColumnName("psm_flag");

                entity.Property(e => e.ErpPresupuesto).HasColumnName("erp_presupuesto");
                entity.Property(e => e.Rentabilidad).HasColumnName("rentabilidad");//euscuvil 10-01-2023
                //Inicio euscuvil 14-04-2023
                entity.Property(e => e.eaf).HasColumnName("eaf");
                entity.Property(e => e.margen).HasColumnName("margen");
                entity.Property(e => e.totalHoras).HasColumnName("totalHoras");
                entity.Property(e => e.idOportunidad).HasColumnName("idOportunidad");
                entity.Property(e => e.propuestaFirmada).HasColumnName("propuestaFirmada");
                entity.Property(e => e.numeroPace).HasColumnName("numeroPace");
                entity.Property(e => e.rutaGear).HasColumnName("rutaGear");
                entity.Property(e => e.rutaWorkSpace).HasColumnName("rutaWorkSpace");


                //Fin euscuvil 14-04-2023


                entity.Property(e => e.HorasSocio).HasColumnName("hrs_socio");
                entity.Property(e => e.HorasManager).HasColumnName("hrs_manager");
                entity.Property(e => e.HorasSenior).HasColumnName("hrs_senior");
                entity.Property(e => e.HorasStaff).HasColumnName("hrs_staff");
                entity.Property(e => e.HorasTrainee).HasColumnName("hrs_trainee");

                entity.Property(e => e.HorasLider).HasColumnName("hrs_lider");
                entity.Property(e => e.HorasSeniorManager).HasColumnName("hrs_seniormanager");
            });

            modelBuilder.Entity<VWListarOportunidadXempresa>(entity => 
            {
                entity.ToTable("Listar_OportunidadXempresa");
                entity.Property(e => e.IdPeriodo).HasColumnName("idPeriodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("periodo");
                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdCondicion).HasColumnName("idCondicion");
                entity.Property(e => e.DetCondicion).HasColumnName("condicion");
                entity.Property(e => e.IdGrpeco).HasColumnName("idGrpeco");
                entity.Property(e => e.DetGrpeco).HasColumnName("grpEco");
                entity.Property(e => e.IdSector).HasColumnName("idSector");
                entity.Property(e => e.DetSector).HasColumnName("sector");
                entity.Property(e => e.TotOportEmp).HasColumnName("tot_reg_oport");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
                entity.Property(e => e.Eaf).HasColumnName("eaf");
                entity.Property(e => e.Margen).HasColumnName("margen");
                entity.Property(e => e.TotalHoras).HasColumnName("totalHoras");
                entity.Property(e => e.IdOportunidad).HasColumnName("idOportunidad");
                entity.Property(e => e.PropuestaFirmada).HasColumnName("propuestaFirmada");
                entity.Property(e => e.NumeroPace).HasColumnName("numeroPace");
                entity.Property(e => e.RutaGear).HasColumnName("rutaGear");
                entity.Property(e => e.RutaWorkSpace).HasColumnName("rutaWorkSpace");
            });

            modelBuilder.Entity<VWListarOportunidadXempresaPT>(entity =>
            {
                entity.ToTable("Listar_OportunidadXempresaPT");
                entity.Property(e => e.IdPeriodo).HasColumnName("idPeriodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("periodo");
                entity.Property(e => e.IdEmpresa).HasColumnName("idEmpresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.IdCondicion).HasColumnName("idCondicion");
                entity.Property(e => e.DetCondicion).HasColumnName("condicion");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdGrpeco).HasColumnName("idGrpeco");
                entity.Property(e => e.DetGrpeco).HasColumnName("grpEco");
                entity.Property(e => e.TotOportEmp).HasColumnName("tot_reg_oport");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });

            modelBuilder.Entity<VWListarSocxServ>(entity =>
            {
                entity.ToTable("Listar_SocxServ");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.Descripcion).HasColumnName("det_servicio");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
            });

            modelBuilder.Entity<VWOportunidadEA>(entity =>
            {
                entity.ToTable("Oportunidad_EA");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdEa).HasColumnName("id_ea");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.NomSocio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.NomGerente).HasColumnName("nom_gerente");
                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.DetServicio).HasColumnName("det_servicio");
                entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");
                entity.Property(e => e.DetSubservicio).HasColumnName("det_subservicio");
                entity.Property(e => e.IdCondicion).HasColumnName("id_condicion");
                entity.Property(e => e.IdGrpeco).HasColumnName("id_grpeco");
                entity.Property(e => e.IdSector).HasColumnName("id_sector");
                entity.Property(e => e.IdEstado).HasColumnName("id_estado");
                entity.Property(e => e.IdFee).HasColumnName("id_fee");
                entity.Property(e => e.IdMoneda).HasColumnName("id_moneda");
                entity.Property(e => e.Fee).HasColumnName("fee");
                entity.Property(e => e.Itan).HasColumnName("itan");
                entity.Property(e => e.Overrun).HasColumnName("overrun");
                entity.Property(e => e.TarifHoraria).HasColumnName("tarif_horaria");
                entity.Property(e => e.CantHoras).HasColumnName("cant_horas");
                entity.Property(e => e.TotalMonto).HasColumnName("total_monto");
                entity.Property(e => e.FeeSublinea).HasColumnName("fee_sublinea");
                entity.Property(e => e.TarifHorariaSublinea).HasColumnName("tarif_horaria_sublinea");
                entity.Property(e => e.CantHorasSublinea).HasColumnName("cant_horas_sublinea");
                entity.Property(e => e.TotalSublinea).HasColumnName("total_sublinea");                
                entity.Property(e => e.IdGastos).HasColumnName("id_gastos");
                entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");
                entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");
                entity.Property(e => e.Engagement1).HasColumnName("engagement_1");
                entity.Property(e => e.Engagement2).HasColumnName("engagement_2");
                entity.Property(e => e.CompetenciaRdj).HasColumnName("competencia_rdj");
                entity.Property(e => e.QuienGano).HasColumnName("quien_gano");
                entity.Property(e => e.Comentarios).HasColumnName("comentarios");
                entity.Property(e => e.IdRol).HasColumnName("id_rol");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
                entity.Property(e => e.UsuCreacion).HasColumnName("usu_creacion");
                entity.Property(e => e.FecCreacion).HasColumnName("fec_creacion");
                entity.Property(e => e.UsuModificacion).HasColumnName("usu_modificacion");
                entity.Property(e => e.FecModificacion).HasColumnName("fec_modificacion");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.Ner).HasColumnName("ner");
                entity.Property(e => e.PsmFlag).HasColumnName("psm_flag");

                entity.Property(e => e.ErpPresupuesto).HasColumnName("erp_presupuesto");
                entity.Property(e => e.Rentabilidad).HasColumnName("rentabilidad");//euscuvil 10-01-2023
                entity.Property(e => e.HorasSocio).HasColumnName("hrs_socio");
                entity.Property(e => e.HorasManager).HasColumnName("hrs_manager");
                entity.Property(e => e.HorasSenior).HasColumnName("hrs_senior");
                entity.Property(e => e.HorasStaff).HasColumnName("hrs_staff");
                entity.Property(e => e.HorasTrainee).HasColumnName("hrs_trainee");

                entity.Property(e => e.HorasLider).HasColumnName("hrs_lider");
                entity.Property(e => e.HorasSeniormanager).HasColumnName("hrs_seniormanager");

                entity.Property(e => e.eaf).HasColumnName("eaf");
                entity.Property(e => e.margen).HasColumnName("margen");
                entity.Property(e => e.totalHoras).HasColumnName("totalHoras");
                entity.Property(e => e.idOportunidad).HasColumnName("idOportunidad");
                entity.Property(e => e.propuestaFirmada).HasColumnName("propuestaFirmada");
                entity.Property(e => e.numeroPace).HasColumnName("numeroPace");
                entity.Property(e => e.rutaGear).HasColumnName("rutaGear");
                entity.Property(e => e.rutaWorkSpace).HasColumnName("rutaWorkSpace");
            });

            modelBuilder.Entity<VWReporteGeneral>(entity =>
            {
                entity.ToTable("Reporte_General");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.NomSocio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.NomGerente).HasColumnName("nom_gerente");
                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.DetServicio).HasColumnName("det_servicio");
                entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");
                entity.Property(e => e.DetSubservicio).HasColumnName("det_subservicio");
                entity.Property(e => e.IdCondicion).HasColumnName("id_condicion");
                entity.Property(e => e.DetCondicion).HasColumnName("det_condicion");
                entity.Property(e => e.DetGrpeco).HasColumnName("det_grpeco");
                entity.Property(e => e.DetSector).HasColumnName("det_sector");
                entity.Property(e => e.IdEstado).HasColumnName("id_estado");
                entity.Property(e => e.DetEstado).HasColumnName("det_estado");
                entity.Property(e => e.DetFee).HasColumnName("det_fee");
                entity.Property(e => e.DetMoneda).HasColumnName("det_moneda");
                entity.Property(e => e.Fee).HasColumnName("fee");
                entity.Property(e => e.Itan).HasColumnName("itan");
                entity.Property(e => e.Overrun).HasColumnName("overrun");
                entity.Property(e => e.TarifHoraria).HasColumnName("tarif_horaria");
                entity.Property(e => e.CantHoras).HasColumnName("cant_horas");
                entity.Property(e => e.TotalMonto).HasColumnName("total_monto");
                entity.Property(e => e.FeeSublinea).HasColumnName("fee_sublinea");
                entity.Property(e => e.TarifHorariaSublinea).HasColumnName("tarif_horaria_sublinea");
                entity.Property(e => e.CantHorasSublinea).HasColumnName("cant_horas_sublinea");
                entity.Property(e => e.TotalSublinea).HasColumnName("total_sublinea");
                entity.Property(e => e.DetGastos).HasColumnName("det_gastos");
                entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");
                entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");
                entity.Property(e => e.Engagement1).HasColumnName("engagement_1");
                entity.Property(e => e.Engagement2).HasColumnName("engagement_2");
                entity.Property(e => e.CompetenciaRdj).HasColumnName("competencia_rdj");
                entity.Property(e => e.QuienGano).HasColumnName("quien_gano");
                entity.Property(e => e.Comentarios).HasColumnName("comentarios");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
                entity.Property(e => e.Eaf).HasColumnName("eaf");
                entity.Property(e => e.Margen).HasColumnName("margen");
                entity.Property(e => e.TotalHoras).HasColumnName("totalHoras");
                entity.Property(e => e.IdOportunidad2).HasColumnName("idOportunidad");
                entity.Property(e => e.PropuestaFirmada).HasColumnName("propuestaFirmada");
                entity.Property(e => e.NumeroPace).HasColumnName("numeroPace");
                entity.Property(e => e.RutaGear).HasColumnName("rutaGear");
                entity.Property(e => e.RutaWorkSpace).HasColumnName("rutaWorkSpace");
            });


            #region Reporte cuentas
            modelBuilder.Entity<VWReporteCuentas>(entity =>
            {
                entity.ToTable("Reporte_Cuentas");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.NomSocio).HasColumnName("nom_socio");
                entity.Property(e => e.IdSocio2).HasColumnName("id_socio2");
                entity.Property(e => e.NomSocio2).HasColumnName("nom_socio2");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.NomGerente).HasColumnName("nom_gerente");
                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
                entity.Property(e => e.DetServicio).HasColumnName("det_servicio");
                entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");
                entity.Property(e => e.DetSubservicio).HasColumnName("det_subservicio");
                entity.Property(e => e.DetCondicion).HasColumnName("det_condicion");
                entity.Property(e => e.DetGrpeco).HasColumnName("det_grpeco");
                entity.Property(e => e.DetSector).HasColumnName("det_sector");
                entity.Property(e => e.IdEstado).HasColumnName("id_estado");
                entity.Property(e => e.DetEstado).HasColumnName("det_estado");
                entity.Property(e => e.DetFee).HasColumnName("det_fee");
                entity.Property(e => e.DetMoneda).HasColumnName("det_moneda");
                entity.Property(e => e.Fee).HasColumnName("fee");
                entity.Property(e => e.Itan).HasColumnName("itan");
                entity.Property(e => e.TarifHoraria).HasColumnName("tarif_horaria");
                entity.Property(e => e.CantHoras).HasColumnName("cant_horas");
                entity.Property(e => e.TotalMonto).HasColumnName("total_monto");
                entity.Property(e => e.FeeSublinea).HasColumnName("fee_sublinea");
                entity.Property(e => e.TarifHorariaSublinea).HasColumnName("tarif_horaria_sublinea");
                entity.Property(e => e.CantHorasSublinea).HasColumnName("cant_horas_sublinea");
                entity.Property(e => e.TotalSublinea).HasColumnName("total_sublinea");
                entity.Property(e => e.DetGastos).HasColumnName("det_gastos");
                entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");
                entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");
                entity.Property(e => e.Engagement1).HasColumnName("engagement_1");
                entity.Property(e => e.Engagement2).HasColumnName("engagement_2");
                entity.Property(e => e.CompetenciaRdj).HasColumnName("competencia_rdj");
                entity.Property(e => e.QuienGano).HasColumnName("quien_gano");
                entity.Property(e => e.Comentarios).HasColumnName("comentarios");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });
            #endregion

            #region Reporte cuentas 2
            //modelBuilder.Entity<VWReporteCuentas>(entity =>
            //{
            //    entity.ToTable("Reporte_Cuentas2");
            //    entity.Property(e => e.Id).HasColumnName("id");
            //    entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
            //    entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
            //    entity.Property(e => e.IdSocio).HasColumnName("id_socio");
            //    entity.Property(e => e.NomSocio).HasColumnName("nom_socio");
            //    entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
            //    entity.Property(e => e.NomGerente).HasColumnName("nom_gerente");
            //    entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            //    entity.Property(e => e.Ruc).HasColumnName("ruc");
            //    entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
            //    entity.Property(e => e.IdServicio).HasColumnName("id_servicio");
            //    entity.Property(e => e.DetServicio).HasColumnName("det_servicio");
            //    entity.Property(e => e.IdSubservicio).HasColumnName("id_subservicio");
            //    entity.Property(e => e.DetSubservicio).HasColumnName("det_subservicio");
            //    entity.Property(e => e.DetCondicion).HasColumnName("det_condicion");
            //    entity.Property(e => e.DetGrpeco).HasColumnName("det_grpeco");
            //    entity.Property(e => e.DetSector).HasColumnName("det_sector");
            //    entity.Property(e => e.IdEstado).HasColumnName("id_estado");
            //    entity.Property(e => e.DetEstado).HasColumnName("det_estado");
            //    entity.Property(e => e.DetFee).HasColumnName("det_fee");
            //    entity.Property(e => e.DetMoneda).HasColumnName("det_moneda");
            //    entity.Property(e => e.Fee).HasColumnName("fee");
            //    entity.Property(e => e.Itan).HasColumnName("itan");
            //    entity.Property(e => e.TarifHoraria).HasColumnName("tarif_horaria");
            //    entity.Property(e => e.CantHoras).HasColumnName("cant_horas");
            //    entity.Property(e => e.TotalMonto).HasColumnName("total_monto");
            //    entity.Property(e => e.FeeSublinea).HasColumnName("fee_sublinea");
            //    entity.Property(e => e.TarifHorariaSublinea).HasColumnName("tarif_horaria_sublinea");
            //    entity.Property(e => e.CantHorasSublinea).HasColumnName("cant_horas_sublinea");
            //    entity.Property(e => e.TotalSublinea).HasColumnName("total_sublinea");
            //    entity.Property(e => e.DetGastos).HasColumnName("det_gastos");
            //    entity.Property(e => e.GastosFijos).HasColumnName("gastos_fijos");
            //    entity.Property(e => e.GastosDetalle).HasColumnName("gastos_detalle");
            //    entity.Property(e => e.Engagement1).HasColumnName("engagement_1");
            //    entity.Property(e => e.Engagement2).HasColumnName("engagement_2");
            //    entity.Property(e => e.CompetenciaRdj).HasColumnName("competencia_rdj");
            //    entity.Property(e => e.QuienGano).HasColumnName("quien_gano");
            //    entity.Property(e => e.Comentarios).HasColumnName("comentarios");
            //    entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
            //});
            #endregion

            modelBuilder.Entity<VWListarRelacionOportunidad>(entity =>
            {
                entity.ToTable("Listar_Relacion_Oportunidad");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.NomSocio).HasColumnName("nom_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.NomGerente).HasColumnName("nom_gerente");
                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
                entity.Property(e => e.Ruc).HasColumnName("ruc");
                entity.Property(e => e.RazonSocial).HasColumnName("razon_social");
                entity.Property(e => e.IdArea).HasColumnName("id_area");
            });

            modelBuilder.Entity<VWRelacionServicio>(entity =>
            {
                entity.ToTable("Listar_Relacion_Servicio");
                entity.Property(e => e.Value).HasColumnName("id_servicio");
                entity.Property(e => e.Label).HasColumnName("det_servicio");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.IdSocio).HasColumnName("id_socio");
                entity.Property(e => e.IdGerente).HasColumnName("id_gerente");
                entity.Property(e => e.IdEmpresa).HasColumnName("id_empresa");
            });

            modelBuilder.Entity<VWListarMeta>(entity =>
            {
                entity.ToTable("Listar_Meta");
                entity.Property(e => e.Id).HasColumnName("id");
                entity.Property(e => e.IdPeriodo).HasColumnName("id_periodo");
                entity.Property(e => e.DetPeriodo).HasColumnName("det_periodo");
                entity.Property(e => e.IdUsuario).HasColumnName("id_usuario");
                entity.Property(e => e.Descripcion).HasColumnName("descripcion");
                entity.Property(e => e.IdRol).HasColumnName("id_rol");
                entity.Property(e => e.Meta).HasColumnName("meta");
                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");
            });
            #endregion
        }
    }
}
