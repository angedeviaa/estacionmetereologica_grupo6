using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioTecnico
    {
        IEnumerable<Persona> getAllTecnicos();
        Persona addTecnico(Persona p_tecnico);
        Persona updateTecnico(Persona p_tecnico);
        Persona getTecnico(int id);
        Persona deleteTecnico(int id);
    
    }
}

