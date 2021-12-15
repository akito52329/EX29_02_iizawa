using System;

namespace EX29
{
    class EX29Main
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"表面積は{Box.GetVolume(3.5f, 2.5f, 1.5f)}、面積は{Box.GetSurface(3.5f,2.5f,1.5f)}");
        }
    }
}
