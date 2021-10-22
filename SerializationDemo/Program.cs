using System;

namespace SerializationDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //BinarySerialization obj = new BinarySerialization();
           // obj.Serialization();
            BinaryDeSerialization obj = new BinaryDeSerialization();
            obj.DeSerialization();
        }
    }
}
