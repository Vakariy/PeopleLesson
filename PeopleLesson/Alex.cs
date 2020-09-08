using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLesson
{
    public class Alex: Person
    {
        public Alex()
        {
            this.Name = "Alex";
            this.IndicatorOfHungry = 5;
            this.IndicatorForNeedsWater = 10;
            this.AmountApple = 20;
            this.AmountWater_L = 2;
            this.EatAppleForOnce = 3;
            this.DrinkWaterForOnce = 1;
            this.Money = 50;
        }

        public void MyDream()
        {
            Console.WriteLine(Name + ": I want to give my skill of programming to my child in the future.");
        }

        public void ProgrammingSkill()
        {
            Console.WriteLine(Name + ": I can programming!");
        }
    }
}
