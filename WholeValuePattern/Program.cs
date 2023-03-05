class User
{
    public int Id { get; set; }
    public Name Name { get; set; }
    public Address Address { get; set; }
}

class Name
{
    public string FirstName { get; set; }
    public string? MiddleName { get; set; }
    public string LastName { get; set; }
    public string GetFullName() 
        => $"{FirstName}({MiddleName ?? string.Empty}) {LastName}";
}

class Address
{
    public string StreetName { get; set; }
    public int HomeNumber { get; set; }
    public string City { get; set; }
    public string CityCode { get; set; }
    public string Country { get; set; }
}