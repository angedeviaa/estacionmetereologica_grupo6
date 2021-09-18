using Microsoft.EntityFrameworkCore;
using Application.App.Domain;

namespace Application.App.Persistence{

    public class AppContext:DbContext{

        public DbSet<Persona> t_personas{get;set;}
        public DbSet<Estacion> t_estaciones{get;set;}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder){
            if(!optionsBuilder.IsConfigured){
                optionsBuilder.UseSqlServer("Data Source = (localdb)\\MSSQLLocalDB;Initial Catalog=Application1DB");
            }
        }
    }
}