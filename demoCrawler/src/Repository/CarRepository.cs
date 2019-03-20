using Dapper;
using demoCrawler.src.DbConnection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCrawler.src.Repository
{
    class CarRepository : ICarRepository
    {
        IConnectionFactory _connectionFactory;
        public CarRepository(IConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }

        public bool Add(Car car)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Car> GetAll()
        {
            string querySql = "select * from car;";

            IEnumerable<Car> listResult = _connectionFactory.GetConnection.Query<Car>(querySql).ToList();
            return listResult;
        }

        public Car GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
