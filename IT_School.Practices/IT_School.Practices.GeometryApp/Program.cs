using System;
using System.Text;

namespace IT_School.Practices.GeometryApp
{
    public struct Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public void Move(bool isX, int value)
        {
            if (isX)
            {
                X += value;
            }
            else
            {
                Y += value;
            }
        }
    }

    public struct Line
    {
        public Point StartPoint;
        public Point EndPoint;

        public Line(Point sp, Point ep)
        {
            StartPoint = sp;
            EndPoint = ep;
        }

        public double GetLength()
        {
            return Math.Sqrt(Math.Pow(StartPoint.X - EndPoint.X, 2) + Math.Pow(StartPoint.Y - EndPoint.Y, 2));
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            //Console.BackgroundColor = ConsoleColor.Blue;
            //Console.ForegroundColor = ConsoleColor.Red;
            int x1 = AdvancedParse("x1");
            int y1 = AdvancedParse("y1");
            int x2 = AdvancedParse("x2");
            int y2 = AdvancedParse("y2");



            Point startPoint = new Point(x1, y1);
            Point endPoint = new Point(x2, y2);
            Line line = new Line(startPoint, endPoint);

            while (true)
            {

                Console.WriteLine(
                    "Для получения длины нажмите F1 \n Для смещения нажмите F2 \n Для завершения нажмите Esc");
                var ans = Console.ReadKey().Key;

                switch (ans)
                {
                    case ConsoleKey.F1:
                        Console.WriteLine(line.GetLength());
                        break;
                    case ConsoleKey.F2:
                        ChangeLine(line);




                        break;
                    case ConsoleKey.Escape:
                        break;
                    default:
                        Console.WriteLine("Некорректный ввод");
                        continue;
                }


            }


        }

        private static int AdvancedParse(string label)
        {
            int x;
            while (true)
            {
                Console.WriteLine($"Введите {label}");
                if (int.TryParse(Console.ReadLine(), out x))
                {
                    return x;
                }
                Console.WriteLine("Неверные данные");
            }


        }

        private static void ChangeLine(Line line)
        {

            while (true)
            {
                Console.WriteLine("Для изменения начальной точки нажмите F1\nДля изменения конечной точки нажмите F2");
                var key = Console.ReadKey().Key;
                if (key != ConsoleKey.F1 && key != ConsoleKey.F2)
                {
                    continue;
                }
                break;
            }
        }
    }
}
