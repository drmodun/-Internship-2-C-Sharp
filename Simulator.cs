// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;
using System.Runtime.Intrinsics.X86;
using System.Collections.Concurrent;

Console.WriteLine("Hello, World!");
var igraci = new Dictionary<string, (string position, int rating)>();
var table = new Dictionary<string, (int bodovi, int goalDifference)>();
var pozicije = new List<int>();
pozicije.Add(2);    
pozicije.Add(6);    
pozicije.Add(8);
pozicije.Add(5);    
bool Provjera(List<int> poz)
{
    if (poz[1] >= 4 && poz[2] >= 3 && poz[3] >= 3 && poz[0] >= 1)
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
Dictionary<string, (string position, int rating)> StartnaMomcad1(Dictionary<string, (string position, int rating)> rjecnik)
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
void Setup(Dictionary<string, (string position, int rating)> rjecnik, Dictionary<string, (int bodovi, int goalDifference)> tablica)
{
    rjecnik.Add("Luka Modric", ("MF", 88));
    rjecnik.Add("Mateo Kovacic", ("MF", 84));
    rjecnik.Add("Marcelo Brozovic", ("MF", 86));
    rjecnik.Add("Mario Pašalic", ("MF", 81));
    rjecnik.Add("Lovro Majer", ("MF", 80));
    rjecnik.Add("Nikola Vlasic", ("MF", 78));
    rjecnik.Add("Kristijan Jakic", ("MF", 76));
    rjecnik.Add("Luka Sucic", ("MF", 73));
    rjecnik.Add("Ivan Perisic", ("FW", 84));
    rjecnik.Add("Ante Kramaric", ("FW", 82));
    rjecnik.Add("Ante Budimir", ("FW", 76));
    rjecnik.Add("Marko Livaja", ("FW", 77));
    rjecnik.Add("Bruno Petkovic", ("FW", 75));
    rjecnik.Add("Josko Gvardiol", ("DF", 81));
    rjecnik.Add("Dejan Lovren", ("DF", 78));
    rjecnik.Add("Borna Sosa", ("DF", 78));
    rjecnik.Add("Domagoj Vida", ("DF", 76));
    rjecnik.Add("Josip Juranovic", ("DF", 75));
    rjecnik.Add("Josip Stanisic", ("DF", 72));
    rjecnik.Add("Dominik Livakovic", ("GK", 80));
    rjecnik.Add("Ivo Grbic", ("GK", 74));
    tablica.Add("Hrvatska", (0, 0));
    tablica.Add("Maroko", (0, 0));
    tablica.Add("Kanada", (0, 0));
    tablica.Add("Belgija", (0, 0));



}
Setup(igraci, table);
void IspisRjecnik(Dictionary<string, (string position, int rating)> rjecnik1)
{
    foreach (var item in rjecnik1)
    {
        Console.WriteLine($"{item.Key}, pozicija {item.Value.position} i rating {item.Value.rating}");
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
void Utakmica(Dictionary<string, (string position, int rating)> rjecnik, List<int> poz, Dictionary<string, (int bodovi, int goalDifference)> tablica, int opponentNumber)
{
    string[] opponents = new string[] { "Maroko", "Kanada", "Belgija" };
    var opponent= opponents[opponentNumber];
    if (Provjera(poz) == true)
    {
        Console.WriteLine($"Protiv: {opponent}");
        var rand = new Random();
        var momcad = StartnaMomcad(rjecnik);

        var golHome = rand.Next(0, 5);
        var golAway = rand.Next(0, 5);
        var pointsHome = 0;
        var pointsAway = 0;
        if (golHome > golAway)
        {
            pointsHome = 3;
            pointsAway = 0;

            foreach (var item in momcad)
            {
                rjecnik[item.Key] = (item.Value.position, item.Value.rating + (item.Value.rating * 2 / 100));

            }
        }
        else if (golHome < golAway)
        {
            pointsHome = 0;
            pointsAway = 3;
            foreach (var item in momcad)
            {
                rjecnik[item.Key] = (item.Value.position, item.Value.rating - (item.Value.rating * 2 / 100));

            }
        }
        else
        {
            pointsHome = 1;
            pointsAway = 1;
        }
        tablica["Hrvatska"] = (tablica["Hrvatska"].bodovi + pointsHome, tablica["Hrvatska"].goalDifference + (golHome - golAway));
        tablica[opponent] = (tablica[opponent].bodovi + pointsAway, tablica[opponent].goalDifference + (golAway - golHome));
        var golSim = rand.Next(0, 5);
        var golSim2 = rand.Next(0, 5);
        var team1 = "";
        var team2 = "";
        switch (opponentNumber)
        {
            case 0: team1 = opponents[1]; team2 = opponents[2]; break;
            case 1: team1 = opponents[0]; team2 = opponents[2]; break;
            case 2: team1 = opponents[0]; team2 = opponents[1]; break;

        }
        Console.WriteLine($"Drugi rezultati: {team1} protiv {team2}: {golSim} : {golSim2}");
        if (golSim > golSim2)
        {
            pointsHome = 3;
            pointsAway = 0;

            
        }
        else if (golHome < golAway)
        {
            pointsHome = 0;
            pointsAway = 3;
            
        }
        else
        {
            pointsHome = 1;
            pointsAway = 1;
        }
        tablica[team1] = (tablica[team1].bodovi + pointsHome, tablica[team1].goalDifference + (golSim - golSim2));
        tablica[team2] = (tablica[team2].bodovi + pointsAway, tablica[team2].goalDifference + (golSim - golSim2));
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
void Statistika(Dictionary<string, (string position, int rating)> rjecnik, Dictionary<string, (int bodovi, int goalDifference)> tablica)
{
    

    Console.WriteLine("1 - Ispis onako kako su spremljeni");
    Console.WriteLine("2 - Ispis po rating uzlazno");
    Console.WriteLine("3 - Ispis po ratingu silazno");
    Console.WriteLine("4 - Ispis igrača po imenu i prezimenu(ispis pozicije i ratinga)");
    Console.WriteLine("5 - Ispis igrača po ratingu");
    Console.WriteLine("6 - Ispis igrača po poziciji");
    Console.WriteLine("7 - Ispis trenutnih prvih 11 igrača");
    Console.WriteLine("8 - Ispis strijelaca i koliko golova imaju");
    Console.WriteLine("9 - Ispis svih rezultata ekipe");
    Console.WriteLine("10 - Ispis rezultat svih ekipa");
    Console.WriteLine("11 - Ispis tablice grupe");
    var izbor = Console.ReadLine();
    var ratingDict = rjecnik.OrderBy(x => x.Value.rating).ToDictionary(x => x.Key, x => x.Value);
    var ratingDescending = ratingDict.Reverse().ToDictionary(x=> x.Key, x=> x.Value);
    //var nameDict = rjecnik.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);
    switch (izbor)
    {
        case "1":
            IspisRjecnik(rjecnik);
            break;
        case "2":
            
            IspisRjecnik(ratingDict);
            break;
        case "3":
            IspisRjecnik(ratingDescending);
            break;
        case "4":
            Console.WriteLine("Upišite ime i prezime traženog igrača");
            var inputKey=Console.ReadLine();
            var pronađen = 0;
            foreach (var item in rjecnik)
            {
                if (Equals(item.Key.ToString(), inputKey)==true)
                {

                    Console.WriteLine($"{inputKey},  pozicija {rjecnik[inputKey].position} i rating {rjecnik[inputKey].rating}");
                    pronađen++; 
                    break;
                }
                else
                {
                    Console.WriteLine(item.Key + " " + inputKey);
                }

            }
            if (pronađen == 0)
            {
                Console.WriteLine("Igrač nije pronađen");
            }
            break;
        case "5":
            Console.WriteLine("Upišite rating s kojim želite naći igrača");
            var input= Console.ReadLine();
            var puta = 0;
            foreach (var item in rjecnik)
            {
                if (item.Value.rating.ToString() == input)
                {
                    Console.WriteLine($"{item.Key}, pozicija {item.Value.position} i rating {item.Value.rating}");
                    puta++;
                }
            }
            if (puta == 0)
            {
                Console.WriteLine("Nije pronađen nijedan igrač");
            }
            break;
        case "6":
            Console.WriteLine("Upišite poziciju s kojim želite naći igrača");
            var inputPostition = Console.ReadLine();
            var times = 0;
            foreach (var item in rjecnik)
            {
                if (item.Value.position == inputPostition)
                {
                    Console.WriteLine($"{item.Key}, pozicija {item.Value.position} i rating {item.Value.rating}");
                    times++;
                }
            }
            if (times == 0)
            {
                Console.WriteLine("Nije pronađen nijedan igrač");
            }
            break;
        case "7":
            IspisRjecnik(StartnaMomcad(rjecnik));
            break;
        case "8":
            var pos = 1;
            Console.WriteLine("Pozicija   Zemlja   Bodovi   Gol diferenca");
            foreach(var item in tablica)
            {
                Console.WriteLine($"{pos} {item.Key} {item.Value.bodovi} {item.Value.goalDifference}");
                pos++;
            }
            break;
        default:
            Console.WriteLine("Nije validan input");
            break;
        

    }
    Console.WriteLine(" ");
}
StartnaMomcad(igraci);
var kolo = 0;
while (igra == 1)
{
    Console.WriteLine("1 - Odradi trening");
    Console.WriteLine("2 - Odigraj utakmicu");
    Console.WriteLine("3 - Statistika");
    Console.WriteLine("4 - Kontrola igraca");
    Console.WriteLine("0 - Exit");
    Console.WriteLine(" ");
    var choice = Console.ReadLine();
    switch (choice)
    {
        case "1":
            Console.WriteLine(" ");
            Trening(igraci);
            IspisRjecnik(igraci);
            break;
        case "2":
            Console.WriteLine(" ");
            if (kolo < 3)
            {
                Console.WriteLine($"{kolo}");
                Utakmica(igraci, pozicije, table, kolo);
                kolo++;
            }
            else
            {
                Console.WriteLine("Vec su odigrana sva kola");
            }
            break;
        case "3":
            Console.WriteLine(" ");
            Statistika(igraci, table);
            break;

    }

    //igra = 0;
}
