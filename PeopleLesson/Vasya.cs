using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLesson
{
    public class Vasya : Person
    {
        public Vasya()
        {
            this.Name = "Vasya";
            this.IndicatorOfHungry = 3;
            this.IndicatorForNeedsWater = 3;
            this.AmountApple = 5;
            this.AmountWater_L = 2;
            this.EatAppleForOnce = 4;
            this.DrinkWaterForOnce = 1;
            this.Money = 400;
        }

        public void Drive()
        {
            Console.WriteLine(Name + ": I can drive a bus!");
        }
    }
}
