using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Balanza.Modelos
{
    public class Item
    {
       
            public string _Name;
            public int _Id;

            public Item(string name, string id)
            {
                _Name = name;
                _Id = int.Parse(id);
            }

            public string Name
            {
                get { return _Name; }
                set { _Name = value; }
            }

            public int Id
            {
                get { return _Id; }

            }
    }
    
}
