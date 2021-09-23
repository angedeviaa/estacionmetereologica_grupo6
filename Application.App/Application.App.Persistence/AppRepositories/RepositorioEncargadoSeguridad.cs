using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioEncargadoSeguridad:IRepositorioEncargadoSeguridad
    {
        private readonly AppContext _appContext;
        public RepositorioEncargadoSeguridad(AppContext appContext)
        {
            _appContext = appContext;
        }

        EncargadoSeguridad IRepositorioEncargadoSeguridad.addEncargadoSeguridad(EncargadoSeguridad p_eSeguridad)
        {
            var v_eSeguridadNuevo  = _appContext.t_encargadosSeguridad.Add(p_eSeguridad);
            _appContext.SaveChanges();
            return v_eSeguridadNuevo.Entity;
        }

        EncargadoSeguridad IRepositorioEncargadoSeguridad.updateEncargadoSeguridad(EncargadoSeguridad p_eSeguridad)
        {
            var v_busquedaESeguridad  = _appContext.t_encargadosSeguridad.FirstOrDefault(es => es.id == p_eSeguridad.id);
            if(v_busquedaESeguridad!=null)
            {
                v_busquedaESeguridad.identificacion=p_eSeguridad.identificacion;
                v_busquedaESeguridad.nombre=p_eSeguridad.nombre;
                v_busquedaESeguridad.apellidos=p_eSeguridad.apellidos;
                v_busquedaESeguridad.estado=p_eSeguridad.estado;
                _appContext.SaveChanges();
            }
            return v_busquedaESeguridad;
        }

        EncargadoSeguridad IRepositorioEncargadoSeguridad.getEncargadoSeguridad(int id)
        {
            var v_busquedaESeguridad = _appContext.t_encargadosSeguridad.FirstOrDefault(es => es.id == id);
            return v_busquedaESeguridad;
        }

        IEnumerable<EncargadoSeguridad> IRepositorioEncargadoSeguridad.getAllEncargadosSeguridad()
        {
            return _appContext.t_encargadosSeguridad;
        }

        EncargadoSeguridad IRepositorioEncargadoSeguridad.deleteEncargadoSeguridad(int id)
        {
            var v_busquedaESeguridad = _appContext.t_encargadosSeguridad.FirstOrDefault(es => es.id == id);
            if(v_busquedaESeguridad != null)
            {
                _appContext.t_encargadosSeguridad.Remove(v_busquedaESeguridad);
                _appContext.SaveChanges();
            }
            return v_busquedaESeguridad;
        }

    }
}
