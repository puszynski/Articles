namespace FactoryMethodPattern.LifeExapmle.NotImportant
{
    public interface IUserRepository
    {
        User GetById(int id);
        User GetByUserName(string userName);
        IEnumerable<User> GetAll();
    }
}
