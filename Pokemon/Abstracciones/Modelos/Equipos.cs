﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.Modelos
{
    public class Equipos
    {
        public Guid IdEquipo { get; set; }
        public Guid IdEntrenador { get; set; }
        public string? Nombre { get; set; }
    }
}