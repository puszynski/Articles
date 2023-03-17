using FactoryMethodPattern.LifeExapmle.NotImportant;

namespace FactoryMethodPattern.LifeExapmle
{
    // level 0
    public class StaticPseudoFactory
    {
        private StaticPseudoFactory() { }
        public static StaticPseudoFactory FactoryMethod() => new StaticPseudoFactory();
    }


    // normal use
    public class StaticCreator
    {
        public static IUserRepository FactoryMethod(string config)
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
