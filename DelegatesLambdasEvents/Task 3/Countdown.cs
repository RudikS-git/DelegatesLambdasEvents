using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace DelegatesLambdasEvents.Task_3
{
    public class Countdown
    {
        public delegate void EndingHandler(string text);
        private event EndingHandler notify;

        public event EndingHandler Notify
        {
            add
            {
                notify += value;
                Console.WriteLine("Subscribed");
            }
            
            remove
            {
                notify -= value;
                Console.WriteLine("Unsubscribed");
            }
        }

        public void RunThreadSleep(int milliSeconds)
        {
            Thread.Sleep(milliSeconds);
            notify?.Invoke("Hi!");
        }
        
    }
}
