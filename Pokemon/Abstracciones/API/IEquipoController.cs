using Abstracciones.Modelos;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.API
{
    public interface IEquipoController
    {
        public Task<IActionResult> ListarEquipos();
        public Task<IActionResult> ListarEquipos(Guid Equipos);
    }
}
