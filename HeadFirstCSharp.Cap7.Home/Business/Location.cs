using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public abstract class Location
    {
        public string Name { get; set; }
        public object[] Exits { get; set; }

        public void Description()
        {

        }
    }
}