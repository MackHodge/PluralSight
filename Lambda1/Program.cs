using System;

namespace Lambda1
{
    internal class Program
    {
        delegate int MultiPlyDelegate(int a , int b);
        delegate int MultilyDelegate2(int a , int b);
        delegate int EmptyParms();
        public static void Main(string[] args)
        {
            MultiPlyDelegate ad = (Par1, Par2) => Par1 * Par2;
            int result = ad(8, 3);

            MultilyDelegate2 ml = (Par1, Par2) => Par1 * Par2;
            int totalResult = ml(result , 3);

            Console.WriteLine(totalResult);
            
            //what if there is in par 
            //create a methode of both delegetes and call them here 
            
            
        }
    }
}