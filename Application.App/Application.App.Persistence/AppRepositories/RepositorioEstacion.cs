using System;
using System.Link;
using System.Collection.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioEstacion:IRepositorioEstacion
    {
        private readonly AppContext _appContext;
        public RepositorioTecnico(AppContext appContext)
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
                v_busquedaEstacion.codigoEstacion = p_estacion.identificacion;
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

        Estacion IRepositorioEstacion.getAllEstaciones()
        {
            return _appCOntext.t_estaciones;
        }

        Estacion IRepositorioEstacion.deleteEstacion(int id)
        {
            var v_busquedaEstacion = _appContext.t_estaciones.FirstOrDefault(e => e.id == p_estacion.id);
            if(v_busquedaEstacion != null)
            {
                _appCOntext.t_estaciones.Remove(v_busquedaEstacion);
                _appCOntext.SaveChanges();
            }
            return v_busquedaEstacion;
        }
    }
}