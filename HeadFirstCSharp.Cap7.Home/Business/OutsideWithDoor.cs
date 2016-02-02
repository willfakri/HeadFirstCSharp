using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(bool hot, string name) : base(hot, name)
        {
        }

        public string DoorDescription { get; set; }

        public Location DoorLocation { get; set; }
    }
}
