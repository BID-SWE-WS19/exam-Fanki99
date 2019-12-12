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

            MemoryStream memoryStream = new MemoryStream();
            BinaryWriter writer = new BinaryWriter(memoryStream);
            writer.Write("Frohe Weihnachten ");
            writer.Write((int)42);
            writer.Write(false);

            return stream;
        }

        public object Method2(object obj)
        {
            BinaryReader binReader =
                   new BinaryReader((MemoryStream)obj);
            int zahl = binReader.ReadInt32();

            string str = binReader.ReadString();
            return str;
        }
    }
}