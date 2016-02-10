using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public RoomWithDoor(string doorDescription, string decoration, string name, string placeToHiding)
            :base(decoration, name, placeToHiding)
        {
            _doorDescription = doorDescription;
        }

        private string _doorDescription;
        public string DoorDescription { get { return _doorDescription; } }

        public Location DoorLocation { get; set; }
    }
}
