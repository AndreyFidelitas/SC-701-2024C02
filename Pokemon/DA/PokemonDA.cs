using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abstracciones.DA;
using Abstracciones.Modelos;
using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using Dapper;

namespace DA
{
    public class PokemonDA : IPokemonDA
    {

        private IRepositorioDapper _r;
        private SqlConnection _conn;

        public PokemonDA(IRepositorioDapper r)
        {
            _r = r;
            _conn = r.ObtenerRepositorio();
        }

        public async Task<IEnumerable<Equipos>> Obtener()
        {
            string value = @"lista";
            var query = await _conn.QueryAsync<Abstracciones.Entidades.Equipos>(value);

            return query;
        }

        public Task<IEnumerable<Equipos>> Obtener(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
