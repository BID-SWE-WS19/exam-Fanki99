using System;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{

    public class CellNew : Cell
    {

    }
    public class CellNew2 : Cell
    {
        public override int Grow()
        {
            _size = _size*2;
            return _size;
        }
    }

    public class CellNew3 : Cell
    {
        //public override bool IsAlive(int Neighbours)
        //{

        //    return true;
        //}
    }
    public class Exercise2 : IExercise2
    {
        public object Method1()
        {
            return new CellNew();
        }

        public int Method2()
        {
            CellNew2 cn2 = new CellNew2();
            return cn2.Grow();
        }

        public bool Method3(int o1)
        {
            CellNew3 cn3 = new CellNew3();
            return cn3.IsAlive();
        }
    }
}