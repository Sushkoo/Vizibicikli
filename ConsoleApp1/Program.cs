using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Program
	{
		static List<Kolcsonzes> lista = new List<Kolcsonzes>();
		static void Main(string[] args)
		{
			StreamReader sr = new StreamReader("kolcsonzesek.txt");

			sr.ReadLine();

			while (!sr.EndOfStream)
			{
				var mezok = sr.ReadLine().Split(';');

				Kolcsonzes uj = new Kolcsonzes(mezok[0], mezok[1][0], int.Parse(mezok[2]), int.Parse(mezok[3]), int.Parse(mezok[4]), int.Parse(mezok[5]));
			}
			sr.Close();

			//5.
			Console.WriteLine($"5.feladat: Napi kölcsönzések száma: {lista.Count}");

			//6.
			string nev = Console.ReadLine();
			Console.WriteLine("6.feladat: Kérek egy nevet:");
			Console.WriteLine(nev);
			Console.WriteLine($"\t {nev} kölcsönzései:");


			if (lista.Count(x => x.Nev == nev) == 0)
			{
				Console.WriteLine("Nem volt ilyen kölcsönző!");
			}
			else
			{
				lista.Where(x => x.Nev == nev)
				.ToList()
				.ForEach(x => Console.WriteLine($"\t{x.EOra}:{x.EPerc}-{x.VOra}:{x.VPerc}"));
			}
			//7.

			//8.
			int napiBevetel = 2400 * (lista.Sum(x => x.IdoHossz()) / 30 + 1);
			Console.WriteLine($"8.feladat: A napi bevétel: {napiBevetel} Ft");

			//9.

			StreamWriter srr = new StreamWriter("F.txt");
			srr.ReadLine();
			string rongalok=lista.Where(x => x.)

			//10.
			lista.GroupBy(x => x.Jazon)
				.OrderBy(x => x.Key)
				.ToList()
				.ForEach(x => Console.WriteLine($"{x.Key}-{x.Count()}"));
		}
	}
}
