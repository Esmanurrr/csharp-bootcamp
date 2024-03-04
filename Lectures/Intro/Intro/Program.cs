// See https://aka.ms/new-console-template for more information
using Intro.Business;
using Intro.Entities;

Console.WriteLine("Hello, World!");


string message1 = "Krediler";
int term = 12;
double amount = 100000.5;

//variables --> camelCase
bool isAuthenticated = false;

//condition 
if (isAuthenticated)
{
    Console.WriteLine("Hoşgeldin Engin");
}else
{
    Console.WriteLine("Sisteme giriş yap");
}

string[] loans = { "Kredi 1", "Kredi 2", "Kredi 3", "Kredi 4" };
//string[] loans2 = new string[5];

     //start    condition         increment
for (int i = 0; i < loans.Length; i++)
{
    Console.WriteLine(loans[i]);
}


CourseManager courseManager = new();
Course[] courses = courseManager.GetAll();

for (int i = 0;i < courses.Length; i++)
{
    Console.WriteLine(courses[i].Name + " / " + courses[i].Price);
}


Console.WriteLine("kod bitti");
