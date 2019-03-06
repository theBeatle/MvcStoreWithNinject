using System.Collections.Generic;

namespace BLL
{
    public interface IMyBll
    {
        ICollection<CountryBll> GetCountriesByConcreteMark(string concreteMark);
        int GetProducersCountByCocncreteMark(string concreteMark);
    }
}