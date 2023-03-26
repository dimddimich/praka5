using System;

namespace praka5_4
{
    interface IShare
    {
        void Draw(int size);
    }

    class VerticalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("|");
            }
        }
    }

    class HorizontalLine : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
        }
    }

    class Square : IShare
    {
        public void Draw(int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    if (i == 0 || i == size - 1 || j == 0 || j == size - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int size = 10;
            IShare verticalLine = new VerticalLine();
            IShare horizontalLine = new HorizontalLine();
            IShare square = new Square();

            Console.WriteLine("Вертикальная линия:");
            verticalLine.Draw(size);

            Console.WriteLine("Горизонтальная линия:");
            horizontalLine.Draw(size);

            Console.WriteLine("Квадрат:"); //Правда скорее прямоугольник, ну ладно
            square.Draw(size);

            Console.ReadKey();
        }
    }
}

