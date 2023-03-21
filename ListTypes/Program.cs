IEnumerable<int> enumerable;
ICollection<int> collection;
IList<int> iList;
List<int> list;


//RULES - 1 - Accept the most basic type that will work
//https://stackoverflow.com/questions/17170/when-to-use-ilist-and-when-to-use-list

//exampl 1
bool IsValid(IEnumerable<string> items)
{
    foreach (var item in items)
        if (string.IsNullOrEmpty(item))
            return false;

    if (items.Count() < 0 && items.Count() > 10)
        return false;

    return true;
}

//exampl 2
var names = new List<string>() { "Jhon", "Bob" };
AddNewName(names, "Mike");
var count = names.Count();//3

void AddNewName(ICollection<string> names, string newName)
{
    names.Add(newName); //not possible with: IEnumerable
}

//

//exampl 4
void UpdateNames(List<string> names)
{
    names.ForEach(x => x = x.ToUpper()); //modifying not possible with: IEnumerable, ICollection, IList
}




//RULES - 2 - Return the richest type your user will need
//UWAGA DUŻO KRYTYKI - DUŻO OSÓB UWAŻA ŻE TU TEŻ POWNIEN BYĆ PODSTAWOWY TYP
//https://stackoverflow.com/questions/17170/when-to-use-ilist-and-when-to-use-list








//Specyfic things:
//Ienumerable:
IEnumerable<int> enumerable2 = Enumerable.Empty<int>();
enumerable = Enumerable.Repeat(1, 10);
//info - we can only enumerate on it (iterate)
//say something about yield
//example with using in as argument




IQueryable<int> query;