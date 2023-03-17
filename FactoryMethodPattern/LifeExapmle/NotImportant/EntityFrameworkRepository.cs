namespace FactoryMethodPattern.LifeExapmle.NotImportant
{
    public class EntityFrameworkRepository : IUserRepository
    {
        private readonly EntityFrameworkDataContext _entityFrameworkDataContext;
        public EntityFrameworkRepository()
            => _entityFrameworkDataContext = new EntityFrameworkDataContext();

        public IEnumerable<User> GetAll()
            => _entityFrameworkDataContext.Users.ToList();

        public User GetById(int id)
            => _entityFrameworkDataContext.Users.SingleOrDefault(x => x.Id == id);

        public User GetByUserName(string userName)
            => _entityFrameworkDataContext.Users.SingleOrDefault(x => x.Name == userName);
    }
}
