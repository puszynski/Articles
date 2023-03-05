using InterfaceImplicitVsExplicit.Interfaces;

namespace InterfaceImplicitVsExplicit.Classes
{
    class User : IContact, IName
    {
        public int Id { get; set; }


        //implicit interface implementation
        public string FirstName { get; set; }
        public int GetNameLength() => FirstName.Length;


        //explicit interface implementation
        int? IContact.PhoneNumber { get; set; }
    }
}
