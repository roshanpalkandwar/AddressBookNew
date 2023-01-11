using System.Collections;

namespace Arryli
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ArrayList arrylist = new ArrayList();

            arrylist.Add("abv");
            arrylist.Add("aah");
            for (var i = 0;i< arrylist.Count; i++)
            {
                Console.WriteLine(i);

            }
            arrylist.Insert(1,"ahha");
            Console.WriteLine(arrylist);    

            
        }
    }
}