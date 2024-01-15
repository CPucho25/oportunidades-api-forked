using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BF.Models.Staffing
{
    public partial class db_staffing : DbContext
    {
        public db_staffing()
        {
        }

        public db_staffing(DbContextOptions<db_staffing> options)
            : base(options)
        {
        }

        public virtual DbSet<StLSolicitudAuditoria> StLSolicitudAuditoria { get; set; }
        public virtual DbSet<StMAsignacionStaffing> StMAsignacionStaffing { get; set; }
        public virtual DbSet<StMElemento> StMElemento { get; set; }
        public virtual DbSet<StMFinanzas> StMFinanzas { get; set; }
        public virtual DbSet<StMGrupoFormulario> StMGrupoFormulario { get; set; }
        public virtual DbSet<StMPersonal> StMPersonal { get; set; }
        public virtual DbSet<StMRolPersonal> StMRolPersonal { get; set; }
        public virtual DbSet<StMSolicitudStaffing> StMSolicitudStaffing { get; set; }
        public virtual DbSet<StTFormulario> StTFormulario { get; set; }
        public virtual DbSet<StTGte> StTGte { get; set; }
        public virtual DbSet<StTRrhh> StTRrhh { get; set; }
        public virtual DbSet<StTSolicitudHrsStaffing> StTSolicitudHrsStaffing { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=PE2371665W2\\SQLEXPRESS;Database=db_staffing;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity<StLSolicitudAuditoria>(entity =>
            {
                entity.ToTable("st_l_solicitudAuditoria");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesvHorasLider).HasColumnName("desv_horasLider");

                entity.Property(e => e.DesvHorasManager).HasColumnName("desv_horasManager");

                entity.Property(e => e.DesvHorasSenior).HasColumnName("desv_horasSenior");

                entity.Property(e => e.DesvHorasSeniorManager).HasColumnName("desv_horasSeniorManager");

                entity.Property(e => e.DesvHorasSocio).HasColumnName("desv_horasSocio");

                entity.Property(e => e.DesvHorasStaff).HasColumnName("desv_horasStaff");

                entity.Property(e => e.DesvHorasTrainee).HasColumnName("desv_horasTrainee");

                entity.Property(e => e.DesviacionPresupuesto).HasColumnName("desviacion_presupuesto");

                entity.Property(e => e.HrsAcumuladoLider).HasColumnName("hrs_acumuladoLider");

                entity.Property(e => e.HrsAcumuladoManager).HasColumnName("hrs_acumuladoManager");

                entity.Property(e => e.HrsAcumuladoSenior).HasColumnName("hrs_acumuladoSenior");

                entity.Property(e => e.HrsAcumuladoSeniorManager).HasColumnName("hrs_acumuladoSeniorManager");

                entity.Property(e => e.HrsAcumuladoSocio).HasColumnName("hrs_acumuladoSocio");

                entity.Property(e => e.HrsAcumuladoStaff).HasColumnName("hrs_acumuladoStaff");

                entity.Property(e => e.HrsAcumuladoTrainee).HasColumnName("hrs_acumuladoTrainee");

                entity.Property(e => e.IdOportunidad).HasColumnName("id_oportunidad");

                entity.Property(e => e.TnrProyectado).HasColumnName("tnr_proyectado");

                entity.Property(e => e.TnrProyectadoPercent).HasColumnName("tnr_proyectado_percent");

                entity.Property(e => e.TnrYtd).HasColumnName("tnr_ytd");

                entity.Property(e => e.TnrYtdPercent).HasColumnName("tnr_ytd_percent");

                entity.Property(e => e.FecCreacion)
                   .HasColumnName("fec_creacion")
                   .HasColumnType("datetime")
                   .HasDefaultValueSql("(getdate())");         

                entity.Property(e => e.FlgActivo)
                    .HasColumnName("flg_activo")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsuCreacion)
                    .IsRequired()
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");
            });

            modelBuilder.Entity<StMAsignacionStaffing>(entity =>
            {
                entity.ToTable("st_m_asignacion_staffing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.HorasCargables).HasColumnName("horas_cargables");

                entity.Property(e => e.HorasNocargables).HasColumnName("horas_nocargables");

                entity.Property(e => e.IdPersonal).HasColumnName("id_personal");

                entity.Property(e => e.IdSolicitudStaffing).HasColumnName("id_solicitudStaffing");

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdPersonalNavigation)
                    .WithMany(p => p.StMAsignacionStaffing)
                    .HasForeignKey(d => d.IdPersonal)
                    .HasConstraintName("FK__st_m_asig__id_pe__08B54D69");

                entity.HasOne(d => d.IdSolicitudStaffingNavigation)
                    .WithMany(p => p.StMAsignacionStaffing)
                    .HasForeignKey(d => d.IdSolicitudStaffing)
                    .HasConstraintName("FK__st_m_asig__id_so__07C12930");
            });

            modelBuilder.Entity<StMElemento>(entity =>
            {
                entity.ToTable("st_m_elemento");

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

            modelBuilder.Entity<StMFinanzas>(entity =>
            {
                entity.ToTable("st_m_finanzas");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.ErpActual).HasColumnName("erp_actual");

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

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(12)
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

            modelBuilder.Entity<StMGrupoFormulario>(entity =>
            {
                entity.ToTable("st_m_grupo_formulario");

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

            modelBuilder.Entity<StMPersonal>(entity =>
            {
                entity.ToTable("st_m_personal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.Gpn)
                    .HasColumnName("gpn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.IdSocioLider).HasColumnName("id_socioLider");

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.StMPersonal)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__st_m_pers__id_ro__44FF419A");
            });

            modelBuilder.Entity<StMRolPersonal>(entity =>
            {
                entity.ToTable("st_m_rolPersonal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Descripcion)
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

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.IdArea)
                    .HasColumnName("id_area")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Tarifa).HasColumnName("tarifa");

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StMSolicitudStaffing>(entity =>
            {
                entity.ToTable("st_m_solicitud_staffing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Comentario)
                    .HasColumnName("comentario")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesvHorasLider).HasColumnName("desv_horasLider");

                entity.Property(e => e.DesvHorasManager).HasColumnName("desv_horasManager");

                entity.Property(e => e.DesvHorasSenior).HasColumnName("desv_horasSenior");

                entity.Property(e => e.DesvHorasSeniorManager).HasColumnName("desv_horasSeniorManager");

                entity.Property(e => e.DesvHorasSocio).HasColumnName("desv_horasSocio");

                entity.Property(e => e.DesvHorasStaff).HasColumnName("desv_horasStaff");

                entity.Property(e => e.DesvHorasTrainee).HasColumnName("desv_horasTrainee");

                entity.Property(e => e.DesviacionPresupuesto).HasColumnName("desviacion_presupuesto");

                entity.Property(e => e.FecAprobado)
                    .HasColumnName("fec_aprobado")
                    .HasColumnType("datetime");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.FlgAprobado)
                    .HasColumnName("flg_aprobado")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HrsAcumuladoLider).HasColumnName("hrs_acumuladoLider");

                entity.Property(e => e.HrsAcumuladoManager).HasColumnName("hrs_acumuladoManager");

                entity.Property(e => e.HrsAcumuladoSenior).HasColumnName("hrs_acumuladoSenior");

                entity.Property(e => e.HrsAcumuladoSeniorManager).HasColumnName("hrs_acumuladoSeniorManager");

                entity.Property(e => e.HrsAcumuladoSocio).HasColumnName("hrs_acumuladoSocio");

                entity.Property(e => e.HrsAcumuladoStaff).HasColumnName("hrs_acumuladoStaff");

                entity.Property(e => e.HrsAcumuladoTrainee).HasColumnName("hrs_acumuladoTrainee");

                entity.Property(e => e.IdOportunidad).HasColumnName("id_oportunidad");

                entity.Property(e => e.TnrProyectado).HasColumnName("tnr_proyectado");

                entity.Property(e => e.TnrProyectadoPercent).HasColumnName("tnr_proyectado_percent");

                entity.Property(e => e.TnrYtd).HasColumnName("tnr_ytd");

                entity.Property(e => e.TnrYtdPercent).HasColumnName("tnr_ytd_percent");

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StTFormulario>(entity =>
            {
                entity.ToTable("st_t_formulario");

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

                entity.Property(e => e.IdArea).HasColumnName("id_area");

                entity.Property(e => e.IdElemento).HasColumnName("id_elemento");

                entity.Property(e => e.IdGrupo).HasColumnName("id_grupo");

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

                entity.HasOne(d => d.IdElementoNavigation)
                    .WithMany(p => p.StTFormulario)
                    .HasForeignKey(d => d.IdElemento)
                    .HasConstraintName("FK__st_t_form__id_el__66603565");

                entity.HasOne(d => d.IdGrupoNavigation)
                    .WithMany(p => p.StTFormulario)
                    .HasForeignKey(d => d.IdGrupo)
                    .HasConstraintName("FK__st_t_form__id_gr__6754599E");
            });

            modelBuilder.Entity<StTGte>(entity =>
            {
                entity.ToTable("st_t_gte");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("date");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.Gpn)
                    .HasColumnName("gpn")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.HorasCargadas).HasColumnName("horas_cargadas");

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StTRrhh>(entity =>
            {
                entity.ToTable("st_t_rrhh");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.HorasNocargables).HasColumnName("horas_nocargables");

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<StTSolicitudHrsStaffing>(entity =>
            {
                entity.ToTable("st_t_solicitud_hrsStaffing");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FecCreacion)
                    .HasColumnName("fec_creacion")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.FecModificacion)
                    .HasColumnName("fec_modificacion")
                    .HasColumnType("datetime");

                entity.Property(e => e.FechaSolicitud)
                    .HasColumnName("fecha_solicitud")
                    .HasColumnType("datetime");

                entity.Property(e => e.FlgActivo).HasColumnName("flg_activo");

                entity.Property(e => e.HorasSolicitud).HasColumnName("horas_solicitud");

                entity.Property(e => e.IdRol).HasColumnName("id_rol");

                entity.Property(e => e.IdSolicitudStaffing).HasColumnName("id_solicitudStaffing");

                entity.Property(e => e.UsuCreacion)
                    .HasColumnName("usu_creacion")
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('digitaltax')");

                entity.Property(e => e.UsuModificacion)
                    .HasColumnName("usu_modificacion")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdRolNavigation)
                    .WithMany(p => p.StTSolicitudHrsStaffing)
                    .HasForeignKey(d => d.IdRol)
                    .HasConstraintName("FK__st_t_soli__id_ro__403A8C7D");

                entity.HasOne(d => d.IdSolicitudStaffingNavigation)
                    .WithMany(p => p.InverseIdSolicitudStaffingNavigation)
                    .HasForeignKey(d => d.IdSolicitudStaffing)
                    .HasConstraintName("FK__st_t_soli__id_so__3F466844");
            });
        }
    }
}
