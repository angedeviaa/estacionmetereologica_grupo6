using System;
using System.Collections.Generic;

namespace Application.App.Domain{

    
    public class Reporte{
        public string id{get;set;}
        public string descripcion{get;set;}
        public List<TipoReporte> tiposReposte{get;set;}
         public char estado{get;set;} 
    }
}