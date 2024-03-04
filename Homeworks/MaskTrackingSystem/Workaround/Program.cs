// See https://aka.ms/new-console-template for more information


using Business.Concrete;
using Entities.Concrete;

public class Program
{
    private static void Main(string[] args)
    { 

        Person person = new Person();
        person.Name = "ENGİN";
        person.LastName = "DEMİROĞ";
        person.BirthDate = 1985;
        person.IdentityNumber = 123;

        PttManager pttManager = new(new PersonManager());
        pttManager.GiveMask(person);

    }

    static void SelamVer()
    {
        Console.WriteLine("Merhaba");
    }

}