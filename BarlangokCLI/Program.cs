using BarlangokCLI;
using System.Text;

const string PATH = "C:\\PROJECTS\\CSHARP25011303\\BarlangokCLI\\RESOURCES\\barlangok.txt";
List<Barlang> barlangok = [];

using StreamReader sr = new(PATH, Encoding.UTF8);
_ = sr.ReadLine();
while (!sr.EndOfStream) barlangok.Add(new(sr.ReadLine()));

Console.WriteLine($"4. feladat: barlangok száma: {barlangok.Count}");

var f5 = barlangok
    .Where(b => b.Telepules.StartsWith("Miskolc"))
    .Average(b => b.Melyseg);
Console.WriteLine($"5. feladat: barlangok átlagos mélysége: {f5:0.000} m");

Console.Write("6. feladat: kérem a védettségi szintet: ");
string vsz = Console.ReadLine();
var f6 = barlangok
    .Where(b => b.Vedettseg == vsz)
    .MaxBy(b => b.Hossz);
Console.WriteLine(f6 is null
    ? "\tNincs ilyen védettségi szinttel barlang az adatok közt"
    : f6);

var f7grps = barlangok.GroupBy(b => b.Vedettseg);
foreach (var grp in f7grps)
    Console.WriteLine($"\t{(grp.Key +':').PadRight(
        barlangok.Max(b => b.Vedettseg.Length)+4, '-')}>{grp
        .Count(),4} db");