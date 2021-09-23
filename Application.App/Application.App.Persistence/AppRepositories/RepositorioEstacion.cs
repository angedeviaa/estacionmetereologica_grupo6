using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioEstacion: IRepositorioEstacion
    {
        private readonly AppContext _appContext;
        public RepositorioEstacion(AppContext appContext)
        {
            _appContext = appContext;
   
        }

        Estacion IRepositorioEstacion.addEstacion(Estacion p_estacion)
        {
            var v_estacionNueva = _appContext.t_estaciones.Add(p_estacion);
            _appContext.SaveChanges();
            return v_estacionNueva.Entity;
        }

        Estacion IRepositorioEstacion.updateEstacion(Estacion p_estacion)
        {
            var v_busquedaEstacion = _appContext.t_estaciones.FirstOrDefault(e => e.id == p_estacion.id);

            if(v_busquedaEstacion != null)
            {
                v_busquedaEstacion.codigoEstacion = p_estacion.codigoEstacion;
                v_busquedaEstacion.latitud = p_estacion.latitud;
                v_busquedaEstacion.longitud = p_estacion.longitud;
                v_busquedaEstacion.tecnico = p_estacion.tecnico;
                v_busquedaEstacion.encargadoSeguridad = p_estacion.encargadoSeguridad;
                v_busquedaEstacion.admin = p_estacion.admin;
                v_busquedaEstacion.estado = p_estacion.estado;
                _appContext.SaveChanges();
            }
            return v_busquedaEstacion;
        }

        Estacion IRepositorioEstacion.getEstacion(int id)
        {
            var v_busquedaEstacion = _appContext.t_estaciones.FirstOrDefault(e => e.id == id);
            return v_busquedaEstacion;
        }

        IEnumerable<Estacion> IRepositorioEstacion.getAllEstaciones()
        {
            return _appContext.t_estaciones;
        }

        Estacion IRepositorioEstacion.deleteEstacion(int id)
        {
            var v_busquedaEstacion = _appContext.t_estaciones.FirstOrDefault(e => e.id == id);
            if(v_busquedaEstacion != null)
            {
                _appContext.t_estaciones.Remove(v_busquedaEstacion);
                _appContext.SaveChanges();
            }
            return v_busquedaEstacion;
        }
    }
}