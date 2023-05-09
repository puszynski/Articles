using LinqExamples;

var users = new List<User>
{
    new User(1, "A", DateTime.Now.AddYears(-10)),
    new User(2, "B", DateTime.Now.AddYears(-9)),
    new User(3, "C", DateTime.Now.AddYears(-8)),
    new User(4, "D", DateTime.Now.AddYears(-7)),
    new User(5, "E", DateTime.Now.AddYears(-6)),
    new User(6, "F", DateTime.Now.AddYears(-5))
};

var userAddresses = new List<UserAddress>
{
    new UserAddress(1, 1, "Address A"),
    new UserAddress(2, 2, "Address B"),
    new UserAddress(3, 3, "Address C"),
    new UserAddress(4, 4, "Address D")
};

var joinResult3 = users.Join(
    userAddresses,
    x => x.Id,
    y => y.UserId,
    (x, y) => new UserAddressDTO(x.Id, x.Name, x.Created, y.Address));




