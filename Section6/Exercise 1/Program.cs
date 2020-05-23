using System;

namespace Section6
{
    class Program
    {
        static void Main(string[] args)
        {
            Square[] squares = new Square[10];
            for (int i = 1; i < 11; i++)
            {
                squares[i - 1] = new Square(i);
                Console.WriteLine("Length of square side: {0}" + 
                    "\nArea of square: {1}" + "" +
                    "\n********************", squares[i - 1].SideLength, squares[i - 1].SquareArea);
            }
            Console.Read();
        }
    }
}
