using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioAdministrador: IRepositorioAdministrador
    {
        private readonly AppContext _appContext;
        public RepositorioAdministrador(AppContext appContext)
        {
            _appContext = appContext;
        }

        Administrador IRepositorioAdministrador.addAdministrador(Administrador p_administrador)
        {
            var v_administradorNuevo  = _appContext.t_administradores.Add(p_administrador);
            _appContext.SaveChanges();
            return v_administradorNuevo.Entity;
        }

        Administrador IRepositorioAdministrador.updateAdministrador(Administrador p_administrador)
        {
            var v_busquedaAdministrador  = _appContext.t_administradores.FirstOrDefault(a => a.id == p_administrador.id);
            if(v_busquedaAdministrador!=null)
            {
                v_busquedaAdministrador.identificacion=p_administrador.identificacion;
                v_busquedaAdministrador.nombre=p_administrador.nombre;
                v_busquedaAdministrador.apellidos=p_administrador.apellidos;
                v_busquedaAdministrador.estado=p_administrador.estado;
                _appContext.SaveChanges();
            }
            return v_busquedaAdministrador;
        }

        Administrador IRepositorioAdministrador.getAdministrador(int id)
        {
            var v_busquedaAdministrador = _appContext.t_administradores.FirstOrDefault(a => a.id == id);
            return v_busquedaAdministrador;
        }

        IEnumerable<Administrador> IRepositorioAdministrador.getAllAdministradores()
        {
            return _appContext.t_administradores;
        }

        Administrador IRepositorioAdministrador.deleteAdministrador(int id)
        {
            var v_busquedaAdministrador = _appContext.t_administradores.FirstOrDefault(a => a.id == id);
            if(v_busquedaAdministrador != null)
            {
                _appContext.t_administradores.Remove(v_busquedaAdministrador);
                _appContext.SaveChanges();
            }
            return v_busquedaAdministrador;
        }

    }
}
