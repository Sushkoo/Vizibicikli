using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	internal class Kolcsonzes
	{
		string nev;
		char jazon;
		int eOra;
		int vOra;
		int vPerc;

		public Kolcsonzes(string nev, char jazon, int eOra, int vOra, int vPerc)
		{
			this.nev = nev;
			this.jazon = jazon;
			this.eOra = eOra;
			this.vOra = vOra;
			this.vPerc = vPerc;
		}

		public string Nev { get => nev; }
		public char Jazon { get => jazon; }
		public int EOra { get => eOra; }
		public int VOra { get => vOra; }
		public int VPerc { get => vPerc; }
	}
}
