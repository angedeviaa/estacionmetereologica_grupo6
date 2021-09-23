using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioReporte
    {
        IEnumerable<Reporte> getAllReportes();
        Reporte addReporte(Reporte p_reporte);
        Reporte updateReporte(Reporte p_reporte);
        Reporte getReporte(int id);
        Reporte deleteReporte(int id);
    
    }
}

