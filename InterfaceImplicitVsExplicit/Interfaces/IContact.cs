namespace InterfaceImplicitVsExplicit.Interfaces
{
    interface IContact
    {
        int? PhoneNumber { get; set; }
        bool IsContactAvailable() => PhoneNumber.HasValue;
    }
}
