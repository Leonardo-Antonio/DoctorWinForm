﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Doctor.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class db_clinicEntities1 : DbContext
    {
        public db_clinicEntities1()
            : base("name=db_clinicEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_appointment> tb_appointment { get; set; }
        public virtual DbSet<tb_cashier> tb_cashier { get; set; }
        public virtual DbSet<tb_clinic_history> tb_clinic_history { get; set; }
        public virtual DbSet<tb_contrareferencia> tb_contrareferencia { get; set; }
        public virtual DbSet<tb_diagnosis> tb_diagnosis { get; set; }
        public virtual DbSet<tb_district> tb_district { get; set; }
        public virtual DbSet<tb_doctor> tb_doctor { get; set; }
        public virtual DbSet<tb_gender> tb_gender { get; set; }
        public virtual DbSet<tb_health_insurance> tb_health_insurance { get; set; }
        public virtual DbSet<tb_hour> tb_hour { get; set; }
        public virtual DbSet<tb_marital_status> tb_marital_status { get; set; }
        public virtual DbSet<tb_patient> tb_patient { get; set; }
        public virtual DbSet<tb_proof_of_purchase> tb_proof_of_purchase { get; set; }
        public virtual DbSet<tb_receptionist> tb_receptionist { get; set; }
        public virtual DbSet<tb_speciality> tb_speciality { get; set; }
        public virtual DbSet<tb_turn> tb_turn { get; set; }
        public virtual DbSet<tb_type_identification> tb_type_identification { get; set; }
    }
}
