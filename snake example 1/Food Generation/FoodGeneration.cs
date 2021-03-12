using System;
using System.Collections.Generic;
using System.Text;

namespace snake_example_1.Food_Generation
{
    public class FoodGeneration
    {
        public static int _FoodX { get; set; }
        public static int _FoodY { get; set; }

        public static void RandomFoodGeneration(int FoodPosition = 90)
        {
            int FoodPositionY = FoodPosition / 3;

            Random RndXPos = new Random();
            Random RndYPos = new Random();

            //Random generation position for x and y
            _FoodX = RndXPos.Next(1, FoodPosition - 1);
            _FoodY = RndYPos.Next(1, FoodPositionY - 1);

            Console.SetCursorPosition(_FoodX, _FoodY);
            Console.Write('@');

            Console.CursorVisible = false;
        }
    }
}
