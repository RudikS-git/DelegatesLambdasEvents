using System.Threading;

namespace EventTask3ConsoleTests
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(InitFirstClass);
            thread1.Start();

            Thread thread2 = new Thread(InitSecondClass);
            thread2.Start();
        }

        static void InitFirstClass()
        {
            FirstClass first = new FirstClass(10000);
        }

        static void InitSecondClass()
        {
            SecondClass second = new SecondClass(12000);
        }
    }
}
