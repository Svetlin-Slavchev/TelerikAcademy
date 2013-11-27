using System;
using System.Linq;
using System.Threading;

// Using delegates write a class Timer that has can execute certain method at each t seconds.

public delegate void TimerDelegate(string param);

class Timer
{
    public const int delay = 2;
    
    public static void PrinSomeWord(string param)
    {
        Console.WriteLine("{0}", param);
    }

    static void Main(string[] args)
    {
        while (true)
        {
            TimerDelegate d = new TimerDelegate(PrinSomeWord);
            d("blaaa");
            Thread.Sleep(delay * 1000);
        }
    }
}
