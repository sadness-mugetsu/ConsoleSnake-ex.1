using System;
using System.Collections.Generic;
using System.Text;

namespace snake_example_1.Fields_Generation
{
    public class FieldsGeneration
    {
        public static void DrawingGamingField(int quantityPointsX = 40)
        {
            char point = '#';
            int quantityPointsY = quantityPointsX / 3;

            int x = 0;
            int y = 0;

            Action upperWall = delegate { Console.SetCursorPosition(x++, 0); Console.Write(point); };
            
            Action leftWall = delegate { Console.SetCursorPosition(0, y++); Console.WriteLine(point); };

            Action downWall = delegate { Console.SetCursorPosition(x++ - 40, y); Console.Write(point); };

            Action rightWall = delegate { Console.SetCursorPosition(x - 40, y++ - 12); Console.WriteLine(point); };

            Tuple<int, Action>[] tuple =
            {
                new Tuple<int, Action>(quantityPointsX, upperWall), new Tuple<int, Action>(quantityPointsY, leftWall),
                new Tuple<int, Action>(quantityPointsX, downWall), new Tuple<int, Action>(quantityPointsY + 1, rightWall)
            };

            for (int i = 0, i2 = 0; i < 4;)
            {
                if (i2 != tuple[i].Item1)
                    tuple[i].Item2.Invoke();
                else if (i2 == tuple[i].Item1)
                {
                    i++;
                    i2 = 0;
                }
                i2++;
            }
        }
    }
}
