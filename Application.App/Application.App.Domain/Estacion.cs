using System;

namespace Application.App.Domain{

    public class Estacion{

        public int id{get;set;}
        public string codigoEstacion{get;set;}
        public float latitud{get;set;}
        public float longitud{get;set;}
        public string municipio{get;set;}
        public DateTime fechaMontaje{get;set;}
        public Reporte reporte{get;set;}
        public char estado{get;set;} 
        public TecnicoMantenimineto tecnico{get;set;} 
        public System.Collections.Generic.List<DatoMeteorologico> datos;

    }

}