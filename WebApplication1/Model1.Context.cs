﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using WebApplication1;

    public partial class AnimalDBEntities3 : DbContext
    {
        public AnimalDBEntities3()
            : base("name=AnimalDBEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Amphbian> Amphbians { get; set; }
        public virtual DbSet<Arthropod> Arthropods { get; set; }
        public virtual DbSet<Bird> Birds { get; set; }
        public virtual DbSet<Fish> Fish { get; set; }
        public virtual DbSet<Mammal> Mammals { get; set; }
        public virtual DbSet<Reptile> Reptiles { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<ClassfiedAsEndangered> ClassfiedAsEndangereds { get; set; }
        
    }
}
