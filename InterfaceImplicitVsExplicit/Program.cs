using InterfaceImplicitVsExplicit.Classes;
using InterfaceImplicitVsExplicit.Interfaces;



//implicit interface implementation
    IName secondUser = new User();
    var name = secondUser.FirstName;
    var nameLength = secondUser.GetNameLength();

    User firstUser = new User();
    var name2 = firstUser.FirstName;
    var nameLength2 = firstUser.GetNameLength();



//explicit interface implementation
    IContact fourthUser = new User();
    var number = fourthUser.PhoneNumber;
    var hasContact = fourthUser.IsContactAvailable();

    User thirdUser = new User();
    var number2 = thirdUser.PhoneNumber; //not possible!
    var hasContact2 = thirdUser.IsContactAvailable(); //not possible!

