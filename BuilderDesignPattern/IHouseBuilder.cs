﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderDesignPattern
{
    public interface IHouseBuilder
    {
        void buildBasement();

        void buildStructure();

        void bulidRoof();

        void buildInterior();

        House getHouse();
    }
}
