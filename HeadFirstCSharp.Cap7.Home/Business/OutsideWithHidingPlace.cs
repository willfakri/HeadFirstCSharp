using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        private string _placeToHiding;
        public OutsideWithHidingPlace(bool hot, string name, string placeToHiding) : base(hot, name)
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
