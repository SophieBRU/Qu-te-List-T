using System;

namespace Quete_List_T
{
    class Program
    {
        static void Main(string[] args)
        {

            System.Collections.Generic.List<string> stringList = new System.Collections.Generic.List<string>();

            stringList.Add("abcd");
            stringList.Add("efgh");
            stringList.Add("ijkl");
            stringList.Add("mnop");

            foreach (String s in stringList)
            {
                Console.WriteLine(s);
            }

            int actualStringListLength = stringList.Count;
            Console.WriteLine("Nombre d'éléments de la collection : " + actualStringListLength);

            //suppression du premier indice
            stringList.RemoveAt(0);
            int actualStringListLength2 = stringList.Count;
            Console.WriteLine("Nombre d'éléments de la collection : " + actualStringListLength2);

            //suppression de la 3ème chaine de caractères
            stringList.Remove("ijkl");
            int actualStringListLength3 = stringList.Count;
            Console.WriteLine("Nombre d'éléments de la collection : " + actualStringListLength3);

            //modification de la 2ème chaine en utilisant son indice
            stringList[1] = ("wxyz");
            foreach (String s in stringList)
            {
                Console.WriteLine(s);
            }
            Console.Read();
        }
    }
}
