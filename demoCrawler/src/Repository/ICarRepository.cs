using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demoCrawler.src.Repository
{
    internal interface ICarRepository
    {
        Car GetById(int id);
        bool Add(Car car);
        bool Update(Car car);
        bool Delete(int id);
        IEnumerable<Car> GetAll();
    }
}
