using System;
using System.Linq;
using System.Collections.Generic;
using Application.App.Domain;
namespace Application.App.Persistence
{
    public interface IRepositorioAdministrador
    {
        IEnumerable<Administrador> getAllAdministradores();
        Administrador addAdministrador(Administrador p_Administrador);
        Administrador updateAdministrador(Administrador p_Administrador);
        Administrador getAdministrador(int id);
        Administrador deleteAdministrador(int id);
    
    }
}

