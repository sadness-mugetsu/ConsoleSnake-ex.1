using snake_example_1.Movements_of_the_snake.Movements;
using snake_example_1.Snake_Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace snake_example_1.Movements_of_the_snake
{
    public class SnakeMovements : SnakeGeneration
    {
        public static string _snake { get; set; }
        public static string _snakeSpace { get; set; }
        public static ConsoleKey _userBtnRight { get; set; }
        public static ConsoleKey _firstBtn { get; set; }

        public static int _snakeIndex { get; set; }
        public static bool _checkRight { get; set; }

        public static bool _checkDown { get; set; }
        public static bool _checkUp { get; set; }
        public static bool _checkLeft { get; set; }

        private static int x { get; set; }
        private static int y { get; set; }
        private static int snakeLenght { get; set; }
        private static bool fullSnakeLenght { get; set; }
        private static int snakeNumberLenght { get; set; }
        private static int direction { get; set; }
        private static int snakeIndex { get; set; }
        private static int i { get; set; }
        public static bool privateVariable { get; set; }
        private static int j { get; set; }

    
      
        public static void MovementsSnake()
        {
            _snake = "*";
            _snakeSpace = " ";
            _snakeIndex = 0;

            Console.CursorVisible = false;

            ConsoleKey input = Console.ReadKey().Key;

            _firstBtn = Console.ReadKey().Key;

            i = 1;
            do
            {
                if (_firstBtn == ConsoleKey.DownArrow ^ _userBtnRight == ConsoleKey.DownArrow)
                {
                    WriteDownArrow.DownArrow();
                }
                if (_firstBtn == ConsoleKey.RightArrow ^ _userBtnRight == ConsoleKey.RightArrow)
                {
                    WriteRightArrow.RightArrow();
                }
                if (_firstBtn == ConsoleKey.LeftArrow ^ _userBtnRight == ConsoleKey.LeftArrow)
                {
                    WriteLeftArrow.LeftArrow();
                }
                if (_firstBtn == ConsoleKey.UpArrow ^ _userBtnRight == ConsoleKey.UpArrow)
                {
                    WriteUpArrow.UpArrow();
                }


          
                if (privateVariable == true)
                {

                    if (i == 1 & OneTrue == true & direction == 0)
                    {
                        x = OneX;
                        y = OneY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght;
                        snakeNumberLenght = _snakeLenght;
                        snakeLenght = _snakeLenght;
                        direction = _direction;
                        snakeIndex = _snakeIndex1;
                        privateVariable = false;
                        i++;
                        OneTrue = false;
                    }
                    if (i == 2 & TwoTrue == true & direction == 0)
                    {
                        x = TwoX;
                        y = TwoY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght2;
                        snakeNumberLenght = _snakeLenght2;
                        snakeLenght = _snakeLenght2;
                        direction = _direction2;
                        snakeIndex = _snakeIndex2;
                        TwoTrue = false;
                        i++;
                        privateVariable = false;
                    }
                    if (i == 3 & ThreeTrue == true & direction == 0)
                    {
                        x = ThreeX;
                        y = ThreeY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght3;
                        snakeNumberLenght = _snakeLenght3;
                        snakeLenght = _snakeLenght3;
                        direction = _direction3;
                        snakeIndex = _snakeIndex3;
                        ThreeTrue = false;
                        i++;
                        privateVariable = false;
                    }
                    if (i == 4 & FourTrue == true & direction == 0)
                    {
                        x = FourX;
                        y = FourY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght4;
                        snakeNumberLenght = _snakeLenght4;
                        snakeLenght = _snakeLenght4;
                        direction = _direction4;
                        snakeIndex = _snakeIndex4;
                        i++;
                        FourTrue = false;
                        privateVariable = false;
                    }
                    if (i == 5 & FiveTrue == true & direction == 0)
                    {
                        x = FiveX;
                        y = FiveY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght5;
                        snakeNumberLenght = _snakeLenght5;
                        snakeLenght = _snakeLenght5;
                        direction = _direction5;
                        snakeIndex = _snakeIndex5;
                        i++;
                        FiveTrue = false;
                        privateVariable = false;

                    }
                    if (i == 6 & SixTrue == true & direction == 0)
                    {
                        x = SixX;
                        y = SixY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght6;
                        snakeNumberLenght = _snakeLenght6;
                        snakeLenght = _snakeLenght6;
                        direction = _direction6;
                        snakeIndex = _snakeIndex6;
                        SixTrue = false;
                        i++;
                        privateVariable = false;


                    }
                    if (i == 7 & SevenTrue == true & direction == 0)
                    {
                        x = SevenX;
                        y = SevenY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght7;
                        snakeNumberLenght = _snakeLenght7;
                        snakeLenght = _snakeLenght7;
                        direction = _direction7;
                        snakeIndex = _snakeIndex7;
                        i++;
                        SevenTrue = false;
                        privateVariable = false;
                    }
                    if (i == 8 & EightTrue ==true & direction == 0)
                    {
                        x = EightX;
                        y = EightY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght8;
                        snakeNumberLenght = _snakeLenght8;
                        snakeLenght = _snakeLenght8;
                        direction = _direction8;
                        snakeIndex = _snakeIndex8;
                        EightTrue = false;
                        i++;
                        privateVariable = false;
                    }
                    if (i == 9 & NineTrue == true & direction == 0)
                    {
                        x = NineX;
                        y = NineY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght9;
                        snakeNumberLenght = _snakeLenght9;
                        snakeLenght = _snakeLenght9;
                        direction = _direction9;
                        snakeIndex = _snakeIndex9;
                        i++;
                        NineTrue = false;
                        privateVariable = false;
                    }
                    if (i == 10 & TenTrue == true & direction == 0)
                    {
                        x = TenX;
                        y = TenY;
                        j = 0;
                        fullSnakeLenght = _fullSnakeLenght10;
                        snakeNumberLenght = _snakeLenght10;
                        snakeLenght = _snakeLenght10;
                        direction = _direction10;
                        snakeIndex = _snakeIndex10;
                        i = 1;
                        TenTrue = false;
                        privateVariable = false;
                    }
                }

                if (direction == 1)
                {
                    if (fullSnakeLenght == true)
                    {
                        x++;
                        j++;
                        Console.SetCursorPosition(x - (snakeIndex + 1), y);
                        Console.Write(_snakeSpace);
                        if (j == snakeIndex)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                    else
                    {
                        x++;
                        snakeLenght--;
                        Console.SetCursorPosition(x - (snakeNumberLenght + 1), y);
                        Console.Write(_snakeSpace);
                        if (snakeLenght == 0)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                }
                if (direction == 2)
                {
                    if (fullSnakeLenght == true)
                    {
                        y++;
                        j++;
                        Console.SetCursorPosition(x, y - (snakeIndex + 1));
                        Console.Write(_snakeSpace);
                        if (j == snakeIndex)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                    else
                    {
                        y++;
                        snakeLenght--;
                        Console.SetCursorPosition(x, y - (snakeNumberLenght + 1));
                        Console.Write(_snakeSpace);
                        if (snakeLenght == 0)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                }
                if (direction == 3)
                {
                    if (fullSnakeLenght == true)
                    {
                        x--;
                        j++;
                        Console.SetCursorPosition(x + (snakeIndex + 1), y);
                        Console.Write(_snakeSpace);
                        if (j == snakeIndex)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                    else
                    {
                        x--;
                        snakeLenght--;
                        Console.SetCursorPosition(x + (snakeNumberLenght + 1), y);
                        Console.Write(_snakeSpace);
                        if (snakeLenght == 0)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                }
                if (direction == 4)
                {
                    if (fullSnakeLenght == true)
                    {
                        y--;
                        j++;
                        Console.SetCursorPosition(x, y + (snakeIndex + 1));
                        Console.Write(_snakeSpace);
                        if (j == snakeIndex)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                    else
                    {
                        y--;
                        snakeLenght--;
                        Console.SetCursorPosition(x, y + (snakeNumberLenght + 1));
                        Console.Write(_snakeSpace);
                        if (snakeLenght == 0)
                        {
                            privateVariable = true;
                            direction = 0;
                        }
                    }
                }
            } while (input != ConsoleKey.Escape);
        }
    }
}
