using System;
using BuilderDesignPattern;

namespace BuilderDesignPattern
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IHouseBuilder iglooBuilder = new IglooHouseBuilder();
			CivilEngineer engineer = new CivilEngineer(iglooBuilder);

			engineer.constructHouse();

			House house = engineer.getHouse();

			Console.WriteLine("Builder constructed: " + house);

			IHouseBuilder tippiBuilder = new IglooHouseBuilder();
			CivilEngineer engineer2 = new CivilEngineer(tippiBuilder);

			engineer2.constructHouse();

			House house2 = engineer.getHouse();

			Console.WriteLine("Builder constructed: " + house2);
		}
	}
}