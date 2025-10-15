using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2.Demo2
{
    class CollectionDemo
    {
        public void GetDetails()
        {
            ArrayList listObj = new ArrayList();
           
            Console.WriteLine("Initial Capacity :{0}",listObj.Capacity);
            listObj.Add("Rocks");
            Console.WriteLine("Capacity :{0}", listObj.Capacity);

            listObj.Add("John");
            listObj.Add(1010);
            listObj.Add(200);
            listObj.Add("David");
            Console.WriteLine("Capacity :{0}", listObj.Capacity);

            for (int i = 0; i < listObj.Count; i++)
            {
                Console.WriteLine(listObj[i]);
            }

            listObj.Remove(1010);
            Console.WriteLine("-------------------");

            for (int i = 0; i < listObj.Count; i++)
            {
                Console.WriteLine(listObj[i]);
            }

            Console.WriteLine("Search");
            Console.WriteLine("----------------------");

            Console.WriteLine(listObj.Contains("David"));

            Console.WriteLine("-----------------------");

            int result = (int)listObj[2];  // Un-Boxing ---Explicit Type Conversion

            Console.WriteLine(result);

            Console.WriteLine("----------------");
            object[] listArray = listObj.ToArray();

            foreach (var item in listArray)
            {
                Console.WriteLine(item);
            }

            //for (int i = 0; i < listObj.Count; i++)
            //{
            //    Console.WriteLine(listObj[i]);
            //}

            //Console.WriteLine("Remove All elements");
            //listObj.Clear();

            //Console.WriteLine("Count after Clear {0}",listObj.Count);
            //for (int i = 0; i < listObj.Count; i++)
            //{
            //    Console.WriteLine(listObj[i]);
            //}
        }
    }
}
