using System;
using System.Collections.Generic;
using System.Text;

namespace snake_example_1.Fields_Generation
{
    public class FieldsGeneration
    {
        public static void DrawingGamingField(int PointCount = 90)
        {
            char Point = '#';

            int DrawingY = PointCount / 3;

            //Cycle for upper generation X
            for (int i = 0; i < PointCount; i++)
            {
                Console.Write(Point);
            }
            //Cycle for left generation Y
            for (int i = 0; i < DrawingY; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine(Point);
            }
            //Cycle for lower generation X
            for (int i = 0; i < PointCount; i++)
            {
                Console.SetCursorPosition(i, DrawingY);
                Console.Write(Point);
            }
            //Cycle for right generation Y
            for (int i = 0; i < DrawingY + 1; i++)
            {
                Console.SetCursorPosition(PointCount, i);
                Console.WriteLine(Point);
            }
        }
    }
}
