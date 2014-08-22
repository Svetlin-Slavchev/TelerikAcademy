using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheNewVersionOfOurConsoleGame.Interfaces;

namespace TheNewVersionOfOurConsoleGame.Classes
{
    class Timer : ISave, IPrintable
    {
        public string timerFileName = @"Timer.txt";
        public TimeSpan RemainingTime { get; set; }
        public TimeSpan MaxTime { get; set; }
        public DateTime StartTime { get; private set; }
        public int gameTimeOutInMinutes;

        public Timer(int gameTimeOutInMinutes)
        {
            this.RemainingTime = RemainingTime;
            this.MaxTime = MaxTime;
            this.gameTimeOutInMinutes = gameTimeOutInMinutes;
        }

        public int[] Load(string timerFileName) /// array maybe !!!!!
        {
            StreamReader reader = new StreamReader(timerFileName);
            int[] savedRemainingTime = new int[2];
            int.TryParse(reader.ReadLine(), out savedRemainingTime[0]);
            int.TryParse(reader.ReadLine(), out savedRemainingTime[1]);
            // savedRemainingTime[1] += 45;
            reader.Close();
            return savedRemainingTime;
        }

        public void Save(string fileName)
        {
            StreamWriter writer = new StreamWriter(timerFileName);
            writer.WriteLine(RemainingTime.Minutes.ToString());
            writer.WriteLine(RemainingTime.Seconds.ToString());
            writer.Close();
        }

        public void Print(TimeSpan RemainingTime,int coordinateX, int coordinateY)
        {
            Console.SetCursorPosition(coordinateX, coordinateY);
            Console.WriteLine("Time left:");
            Console.SetCursorPosition(coordinateX + 3, coordinateY + 2);
            if (RemainingTime.Minutes == 0 && RemainingTime.Seconds == -1)
            {
                Console.WriteLine("00:00");
            }
            else
            {
                Console.WriteLine("{0,2:00}:{1,2:00}", RemainingTime.Minutes, RemainingTime.Seconds);
            }
        }

        public TimeSpan CalculateRemainingTime(TimeSpan maxTime, DateTime startTime)
        {
            TimeSpan remainingTime = maxTime - (DateTime.Now - startTime);
            // string remeiningTime = string.Format("{0,2:00}:{1,2:00}:{2,2:00}", remeiningTimeTS.Hours, remeiningTimeTS.Minutes, remeiningTimeTS.Seconds);
            return remainingTime;
        }

        public string CalculateTimeFromStart(TimeSpan maxTime, TimeSpan remeiningTimeTS)
        {
            TimeSpan spentTime = maxTime - remeiningTimeTS - TimeSpan.FromSeconds(1);

            string elapsedTime = string.Format("{0,2:00}:{1,2:00}", spentTime.Minutes, spentTime.Seconds);
            return elapsedTime;
        }
    }
}
