using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeadFirstCSharp.Cap7.Home.Business
{
    public abstract class Location
    {
        private string _name;
        public string Name
        {
            get { return _name; }
        }
        public Location[] Exits { get; set; }

        public Location(string name)
        {
            this._name = name;
        }

        public virtual string Description
        {
            get
                {
                string exits = string.Empty;
                for (int i = 0; i < Exits.Length; i++)
                {
                    exits += $" {Exits[i].Name}";
                    if (i != Exits.Length - 1)
                    {
                        exits += ",";
                    }
                };

                string description = $"Você está na {_name}. Pode sair pelos seguintes locais: {exits}.";
                return description;
            }
        }
    }
}