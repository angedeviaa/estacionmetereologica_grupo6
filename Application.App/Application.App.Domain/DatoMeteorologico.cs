using System;

namespace Application.App.Domain{
    public class DatoMeteorologico{
        
        public int id{get;set;}
        public DateTime fechaDato{get;set;}
        public float valor{get; set;}
        public TipoDato tipoDato{get;set;}
        public char estado{get;set;} // A:ACTIVO I:INACTIVO
    }
}