using snake_example_1.Food_Generation;
using snake_example_1.Movements_of_the_snake.Coordinate_record;
using snake_example_1.Snake_Generation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace snake_example_1.Movements_of_the_snake.Movements
{
    public class WriteUpArrow : WriteRightArrow
    {
        private static bool _privateVaribale { get; set; }
        private static bool fullSnake { get; set; }
        private static int _i { get; set; }
        private static int upY { get; set; }
        public static void UpArrow()
        {
            _firstBtn = ConsoleKey.D5;
            ConsoleKeyInfo CKI = new ConsoleKeyInfo();

            _y--;
            Console.SetCursorPosition(_x, _y);
            Console.Write(_snake);
            upY++;
            if(upY >= _snakeIndex)
            {
                Console.SetCursorPosition(_x, _y + (_snakeIndex + 1));
                Console.Write(_snakeSpace);
            }
     
            if (_FoodX == _x && _FoodY == _y)
            {
                _snakeIndex++;
                FoodGeneration.RandomFoodGeneration();
            }

            if (_privateVaribale == false)
            {
                _privateVaribale = true;
                _i = 0;
            }

            _i++;

            if (_i == _snakeIndex)
            {
                fullSnake = true;
            }

            Thread.Sleep(400);

            if (Console.KeyAvailable == true)
            {
                CKI = Console.ReadKey(true);

                if (CKI.Key == ConsoleKey.DownArrow ^ CKI.Key == ConsoleKey.LeftArrow ^ CKI.Key == ConsoleKey.RightArrow)
                {

                    _userBtnRight = CKI.Key;

                    CoordinateRecord.AllCoordintatesRecords(_x, _y, fullSnake, _i, 4, _snakeIndex);
                    _i = 0;
                    fullSnake = false;
                    upY++;
                    if (zxc == false)
                    {
                        privateVariable = true;
                        zxc = true;
                    }
                }
            }
            else
            {
                _userBtnRight = ConsoleKey.UpArrow;
            }
        }
    }
}
