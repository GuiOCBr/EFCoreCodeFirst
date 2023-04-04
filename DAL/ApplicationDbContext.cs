using EFCoreCodeFirst.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreCodeFirst.DAL
{
    public class ApplicationDbContext : DbContext
    {
        // CLASSE DE CONTEXTO É A CLASSE QUE IRÁ MOVIMENTAR OS DADOS DA APLICAÇÃO PARA O BANCO DE DADOS E VICE-VERSA

        public DbSet<Student> Student { get; set; }

        public DbSet<Course> Course { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString: @"Data Source = GOC\SQLExpress; Initial catalog = SchoolDB; Integrated Security = True; TrustServerCertificate=True ");
        }

    }
}
