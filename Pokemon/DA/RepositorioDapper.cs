using Abstracciones.DA;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace DA
{
    public class RepositorioDapper : IRepositorioDapper
    {
        private readonly IConfiguration _configuration;

        public SqlConnection _conexionDB {  get;}

        public RepositorioDapper(IConfiguration configuration)
        { 
            _configuration = configuration;
            _conexionDB = new SqlConnection(_configuration.GetConnectionString("conexion"));
        }

        public SqlConnection ObtenerRepositorio()
        {
            return _conexionDB;
        }
    }
}
