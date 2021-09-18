using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioEstacion
    {
        IEnumerable<Persona> getAllEstaciones();
        Estacion addPersona( Estacion estacion);
        Estacion updateEstacion( Estacion estacion);
        Estacion getEstaciona(int id);
        Estacion deleteEstacion(int id);
    
    }
}
