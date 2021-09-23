using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public class RepositorioReporte: IRepositorioReporte
    {
        private readonly AppContext _appContext;
        public RepositorioReporte(AppContext appContext)
        {
            _appContext = appContext;
        }

        Reporte IRepositorioReporte.addReporte(Reporte p_reporte)
        {
            var v_reporteNuevo  = _appContext.t_reportes.Add(p_reporte);
            _appContext.SaveChanges();
            return v_reporteNuevo.Entity;
        }

        Reporte IRepositorioReporte.updateReporte(Reporte p_reporte)
        {
            var v_busquedaReporte  = _appContext.t_reportes.FirstOrDefault(r => r.id == p_reporte.id);
            if(v_busquedaReporte!=null)
            {
                v_busquedaReporte.descripcion = p_reporte.descripcion;
                v_busquedaReporte.estado = p_reporte.estado;

                _appContext.SaveChanges();
            }
            return v_busquedaReporte;
        }

        Reporte IRepositorioReporte.getReporte(int id)
        {
            var v_busquedaReporte = _appContext.t_reportes.FirstOrDefault(r => r.id == id);
            return v_busquedaReporte;
        }

        IEnumerable<Reporte> IRepositorioReporte.getAllReportes()
        {
            return _appContext.t_reportes;
        }

        Reporte IRepositorioReporte.deleteReporte(int id)
        {
            var v_busquedaReporte = _appContext.t_reportes.FirstOrDefault(r => r.id == id);
            if(v_busquedaReporte != null)
            {
                _appContext.t_reportes.Remove(v_busquedaReporte);
                _appContext.SaveChanges();
            }
            return v_busquedaReporte;
        }

    }
}
