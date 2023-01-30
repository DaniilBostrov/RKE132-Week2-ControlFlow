// See https://aka.ms/new-console-template for more information
using System.Net.Security;

Console.WriteLine("Hello, Daniil!");
//rakendus kysib kasutajal valida tema sugu (m/f)
//rakendus kysib kasutajal sisestada tema perekonna nime
//lahtudes kasutaja valikust rakendus tervitab kasutajat jargmiselt:
//"Welcome, Mr. (Kastutaja perekonnanimi) / Welcome, Ms. (kasutaja perekonnanimi)"

Console.WriteLine("Please select your gender (m/f)");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string(sone) formaadis

Console.WriteLine("Please enter your last name: ");
string userLastName = Console.ReadLine();

if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome, {userLastName} !");
}

