// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;

Console.WriteLine("Hello, World!");
var igraci = new Dictionary<string, (string position, int rating)>();
var status = new Dictionary<string, int>();


bool Provjera(Dictionary<string, int> poz)
{
    if (poz["DF"] >= 4 && poz["MF"] >= 3 && poz["FW"] >= 3 && poz["GK"] >= 1)
    {
        return true;
    }
    else
    {
        return false;
    }
}
Dictionary<string, (string position, int rating)> StartnaMomcad(Dictionary<string, (string position, int rating)> rjecnik)
{
    var sortedDict = rjecnik.OrderBy(x => x.Value.rating).ToDictionary(x => x.Key, x => x.Value);
    var momcadDict = new Dictionary<string, (string position, int rating)>();
    foreach (var item in sortedDict.Reverse())
    {
        if (item.Value.position == "GK")
        {
            momcadDict.Add(item.Key, item.Value);
            sortedDict.Remove(item.Key);
            break;
        }
    }
    for (int i = 0; i < 4; i++)
    {
        foreach (var item in sortedDict.Reverse())
        {
            if (item.Value.position == "DF")
            {
                momcadDict.Add(item.Key, item.Value);
                sortedDict.Remove(item.Key);
                break;
            }
        }
    }
    for (int i = 0; i < 3; i++)
    {
        foreach (var item in sortedDict.Reverse())
        {
            if (item.Value.position == "MF")
            {
                momcadDict.Add(item.Key, item.Value);
                sortedDict.Remove(item.Key);
                break;
            }
        }
    }
    for (int i = 0; i < 3; i++)
    {
        foreach (var item in sortedDict.Reverse())
        {
            if (item.Value.position == "FW")
            {
                momcadDict.Add(item.Key, item.Value);
                sortedDict.Remove(item.Key);
                break;
            }
        }
    }
    //IspisRjecnik(momcadDict);
    return momcadDict;
}
{

}
void DodajIgrace(Dictionary<string, (string position, int rating)> rjecnik)
{
    rjecnik.Add("Luka Modrić", ("MF", 88));
    rjecnik.Add("Mateo Kovačić", ("MF", 84));
    rjecnik.Add("Marcelo Brozović", ("MF", 86));
    rjecnik.Add("Mario Pašalić", ("MF", 81));
    rjecnik.Add("Lovro Majer", ("MF", 80));
    rjecnik.Add("Nikola Vlašić", ("MF", 78));
    rjecnik.Add("Kristijan Jakić", ("MF", 76));
    rjecnik.Add("Luka Sučić", ("MF", 73));
    rjecnik.Add("Ivan Peričić", ("FW", 84));
    rjecnik.Add("Ante Kramarić", ("FW", 82));
    rjecnik.Add("Ante Budimir", ("FW", 76));
    rjecnik.Add("Marko Livaja", ("FW", 77));
    rjecnik.Add("Bruno Petković", ("FW", 75));
    rjecnik.Add("Joško Gvardiol", ("DF", 81));
    rjecnik.Add("Dejan Lovren", ("DF", 78));
    rjecnik.Add("Borna Sosa", ("DF", 78));
    rjecnik.Add("Domagoj Vida", ("DF", 76));
    rjecnik.Add("Josip Juranović", ("DF", 75));
    rjecnik.Add("Josip Stanišić", ("DF", 72));
    rjecnik.Add("Dominik Livaković", ("GK", 80));
    rjecnik.Add("Ivo Grbić", ("GK", 74));


}
DodajIgrace(igraci);
void IspisRjecnik(Dictionary<string, (string position, int rating)> rjecnik1)
{
    foreach (var item in rjecnik1)
    {
        Console.WriteLine($"Kljuc {item.Key}, item {item.Value}");
    }
    Console.WriteLine(" ");
}
IspisRjecnik(igraci);
var igra = 1;
void Trening(Dictionary<string, (string position, int rating)> rjecnik)
{
    var rand = new Random();

    foreach (var item in rjecnik)
    {
        int napredak = rand.Next(-5, 5);
        rjecnik[item.Key] = (item.Value.position, item.Value.rating + (item.Value.rating * napredak / 100));


    }
}
void Utakmica(Dictionary<string, (string position, int rating)> rjecnik, Dictionary<string, int> poz)
{
    if (1 == 1)//Popravi provjeru Provjera(poz) == true)
    {
        var rand = new Random();
        var momcad = StartnaMomcad(rjecnik);
        var golHome = rand.Next(0, 5);
        var golAway = rand.Next(0, 5);
        if (golHome > golAway)
        {
            //Napravi tablicu
            var tablica = 0;
            foreach (var item in momcad)
            {
                rjecnik[item.Key] = (item.Value.position, item.Value.rating + (item.Value.rating * 2 / 100));

            }
        }
        else if (golHome < golAway)
        {
            //Napravi tablicu
            var tablica = 0;
            foreach (var item in momcad)
            {
                rjecnik[item.Key] = (item.Value.position, item.Value.rating - (item.Value.rating * 2 / 100));

            }
        }
        for (int i = 0; i < golHome; i++)
        {
            var strijelac = rand.Next(0, 11);
            var popis = momcad.Keys.ToList();
            rjecnik[popis[strijelac]] = (rjecnik[popis[strijelac]].position, rjecnik[popis[strijelac]].rating + (rjecnik[popis[strijelac]].rating * 5 / 100));
            Console.WriteLine($"Strijelac je {popis[strijelac]}");

        }
        Console.WriteLine($"{golHome} : {golAway}");
        IspisRjecnik(momcad);
        IspisRjecnik(rjecnik);
    }
    else
    {
        Console.WriteLine("Nije eligiblno igrati utamkicu");
    }
}
StartnaMomcad(igraci);

while (igra == 1)
{
    Console.WriteLine("1 - Odradi trening");
    Console.WriteLine("2 - Odigraj utakmicu");
    Console.WriteLine("3 - Statistika");
    Console.WriteLine("4 - Kontrola igraca");
    Console.WriteLine("0 - Exit");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Trening(igraci);
            IspisRjecnik(igraci);
            break;
        case "2":
            Utakmica(igraci, status);
            break;
    }

    //igra = 0;
}
