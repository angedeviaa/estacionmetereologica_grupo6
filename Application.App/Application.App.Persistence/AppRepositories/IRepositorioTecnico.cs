using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioTecnico
    {
        IEnumerable<TecnicoMantenimineto> getAllTecnicos();
        TecnicoMantenimineto addTecnico(TecnicoMantenimineto p_tecnico);
        TecnicoMantenimineto updateTecnico(TecnicoMantenimineto p_tecnico);
        TecnicoMantenimineto getTecnico(int id);
        TecnicoMantenimineto deleteTecnico(int id);
    
    }
}

