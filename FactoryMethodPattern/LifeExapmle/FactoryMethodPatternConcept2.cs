using FactoryMethodPattern.LifeExapmle.NotImportant;

namespace FactoryMethodPattern.LifeExapmle
{
    public class OrmRepositoryFactory
    {
        public OrmRepositoryFactory()
        {
        }

        public IUserRepository FactoryMethod(string config)
        {
            switch (config)
            {
                case "EF": return new EntityFrameworkRepository();
                case "Dapper": return new DapperRepository();
                default: throw new Exception("Error! Unknown ORM.");
            }
        }
    }
}
