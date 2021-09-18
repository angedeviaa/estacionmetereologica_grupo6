using Microsoft.EntityFrameworkCore;
using Application.App.Domain;

namespace Application.App.Persistence{

    public class AppContext:DbContext{

        public DbSet<Persona> t_tecnicos{get;set;}
        public DbSet<Persona> t_encargadosSeguridad{get;set;}
        public DbSet<Persona> t_administradores{get;set;}
        public DbSet<Estacion> t_estaciones{get;set;}
        public DbSet<Reporte> t_reportes{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=Application1DB");
            }
        }
    }
}