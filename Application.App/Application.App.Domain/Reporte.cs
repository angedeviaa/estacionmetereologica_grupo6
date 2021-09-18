using System;
using System.Collections.Generic;

namespace Application.App.Domain{
    
    public class Reporte
    {
        public string id{get;set;}
        public string descripcion{get;set;}
        public DateTime fechaCreacion{get;set}
        public List<TipoReporte> tiposReporte{get;set;}
        public char estado{get;set;} // A:ACTIVO I:INACTIVO
        public int tecnicoEncargado{get;set;} // Id del tecnico responsable de la creacion del reporte
    }
}