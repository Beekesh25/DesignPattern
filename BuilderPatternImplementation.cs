using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPatternImplementation
{
    public class BuilderPatternImplementation
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
	public interface IHousePlan
	{
		void setBasement(String basement);

		void setStructure(String structure);

		void setRoof(String roof);

		void setInterior(String interior);
	}
	public class House : IHousePlan
	{
		private String basement;
		private String structure;
		private String roof;
		private String interior;
		private string type;

		public void setBasement(String basement)
		{
			this.basement = basement;
		}

		public void setStructure(String structure)
		{
			this.structure = structure;
		}

		public void setRoof(String roof)
		{
			this.roof = roof;
		}

		public void setInterior(String interior)
		{
			this.interior = interior;

		}

	}
	public class IglooHouseBuilder : IHouseBuilder
	{
		private House house;

		public IglooHouseBuilder()
		{
			this.house = new House();
		}

		public void buildBasement()
		{
			house.setBasement("Ice Bars");
		}

		public void buildStructure()
		{
			house.setStructure("Ice Blocks");
		}

		public void buildInterior()
		{
			house.setInterior("Ice Carvings");
		}

		public void bulidRoof()
		{
			house.setRoof("Ice Dome");
		}

		public House getHouse()
		{
			return this.house;
		}
	}
	public class TipiHouseBuilder
	{
		private House house;

		public TipiHouseBuilder()
		{
			this.house = new House();
		}

		public void buildBasement()
		{
			house.setBasement("Wooden Poles");
		}

		public void buildStructure()
		{
			house.setStructure("Wood and Ice");
		}

		public void buildInterior()
		{
			house.setInterior("Fire Wood");
		}

		public void bulidRoof()
		{
			house.setRoof("Wood, caribou and seal skins");
		}

		public House getHouse()
		{
			return this.house;
		}
	}
	public interface IHouseBuilder
	{
		void buildBasement();

		void buildStructure();

		void bulidRoof();

		void buildInterior();

		House getHouse();
	}
	public class CivilEngineer
	{
		private IHouseBuilder houseBuilder;

		public CivilEngineer(IHouseBuilder houseBuilder)
		{
			this.houseBuilder = houseBuilder;
		}
		public House getHouse()
		{
			return this.houseBuilder.getHouse();
		}

		public void constructHouse()
		{
			this.houseBuilder.buildBasement();
			this.houseBuilder.buildStructure();
			this.houseBuilder.bulidRoof();
			this.houseBuilder.buildInterior();
		}
	}
}
