namespace DataAccessLayer
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class ConcreteMarket : DbContext
    {
        public ConcreteMarket()
            : base("name=ConcreteMarket")
        {
        }

       

        public virtual DbSet<Concrete> Concretes { get; set; }
    }
}