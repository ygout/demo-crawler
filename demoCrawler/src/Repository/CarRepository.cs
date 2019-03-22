using Dapper;
using demoCrawler.src.DbConnection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

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
            string querySql = "insert into car values (@Id, @Model, @Price, @Link, @ImageUrl)";
            try
            {
                _connectionFactory.GetConnection.Execute(querySql, car);
                
            }catch (Exception exception)
            {
                Console.WriteLine(exception);
                return false;
            }
            return true;
        }

        public bool AddCars(List<Car> cars)
        {
            string querySql = "insert into car values (@Id, @Model, @Price, @Link, @ImageUrl)";
            IDbTransaction trans = _connectionFactory.GetConnection.BeginTransaction();
            try
            {
                _connectionFactory.GetConnection.Execute(querySql, cars, transaction: trans);
                trans.Commit();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                return false;
            }
            return true;
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
