using snake_example_1.Food_Generation;
using System;
using System.Collections.Generic;
using System.Text;

namespace snake_example_1.Snake_Generation
{
    public class SnakeGeneration : FoodGeneration
    {
        public static int _x { get; set; }
        public static int _y { get; set; }

        public static int OneX { get; set; }
        public static int OneY { get; set; }
        public static int TwoX { get; set; }
        public static int TwoY { get; set; }
        public static int ThreeX { get; set; }
        public static int ThreeY { get; set; }
        public static int FourX { get; set; }
        public static int FourY { get; set; }
        public static int FiveX { get; set; }
        public static int FiveY { get; set; }
        public static int SixX { get; set; }
        public static int SixY { get; set; }
        public static int SevenX { get; set; }
        public static int SevenY { get; set; }
        public static int EightX { get; set; }
        public static int EightY { get; set; }
        public static int NineX { get; set; }
        public static int NineY { get; set; }
        public static int TenX { get; set; }
        public static int TenY { get; set; }
        public static bool _fullSnakeLenght { get; set; }
        public static int _snakeLenght { get; set; }
        public static int _direction { get; set; }
        public static bool _fullSnakeLenght2 { get; set; }
        public static int _snakeLenght2 { get; set; }
        public static int _direction2 { get; set; }
        public static bool _fullSnakeLenght3 { get; set; }
        public static int _snakeLenght3 { get; set; }
        public static int _direction3 { get; set; }
        public static bool _fullSnakeLenght4 { get; set; }
        public static int _snakeLenght4 { get; set; }
        public static int _direction4 { get; set; }
        public static bool _fullSnakeLenght5 { get; set; }
        public static int _snakeLenght5 { get; set; }
        public static int _direction5 { get; set; }
        public static bool _fullSnakeLenght6 { get; set; }
        public static int _snakeLenght6 { get; set; }
        public static int _direction6 { get; set; }
        public static bool _fullSnakeLenght7 { get; set; }
        public static int _snakeLenght7 { get; set; }
        public static int _direction7 { get; set; }
        public static bool _fullSnakeLenght8 { get; set; }
        public static int _snakeLenght8 { get; set; }
        public static int _direction8 { get; set; }
        public static bool _fullSnakeLenght9 { get; set; }
        public static int _snakeLenght9 { get; set; }
        public static int _direction9 { get; set; }
        public static bool _fullSnakeLenght10 { get; set; }
        public static int _snakeLenght10 { get; set; }
        public static int _direction10 { get; set; }
        public static int _snakeIndex1 { get; set; }
        public static int _snakeIndex2 { get; set; }
        public static int _snakeIndex3 { get; set; }
        public static int _snakeIndex4 { get; set; }
        public static int _snakeIndex5 { get; set; }
        public static int _snakeIndex6 { get; set; }
        public static int _snakeIndex7 { get; set; }
        public static int _snakeIndex8 { get; set; }
        public static int _snakeIndex9 { get; set; }
        public static int _snakeIndex10 { get; set; }
        public static int i2 { get; set; }
        public static bool OneTrue { get; set; }
        public static bool TwoTrue { get; set; }
        public static bool ThreeTrue { get; set; }
        public static bool FourTrue { get; set; }
        public static bool FiveTrue { get; set; }
        public static bool SixTrue { get; set; }
        public static bool SevenTrue { get; set; }
        public static bool EightTrue { get; set; }
        public static bool NineTrue { get; set; }
        public static bool TenTrue { get; set; }

        public static void RandomSnakeGeneration(int SnakeGenerationPosition = 90)
        {


            int SnakeGenerationPositionY = SnakeGenerationPosition / 3;

            Random RandomSnakeX = new Random();
            Random RandomSnakeY = new Random();


            //RndPositionSnake x, y
            _x = RandomSnakeX.Next(1, SnakeGenerationPosition - 1);
            _y = RandomSnakeY.Next(1, SnakeGenerationPositionY - 1);

            char snake = '*';

            //Drawing random position snake for x and y  
            Console.SetCursorPosition(_x, _y);
            Console.Write(snake);

            Console.CursorVisible = false;
        }
    }
}
