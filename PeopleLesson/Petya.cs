using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLesson
{
    public class Petya : Person
    {
        public Petya()
        {
            this.Name = "Petro";
            this.IndicatorOfHungry = 9;
            this.IndicatorForNeedsWater = 5;
            this.AmountApple = 5;
            this.AmountWater_L = 1;
            this.EatAppleForOnce = 4;
            this.DrinkWaterForOnce = 2;
            this.Money = 1000;
        }

        public void PlayDota()
        {
            Console.WriteLine(Name + ": I can play Dota 2. However, I can't drive a bus.");
        }
    }
}
