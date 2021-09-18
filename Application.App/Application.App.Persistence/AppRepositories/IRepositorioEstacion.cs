using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioEstacion
    {
        IEnumerable<Estacion> getAllEstaciones();
        Estacion addEstacion( Estacion estacion);
        Estacion updateEstacion( Estacion estacion);
        Estacion getEstacion(int id);
        Estacion deleteEstacion(int id);
    
    }
}
