using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{

    public class CellPrinter : ICellPrinter
    {
        public string PrintPostion(int x, int y)
        {
            //Console.WriteLine("X = " + x);
            //Console.WriteLine("Y = " + y);
            string position = "Cell is on Position X:"+x+" Y:"+y;
            return position;
        }

        public string PrintState(bool alive, DateTime date, string color)
        {
            string state = "";
            if (alive)
            {
                state = "Cell " + color + " born on " + date.ToString("dd.MM.yyyy") + " is alive";
                return state;
            }
            else
            {
                state = "Cell " + color + " is not alive.";
                return state;
            }
        }
    }
    public class Exercise1 : IExercise1
    {
        public object Method1()
        {
            return new CellPrinter();
        }
    }
}
