using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string doorDescription, string decoration, string name)
            :base(decoration, name)
        {
            _doorDescription = doorDescription;
        }

        private string _doorDescription;
        public string DoorDescription { get { return _doorDescription; } }

        public Location DoorLocation { get; set; }
    }
}
