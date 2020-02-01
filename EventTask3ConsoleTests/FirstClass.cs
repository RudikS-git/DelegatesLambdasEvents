using System;
using DelegatesLambdasEvents.Task_3;


namespace EventTask3ConsoleTests
{
    public class FirstClass
    {
        public FirstClass(int mSec)
        {
            Countdown countdown = new Countdown();
            countdown.Notify += DisplayNotify;
            countdown.RunThreadSleep(mSec);
            countdown.Notify -= DisplayNotify;
        }

        public void DisplayNotify(string text)
        {
            Console.WriteLine(text + " , " + this.GetType().Name);
        }
    }
}
