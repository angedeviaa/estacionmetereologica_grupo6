using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioEstacion
    {

        Estacion addEstacion( Estacion estacion);
        Estacion updateEstacion( Estacion estacion);
        Estacion getEstacion(int id);
        IEnumerable<Estacion> getAllEstaciones();
        Estacion deleteEstacion(int id);
    
    }
}
