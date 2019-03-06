using System.Collections.Generic;

namespace DAL
{
    public interface IMyDal
    {
        ICollection<Country> GetCountriesByConcreteMark(string concreteMark);
        int GetProducersCountByConcreteMark(string concreteMark);
    }
}