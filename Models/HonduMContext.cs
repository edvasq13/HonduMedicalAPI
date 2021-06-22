using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;



namespace HonduMedicalAPI.Models
{
    class HonduMContext : DbContext
    {
        public DbSet<Login> Login { get; set; }
        public DbSet<ConsultaCita> CCita { get; set; }
        public DbSet<TablaDrs> TDrs { get; set; }

        public string connectionString = @"Data Source=DESKTOP-J1R3GA0\SQLEXPRESS;Initial Catalog=HospitalDB;Integrated Security=True";
        protected override void OnConfiguring(DbContextOptionsBuilder options)
          => options.UseSqlServer(connectionString);
    }
}
