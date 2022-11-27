using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public class House:IHousePlan
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
}
