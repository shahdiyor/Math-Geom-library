using System;
using System.Linq;

namespace Functions
{
    public class Func
    {

        //Значение Пи
        //The Value Of PI
        public const double PI = 3.1415926535897931;
        //Сумма
        //Amout
        public static double Sum(params double[] tata)
        {
            double Sum = tata[0];
            for (int i = 1; i < tata.Length; i++)
            {
                Sum += tata[i];
            }
            return Sum;
        }
        //Разность
        //subtraction
        public static double Sub(params double[] tata)
        {
            double Sub = tata[0];
            for (int i = 1; i < tata.Length; i++)
            {
                Sub -= tata[i];
            }
            return Sub;
        }
        //Умножение
        //multiplication
        public static double Mult(params double[] tata)
        {
            double mult = tata[0];
            for (int i = 1; i < tata.Length; i++)
            {
                mult *= tata[i];
            }
            return mult;
        }
        //Деление
        //division
        public static float Div(params float[] tata)
        {
            float div = tata[0];
            for (int i = 1; i < tata.Length; i++)
            {
                div /= tata[i];
            }
            return div;
        }
        //Площадь круга
        //The area of a circle
        public static double AreaCircle(double x)
        {
            return PI*x*x;
        }
        //Площадь квадрата
        //The area of a square
        public static double AreaSquare(double side)
        {
            return side * side;
        }
        //Площадь прямоугольника
        //The area of a rectangle
        public static double AreaRectangle(double height, double width)
        {
            return height*width;
        }
        //Площадь параллелограмма
        //Area of the parallelogram
        public static double AreaParallelogram(double bases, double height)
        {
                return bases * height;
        }
    }
}