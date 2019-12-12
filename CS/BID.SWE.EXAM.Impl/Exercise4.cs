using System;
using System.IO;
using System.Text;
using BID.SWE1.Exam.Interfaces;

namespace BID.SWE.EXAM.Impl
{
    public class Exercise4 : IExercise4
    {
        public object Method1()
        {
            MemoryStream stream = new MemoryStream();
            UnicodeEncoding uniEncoding = new UnicodeEncoding();
            String message = "Frohe Weihnachten ";
            int number = 42;

            stream.Write(uniEncoding.GetBytes(message), 0, message.Length);
            //stream.Write(number, 0, message.Length);


            return stream;
        }

        public object Method2(object obj)
        {
            throw new NotImplementedException();
        }
    }
}