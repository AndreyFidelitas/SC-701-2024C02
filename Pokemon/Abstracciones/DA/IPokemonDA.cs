using Abstracciones.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstracciones.DA
{
    public interface IPokemonDA
    {
        //Listar los Pokemones
        public Task<IEnumerable<Equipos>> Obtener();
        public Task<IEnumerable<Equipos>> Obtener(Guid id);

    }
}
