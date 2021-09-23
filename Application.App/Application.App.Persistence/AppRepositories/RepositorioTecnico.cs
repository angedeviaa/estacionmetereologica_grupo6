using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioTecnico:IRepositorioTecnico
    {
        private readonly AppContext _appContext;
        public RepositorioTecnico(AppContext appContext)
        {
            _appContext = appContext;
        }

        TecnicoMantenimineto IRepositorioTecnico.addTecnico(TecnicoMantenimineto p_tecnico)
        {
            var v_tecnicoNuevo  = _appContext.t_tecnicos.Add(p_tecnico);
            _appContext.SaveChanges();
            return v_tecnicoNuevo.Entity;
        }

        TecnicoMantenimineto IRepositorioTecnico.updateTecnico(TecnicoMantenimineto p_tecnico)
        {
            var v_busquedaTecnico  = _appContext.t_tecnicos.FirstOrDefault(p => p.id == p_tecnico.id);
            if(v_busquedaTecnico!=null)
            {
                v_busquedaTecnico.identificacion=p_tecnico.identificacion;
                v_busquedaTecnico.nombre=p_tecnico.nombre;
                v_busquedaTecnico.apellidos=p_tecnico.apellidos;
                v_busquedaTecnico.estado=p_tecnico.estado;
                _appContext.SaveChanges();
            }
            return v_busquedaTecnico;
        }

        TecnicoMantenimineto IRepositorioTecnico.getTecnico(int id)
        {
            var v_busquedaTecnico = _appContext.t_tecnicos.FirstOrDefault(p => p.id == id);
            return v_busquedaTecnico;
        }

        IEnumerable<TecnicoMantenimineto> IRepositorioTecnico.getAllTecnicos()
        {
            return _appContext.t_tecnicos;
        }

        TecnicoMantenimineto IRepositorioTecnico.deleteTecnico(int id)
        {
            var v_busquedaTecnico = _appContext.t_tecnicos.FirstOrDefault(p => p.id == id);
            if(v_busquedaTecnico!=null)
            {
                _appContext.t_tecnicos.Remove(v_busquedaTecnico);
                _appContext.SaveChanges();
            }
            return v_busquedaTecnico;
        }

    }
}
