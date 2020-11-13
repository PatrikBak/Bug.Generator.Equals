using Generator.Equals;
using System;

namespace Test
{
    [Equatable]

    partial record MyRecord(
        [property: SequenceEquality] string[] Fruits
    );

    class Program
    {
        static void Main(string[] args)
        {
            var record1 = new MyRecord(new[] { "banana", "apple" });
            var record2 = new MyRecord(new[] { "banana", "apple" });

            Console.WriteLine(record1 == record2);
        }
    }
}