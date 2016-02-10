using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class Opponent
    {
        public Opponent(Location myLocation)
        {
            _myLocation = myLocation;
            _random = new Random();            
        }

        public Random _random;
        private Location _myLocation;
        public Location MyLocation { get { return _myLocation; } }
        

        public void Move()
        {
            if (MyLocation is OutsideWithDoor)
            {
                if (_random.Next(2) == 1)
                {
                    _myLocation = ((OutsideWithDoor)MyLocation).Exits[_random.Next(((OutsideWithDoor)MyLocation).Exits.Count())];
                }                
            }

            if (MyLocation is RoomWithDoor)
            {
                _myLocation = ((RoomWithDoor)MyLocation).DoorLocation;
            }

            if (!(MyLocation is IHidingPlace))
            {
                Move();
            }
        }

        public bool Check(Location location)
        {
            return location == MyLocation;
        }
    }
}
