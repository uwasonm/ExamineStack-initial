using System.Runtime.InteropServices;

namespace ExamineStack_initial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*1. It would not be good/ smart to use a stach in a case such as the ICA as 
                 that would mean that the one who gets to the queue first leaves the last
                 while the one who joins the queue last is the one who is served first 
                 and therefore leaves the queue before others.
            */

            Stack<char> myStack = new Stack<char>();
            Console.WriteLine("Provide text:");
            string text = Console.ReadLine();
            var characters = text.ToCharArray();

            for (int i = 0; i < text.Length; i++)
            {
                myStack.Push(characters[i]);
            }

            for (int n = 0; n < text.Length; n++)
            {
            Console.Write(myStack.Peek());
            myStack.Pop();
            }
        }

    }
 
}
