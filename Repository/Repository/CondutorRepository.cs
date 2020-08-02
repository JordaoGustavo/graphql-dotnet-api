using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Dapper;
using Model.Model;
using Repository.IRepository;

namespace Repository.Repository
{
    public class CondutorRepository : ICondutorRepository
    {
        public Condutor Get(int id)
        {
            string query = @" SELECT
		                            c.CondutorId
	                            ,	c.Nome
	                            ,	c.SobreNome
	                            ,	c.DataNascimento
	                            ,	c.VeiculoId
                                FROM Condutor c
                                WHERE
                                    c.CondutorId = @id
                            ";

            using (var connection = ConnectionFactory.CreateConnection("Desenvolvimento", ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString()))
            {
                return connection.Query<Condutor>(query, id).FirstOrDefault();
            }
        }

        public IEnumerable<Condutor> Get()
        {
            string query = @" SELECT
		                            c.CondutorId
	                            ,	c.Nome
	                            ,	c.SobreNome
	                            ,	c.DataNascimento
	                            ,	c.VeiculoId
                                FROM Condutor c
                            ";

            using (var connection = ConnectionFactory.CreateConnection("Desenvolvimento", ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString()))
            {
                return connection.Query<Condutor>(query);
            }
        }
    }
}
