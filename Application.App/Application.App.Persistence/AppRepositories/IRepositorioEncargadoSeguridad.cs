using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioEncargadoSeguridad
    {
        IEnumerable<EncargadoSeguridad> getAllEncargadosSeguridad();
        EncargadoSeguridad addEncargadoSeguridad(EncargadoSeguridad p_eSeguridad);
        EncargadoSeguridad updateEncargadoSeguridad(EncargadoSeguridad p_eSeguridad);
        EncargadoSeguridad getEncargadoSeguridad(int id);
        EncargadoSeguridad deleteEncargadoSeguridad(int id);
    }
}