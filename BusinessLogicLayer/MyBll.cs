using DataAccessLayer;
using System.Linq;
using System.Collections.Generic;

namespace BusinessLogicLayer
{
    public class MyBll
    {
        private readonly MyDal dal = new MyDal();

        public int GetProducersCountByConcreteMark(string concreteMark)
        {
            return dal.GetProducersCountByConcreteMark(concreteMark);
        }

        public ICollection<CountryBll> GetCountriesByConcreteMark(string concreteMark)
        {
            return dal.GetCountriesByConcreteMark(concreteMark)
                .Select(c => new CountryBll
                {
                     Id = c.Id,
                     Name = c.Name,
                     ProducersId = c.Producers.Select(p => p.Id).ToList()
                }).ToList();
        }
    }
}
