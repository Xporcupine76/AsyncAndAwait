using System;
using System.Xml.Xsl;

namespace AsyncAndAwait
{
    class Program
    {
        static void main(string[] args)
        {
            AsynceAwaitDemo demo = new AsynceAwaitDemo();
            demo.DoStuff();

            for(int i = 0; i < 100; i++)
            {
                Console.WriteLine("Working on the main Thread...");

            }
           
        }


    }
    public class AsynceAwaitDemo
    {

        public async Task DoStuff()
        {
           /* await Task.Run(() =>
            {
                CountToFifty();

            });
           */ 
            Console.WriteLine("Counting to 50 is Compiled");


        }


        private static async Task<string> CountToFifty()
        {

            int counter;
            for (counter = 0; counter < 51; counter++) ;
            {
                Console.WriteLine("BG thread: " + counter);
            }
        }
    }  

}