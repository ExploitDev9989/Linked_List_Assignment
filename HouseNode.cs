using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    public class HouseNode
    {
        public int HouseNumber;
        public string Address;
        public string Type;
        public HouseNode Next;



        public HouseNode (int  houseNumber, string address, string type)
        {
            HouseNumber = houseNumber;
            Address = address;
            Type = type;
            Next = null;
        }
    }
}

    
 

