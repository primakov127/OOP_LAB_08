using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAB_08
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                #region Example1
                //Stack<string> stack1 = new Stack<string>();
                //stack1.Add("Hello");
                //stack1.Add("World");
                //stack1.Add("!!!");

                //while(!stack1.IsEmpty)
                //{
                //    Console.WriteLine(stack1.Remove());
                //}
                #endregion Example1

                #region Example2
                //Turner man1 = new Turner("Max", "Prymakou", 18, "BSTU", 5);
                //Turner man2 = new Turner("Alex", "Gardienko", 25, "EPAM", 8);
                //Turner man3 = new Turner("Nikita", "Padaronkin", 19, "BOBROV", 2);
                Stack<Turner> stack1 = new Stack<Turner>();
                //stack1.Add(man1);
                //stack1.Add(man2);
                //stack1.Add(man3);

                //stack1.Save(@"..\..\class.dat");
                stack1.Upload(@"..\..\class.dat");
                while (!stack1.IsEmpty)
                {
                    Console.WriteLine((stack1.Remove()).ToString());
                    Console.WriteLine("---------------------------");
                }
                #endregion Example2


            }
            catch (Exception err)
            {
                Console.WriteLine(err.Message);
            }
            finally
            {
                Console.WriteLine("Блок finally");
            }





        }
    }
}
