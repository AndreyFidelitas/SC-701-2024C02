using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IEntrenadoresDA
    {
        public IEnumerable<Entrenadores> ListarEntrenadores();
        public Entrenadores ListarEntrenadores(Guid Entrenador);
    }
}
