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
        public IEnumerable<Pokemon> ListarPokemon();
        //Obtener el Pokemon por medio del ID.
        public Pokemon ListarPokemon(Guid Pokemon);
        
    }
}
