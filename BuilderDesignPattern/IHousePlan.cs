using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IHousePlan
    {
        void setBasement(String basement);

        void setStructure(String structure);

        void setRoof(String roof);

        void setInterior(String interior);
    }
}
