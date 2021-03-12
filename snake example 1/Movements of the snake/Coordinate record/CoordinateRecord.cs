using snake_example_1.Snake_Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace snake_example_1.Movements_of_the_snake.Coordinate_record
{
    public class CoordinateRecord : SnakeGeneration
    {
      
        private static bool _privateVariable { get; set; }


        public static void AllCoordintatesRecords(int x, int y, bool fullSnakeLenght, int snakeLenght, int direction, int si)
        {

            if (_privateVariable == false)
            {
                i2 = 0;
                _privateVariable = true;
            }

            i2++;
            if (i2 == 1)
            {
                OneX = x;
                OneY = y;
                _fullSnakeLenght = fullSnakeLenght;
                _snakeLenght = snakeLenght;
                _direction = direction;
                _snakeIndex1 = si;
                OneTrue = true;
            }
            if (i2 == 2)
            {
                TwoX = x;
                TwoY = y;
                _fullSnakeLenght2 = fullSnakeLenght;
                _snakeLenght2 = snakeLenght;
                _direction2 = direction;
                _snakeIndex2 = si;
                TwoTrue = true;

            }
            if (i2 == 3)
            {
                ThreeX = x;
                ThreeY = y;
                _fullSnakeLenght3 = fullSnakeLenght;
                _snakeLenght3 = snakeLenght;
                _direction3 = direction;
                _snakeIndex3 = si;
                ThreeTrue = true;
            }
            if (i2 == 4)
            {
                FourX = x;
                FourY = y;
                _fullSnakeLenght4 = fullSnakeLenght;
                _snakeLenght4 = snakeLenght;
                _direction4 = direction;
                _snakeIndex4 = si;
                FourTrue = true;
            }
            if (i2 == 5)
            {
                FiveX = x;
                FiveY = y;
                _fullSnakeLenght5 = fullSnakeLenght;
                _snakeLenght5 = snakeLenght;
                _direction5 = direction;
                _snakeIndex5 = si;
                FiveTrue = true;
            }
            if (i2 == 6)
            {
                SixX = x;
                SixY = y;
                _fullSnakeLenght6 = fullSnakeLenght;
                _snakeLenght6 = snakeLenght;
                _direction6 = direction;
                _snakeIndex6 = si;
                SixTrue = true;
            }
            if (i2 == 7)
            {
                SevenX = x;
                SevenY = y;
                _fullSnakeLenght7 = fullSnakeLenght;
                _snakeLenght7 = snakeLenght;
                _direction7 = direction;
                _snakeIndex7 = si;
                SevenTrue = true;
            }
            if (i2 == 8)
            {
                EightX = x;
                EightY = y;
                _fullSnakeLenght8 = fullSnakeLenght;
                _snakeLenght8 = snakeLenght;
                _direction8 = direction;
                _snakeIndex8 = si;
                EightTrue = true;
            }
            if (i2 == 9)
            {
                NineX = x;
                NineY = y;
                _fullSnakeLenght9 = fullSnakeLenght;
                _snakeLenght9 = snakeLenght;
                _direction9 = direction;
                _snakeIndex9 = si;
                NineTrue = true;
            }
            if (i2 == 10)
            {
                TenX = x;
                TenY = y;
                _fullSnakeLenght10 = fullSnakeLenght;
                _snakeLenght10 = snakeLenght;
                _direction10 = direction;
                _snakeIndex10 = si;
                TenTrue = true;
                i2 = 0;
            }
        }
    }
}
