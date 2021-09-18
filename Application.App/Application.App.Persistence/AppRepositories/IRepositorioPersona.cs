using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioPersona
    {
        IEnumerable<Persona> getAllPersonas();
        Persona addPersona(Persona persona);
        Persona updatePersona(Persona persona);
        Persona getPersona(int id);
        Persona deletePersona(int id);
    
    }
}
