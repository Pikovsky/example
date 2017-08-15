using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace MichelTemp
{
    class Program
    {
        // Define an Enum with FlagsAttribute.
        [Flags]
        enum MultiHue : short
        {
            None = 0,
            Black = 1,
            Red = 2,
            Green = 4,
            Blue = 8
        };

        static void Main(string[] args)
        {
            byte[] buffer = new byte[] {2, 5};
            Int16 a = (Int16)Convert.ChangeType(BitConverter.ToInt16(buffer, 0), typeof(Int16));
            Console.WriteLine(a);

            Console.WriteLine(new string('-', 33));

            Console.WriteLine($"char sizeof {sizeof(char)}, Marshal.SizeOf {Marshal.SizeOf(typeof(char))}");

            Console.WriteLine(new string('-', 33));

            // Display all combinations of values, and invalid values.
            Console.WriteLine(
                "\nAll possible combinations of values with FlagsAttribute:");
            for (int val = 0; val <= 16; val++)
                Console.WriteLine("{0,3} - {1:G}", val, (MultiHue)val);

            Console.WriteLine("Я добавил эту строку, что бы просто изменить проект для изучения Git.");

            Console.ReadKey();


        }
    }
}
