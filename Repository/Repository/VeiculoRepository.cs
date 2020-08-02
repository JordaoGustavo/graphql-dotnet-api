using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Dapper;
using Model.Model;
using Repository.Extension;
using Repository.IRepository;

namespace Repository.Repository
{
    public class VeiculoRepository : IVeiculoRepository
    {
        public Veiculo Get(int id)
        {
            string query = @" SELECT
                                 	v.VeiculoId	
	                            ,	v.Modelo
	                            ,	v.Cor
	                            ,	v.AnoFabricacao
	                            ,	v.Hodometro
                                FROM Veiculo v
                                WHERE
                                    v.VeiculoId = @id
                            ";

            using (var connection = ConnectionFactory.CreateConnection("Desenvolvimento", ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString()))
            {
                return connection.Query<Veiculo>(query, id).FirstOrDefault();
            }
        }

        public IEnumerable<Veiculo> Get()
        {
            string query = @" SELECT
                                 	v.VeiculoId	
	                            ,	v.Modelo
	                            ,	v.Cor
	                            ,	v.AnoFabricacao
	                            ,	v.Hodometro
                                FROM Veiculo v
                            ";

            using (var connection = ConnectionFactory.CreateConnection("Desenvolvimento", ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString()))
            {
                return connection.Query<Veiculo>(query);
            }
        }

        public IEnumerable<Veiculo> Get(IEnumerable<int> veiculosId)
        {
            var tvp = veiculosId.ToDataTable();

            string query = @" SELECT
                                 	v.VeiculoId	
	                            ,	v.Modelo
	                            ,	v.Cor
	                            ,	v.AnoFabricacao
	                            ,	v.Hodometro
                                FROM Veiculo v
                                    INNER JOIN @tvp tvp ON tvp.id = v.veiculoId
                            ";

            using (var connection = ConnectionFactory.CreateConnection("Desenvolvimento", ConfigurationManager.ConnectionStrings["DbConnection"].ConnectionString.ToString()))
            {
                return connection.Query<Veiculo>(query, new { tvp = tvp.AsTableValuedParameter("GenericTvp") });
            }
        }
    }
}
