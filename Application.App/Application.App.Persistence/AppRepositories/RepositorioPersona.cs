using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioPersona: IRepositorioPersona
    {
        private readonly AppContext _appContext;
        public RepositorioPersona(AppContext appContext)
        {
            _appContext = appContext;
        }

        Perosna IRepositorioPersona.addPersona(Persona p_persona)
        {
            var v_personaNueva  = _appContext.t_personas.Add(persona);
            _appContext.SaveChanges();
            return v_personaNueva.Entity;
        }

        Perosna IRepositorioPersona.uptdatePersona(Persona p_persona)
        {
            var v_busquedaPersona  = _appContext.t_personas.FirstOrDefault(p => p.id == persona.id);
            if(v_busquedaPersona!=null)
            {
                v_busquedaPersona.identificacion=p_persona.Identificacion;
                v_busquedaPersona.identificacion=p_persona.nombre;
                v_busquedaPersona.identificacion=p_persona.apellido;
                v_busquedaPersona.estado=p_persona.estado;
                _appContext.SaveChanges();
            }
            return v_busquedaPersona.Entity;
        }

        Perosna IRepositorioPersona.getPersona(int id)
        {
            v_busquedaPersona = _appContext.personas.FirstOrDefault(p => p.id == id);
            return v_busquedaPersona;
        }

        IEnumerable<Persona> IrepositorioPersona.getAllPersonas()
        {
            return _appContext.Persona;
        }

        Persona IrepositorioPersona.deletePersona(int id)
        {
            v_busquedaPersona = _appContext.personas.FirstOrDefault(p => p.id == id);
            if(v_busquedaPersona)
            {
                _appContext.personas.Remove(v_busquedaPersona);
                _appContext.SaveChanges();
            }
            return v_busquedaPersona;
        }

    }
}
