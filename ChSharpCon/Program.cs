using System;
using SimpleDataTypes;
using Examples;

namespace ChSharpCon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // Simple Data Types
            //IntegralTypes i = new IntegralTypes();
            //i.IntegralType();
            //ExapmlesForValueType boo = new ExapmlesForValueType();
            //boo.ChecksIfTheInputCharacterIsALetter();
            ValueDataType resualtFromMixingIntegralAndFloatData = new ValueDataType();
            resualtFromMixingIntegralAndFloatData.DoubleTypes();
            resualtFromMixingIntegralAndFloatData.FloatType();

            Console.ReadKey();
        }
    }
}
