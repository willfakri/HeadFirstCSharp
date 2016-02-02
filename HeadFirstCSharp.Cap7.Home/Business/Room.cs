using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class Room : Location
    {
        private string _decoration;
        public string Decoration { get { return _decoration; } }

        public Room(string decoration, string name)
            :base(name)
        {
            _decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return $"{base.Description} Você pode ver {_decoration} aqui.";
            }
        }
    }
}
