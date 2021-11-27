using System;

namespace Delegate
{
    public class Program
    {
        static void Main(string[] args)
        {
            WorkPereformedHandler del1 = new WorkPereformedHandler(WorkPereformed1);
            WorkPereformedHandler del2 = new WorkPereformedHandler(WorkPereformed2);
            WorkPereformedHandler del3 = new WorkPereformedHandler(WorkPereformed3);

            del1 += del2 + del3;

            Worker worker = new Worker();

            worker.DoWork(10,WorkType.GoToMeetings);

            Console.ReadKey();
        }
        static void DoWork(WorkPereformedHandler del)
        {
            del(5,WorkType.Golf);
        }
        static int WorkPereformed1(int hours,WorkType workType)
        {
            Console.WriteLine("WorkPereformed1 called "+hours.ToString() + workType.ToString());
            return hours+1;
        }
        static int WorkPereformed2(int hours,WorkType workType)
        {
            Console.WriteLine("WorkPereformed2 called " + hours.ToString() + workType.ToString());
            return hours+2;
        }
        static int WorkPereformed3(int hours,WorkType workType)
        {
            Console.WriteLine("WorkPereformed3 called " + hours.ToString() + workType.ToString());
            return hours+3;
        }
    }
    public enum WorkType
    {
        GoToMeetings,
        Golf,
        GenerateRaports
    }
}
