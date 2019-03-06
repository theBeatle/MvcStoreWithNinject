using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MyBll : IMyBll
    {
        private readonly IMyDal dal; // = new MyDal();
        public MyBll(IMyDal dal)
        {
            this.dal = dal;
        }

        public int GetProducersCountByCocncreteMark(string concreteMark)
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
                            ProducersId = c.Producers.Select(p => p.Id).ToArray()
                        }).ToList();
        }
    }
}
