using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class RoomWithHidingPlace : Room, IHidingPlace
    {
        private string _placeToHiding;
        public RoomWithHidingPlace(string decoration, string name, string placeToHiding) : base(decoration, name)
        {
            _placeToHiding = placeToHiding;
        }

        public string PlaceToHiding
        {
            get
            {
                return _placeToHiding;
            }
        }
    }
}
