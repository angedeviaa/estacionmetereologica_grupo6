using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioTecnico: IRepositorioTecnico
    {
        private readonly AppContext _appContext;
        public RepositorioTecnico(AppContext appContext)
        {
            _appContext = appContext;
        }

        Perosna IRepositorioTecnico.addTecnico(Persona p_tecnico)
        {
            var v_tecnicoNuevo  = _appContext.t_tecnicos.Add(p_tecnico);
            _appContext.SaveChanges();
            return v_tecnicoNuevo.Entity;
        }

        Perosna IRepositorioTecnico.uptdatTecnico(Persona p_tecnico)
        {
            var v_busquedaTecnico  = _appContext.t_tecnicos.FirstOrDefault(p => p.id == p_tecnico.id);
            if(v_busquedaTecnico!=null)
            {
                v_busquedaTecnico.identificacion=p_tecnico.Identificacion;
                v_busquedaTecnico.nombre=p_tecnico.nombre;
                v_busquedaTecnico.apellido=p_tecnico.apellido;
                v_busquedaTecnico.estado=p_tecnico.estado;
                _appContext.SaveChanges();
            }
            return v_busquedaTecnico;
        }

        Perosna IRepositorioTecnico.getTecnico(int id)
        {
            v_busquedaTecnico = _appContext.t_tecnicos.FirstOrDefault(p => p.id == id);
            return v_busquedaTecnico;
        }

        IEnumerable<Persona> IRepositorioTecnico.getAllTecnicos()
        {
            return _appContext.t_tecnicos;
        }

        Persona IRepositorioTecnico.deleteTecnico(int id)
        {
            v_busquedaTecnico = _appContext.t_tecnicos.FirstOrDefault(p => p.id == id);
            if(v_busquedaTecnico)
            {
                _appContext.t_tecnicos.Remove(v_busquedaTecnico);
                _appContext.SaveChanges();
            }
            return v_busquedaTecnico;
        }

    }
}
