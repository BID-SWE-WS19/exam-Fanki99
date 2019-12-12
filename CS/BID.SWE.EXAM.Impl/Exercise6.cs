using System;
using System.Data.SqlClient;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise6 : IExercise6
    {
        public object Method1()
        {
            string name = "Thomas Fankhauser";
            int tag = 12;
            int monat = 12;
            int jahr = 2019;
            int stunde = 17;
            int minute = 12;
            
            string cmdText = "INSERT INTO TestAbgaben (Name,Tag,Monat,Jahr,Stunde,Minute) " +
                "VALUES(" + name+ ","+  tag.ToString()+ "," + monat.ToString()+ "," + jahr.ToString()+ "," + stunde.ToString()+ "," + minute.ToString() + ");";

            Console.WriteLine(cmdText);
            SqlCommand cmd = new SqlCommand(cmdText);

            return cmd;
        }
    }
}