using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class cmbItem
    {

        string name;
        int value;

        public string NAME {get => name;}
        public int VALUE { get => value; }

        public cmbItem(string pname, int pvalue)
        {
            name = pname;
            value = pvalue;
        }
    }
}
