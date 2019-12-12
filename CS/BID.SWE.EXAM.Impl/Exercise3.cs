using System;
using BID.SWE1.Exam.Impl;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class MapNew : Map
    {
        public override int AddNewCells(int count)
        {
            return count;
        }

        public override string GetMapName()
        {
            return "BID-Map";
        }

        public override float GetMapSize(float amount)
        {
            return amount * amount;
        }
    }

    public class Springen
    {
        public void Position()
        {

        }
        public void Move(int x)
        {

        }
    }

    public class Laufen
    {
        public void Position()
        {

        }
        public void Move(int x)
        {

        }
    }

    public class Bewegung
    {
        public class Springen
        {
            public void Position()
            {
                
            }
            public void Move(int x)
            {

            }
        }
        public class Laufen
        {
            public void Position()
            {

            }
            public void Move(int x)
            {

            }
        }
    }
    public class Exercise3 : IExercise3
    {
        public object Method1()
        {
            return new MapNew();
        }

        object[] arr = { new Laufen(), new Springen() };

        public object Method2()
        {
            return arr;
        }

    }
}