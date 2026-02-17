using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linked_list
{
    internal class HouseManager
    {
        private HouseNode? head = null;
        private HouseNode? tail = null;

        public void AddHouse(int number, string address, string type)
        {
            HouseNode newNode = new HouseNode(number, address, type);
            // if list is empty
            if (head == null)
            {
                head = newNode;
                tail = newNode;
                return;
            }
            tail.Next = newNode;
            tail = newNode;
        }
        public HouseNode? FindHouseByNumber(int number)
        {
            HouseNode? current = head;

            while (current != null)
            {
                if (current.HouseNumber == number)
                    return current;
                current = current.Next;
            }
            return null;
        }




    }
    
}
