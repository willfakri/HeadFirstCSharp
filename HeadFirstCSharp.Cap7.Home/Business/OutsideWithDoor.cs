using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    class OutsideWithDoor : OutsideWithHidingPlace, IHasExteriorDoor
    {
        public OutsideWithDoor(bool hot, string name, string placeToHiding) : base(hot, name, placeToHiding)
        {
        }

        public string DoorDescription { get; set; }

        public Location DoorLocation { get; set; }
    }
}
