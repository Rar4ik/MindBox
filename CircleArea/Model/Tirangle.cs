using System;
using System.Collections.Generic;
using System.Text;
using Area.Interfaces;

namespace Area.Model
{
    public class Triangle : ITriangle
    {
        public double MainSide { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
    }
}
