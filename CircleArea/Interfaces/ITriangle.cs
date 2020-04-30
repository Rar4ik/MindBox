using System;
using System.Collections.Generic;
using System.Text;

namespace Area.Interfaces
{
    public interface ITriangle: IShape
    {
        double SideB { get; set; }
        double SideC { get; set; }
    }
}
