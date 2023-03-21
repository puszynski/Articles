using FactoryMethodPattern.LifeExapmle;
using FactoryMethodPattern.LifeExapmle.NotImportant;

//CLASSIC CONCEPT & ORM EXAMPLE
var ormConfig = "EF";
ICreator repositoryCreator;

if (ormConfig == "EF") 
    repositoryCreator = new EntityFrameworkRepositoryCreator();
else if (ormConfig == "DAPPER")
    repositoryCreator = new DapperRepositoryCreator();
else
    throw new Exception("Error! Unknown ORM.");

IUserRepository userRepository = repositoryCreator.FactoryMethod();
var users = userRepository.GetAll();





//SIMPLIFY(?) CONCEPT & ORM EXAMPLE - or "STATIC FACTORY METHOD PATTERN"  **NOTE F.M. IS NOT SAME AS S.F.M.
https://stackoverflow.com/questions/929021/what-are-static-factory-methods
var ormConfig2 = "EF";
IUserRepository userRepository2 = StaticCreator.FactoryMethod(ormConfig2);  
var users2 = userRepository2.GetAll();


//FROM OTHER RESOURCES => "STATIC FACTORY METHOD PATTERN"
// Static factory method is simply a static method that return an instance of a class
var foo = Foo.Create();
class Foo
{
    private Foo(){ }
    public static Foo Create() => new Foo(); //but its basic usage example, alternatevly we can create object from subclasses (or implementers of interface)
}
//alternativle, Create method can have more variants with good naming
class Koo
{
    private Koo(bool isMetric) { /*do sth with arg*/ }
    public static Koo CreateForMetricSystem() => new Koo(true);
    public static Koo CreateForImperialSystem() => new Koo(false); //and changeind something here.. 

}
