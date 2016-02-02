using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public class Outside : Location
    {
        private bool _hot;
        public bool Hot { get { return _hot; } }

        public Outside(bool hot, string name) 
            :base(name)
        {
            _hot = hot;

        }

        public override string Description
        {
            get
            {
                if (_hot)
                {
                    return "Está quente pra dedéu.";
                }
                else
                {
                    return base.Description;
                }
            }
        }
    }
}
