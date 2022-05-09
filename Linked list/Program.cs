using System;

namespace Linked_list
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new Model.LinkedList<int>();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);

            list.Delete(3);
 

        }
    }
}
