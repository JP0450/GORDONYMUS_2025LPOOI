﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_clase
{
    internal class Persona
    {
        public string Nombre { get; set; }
        

        public Persona(string nombre)
        {
            this.Nombre = nombre;
            
        }
        public override string ToString()
        {
            return $"Nombre: {Nombre}";
        }
    }
}
