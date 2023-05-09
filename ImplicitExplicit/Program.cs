
using System.Linq;

int numOne = 100;
double numOneDouble = numOne; //IMPLICIT


int numTwo = 50;
double numTwoDouble = (double)numTwo; //EXPLICIT


DtoOne dtoOne = new DtoOne("Mike", "Job", 12);
One one = dtoOne; //IMPLICIT

DtoTwo dtoTwo = new DtoTwo("Mike", "Job", 12);
Two two = (Two)dtoTwo; //EXPLICIT

//LIST EXAMPLE
List<DtoOne> dtos = new List<DtoOne>() { dtoOne, dtoOne };
List<One> ones = dtos.Select<DtoOne, One>(x => x).ToList();

List<DtoTwo> dtos2 = new List<DtoTwo>() { dtoTwo, dtoTwo };
List<Two> ones2 = dtos2.Select<DtoTwo, Two>(x => (Two)x).ToList();

record DtoOne(string FirstName, string LastName, int Age);
record One(string FullName, int Age)
{
    public static implicit operator One(DtoOne dto) 
        => new One(dto.FirstName + " " + dto.LastName, dto.Age);
};


record DtoTwo(string FirstName, string LastName, int Age);
record Two(string FullName, int Age)
{
    public static explicit operator Two(DtoTwo dto)
        => new Two(dto.FirstName + " " + dto.LastName, dto.Age);
};