using FactoryMethodPattern.LifeExapmle.NotImportant;

namespace FactoryMethodPattern.LifeExapmle
{
    public interface ICreator
    {
        public IUserRepository FactoryMethod();
    }
    public class EntityFrameworkRepositoryCreator : ICreator
    {
        public IUserRepository FactoryMethod()
            => new EntityFrameworkRepository();
    }
    public class DapperRepositoryCreator : ICreator
    {
        public IUserRepository FactoryMethod()
            => new DapperRepository();
    }
}
