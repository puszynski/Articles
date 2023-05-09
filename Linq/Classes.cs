namespace LinqExamples
{
    record User(int Id, string Name, DateTime Created);
    record UserAddress(int Id, int UserId, string Address);
    record UserAddressDTO(int Id, string Name, DateTime Created, string Address);
}
