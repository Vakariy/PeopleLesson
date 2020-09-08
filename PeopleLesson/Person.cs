using System;
using System.Collections.Generic;
using System.Text;

namespace PeopleLesson
{
    public class Person
    {
        public string Name;
        public int IndicatorOfHungry;
        public int IndicatorForNeedsWater;
        public int Money;

        public int AmountApple;
        public int AmountWater_L;
        public int EatAppleForOnce;
        public int DrinkWaterForOnce;

        public int AppleCosts = 7;
        public int WaterCosts = 2;

        public void ShowParameters()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("IndicatorOfHungry: " + IndicatorOfHungry);
            Console.WriteLine("IndicatorForNeedsWater: " + IndicatorForNeedsWater);
            Console.WriteLine("Money: " + Money);
            Console.WriteLine("AmountApple: " + AmountApple);
            Console.WriteLine("AmountWater_L: " + AmountWater_L);
            Console.WriteLine("DrinkWaterForOnce: " + DrinkWaterForOnce);
            Console.WriteLine("AppleCosts: " + AppleCosts);
            Console.WriteLine("WaterCosts: " + WaterCosts);
        }

        public void Drink()
        {
            if (AmountWater_L == 0)
            {
                Console.WriteLine("You havan't got any water.");
            }

            int temp;
            if (IndicatorForNeedsWater == 0)
            {
                Console.WriteLine("I don't need to drink!");
            }
            
            if(IndicatorForNeedsWater > 0)
            {
                if (IndicatorForNeedsWater >= DrinkWaterForOnce)
                {
                    IndicatorForNeedsWater -= DrinkWaterForOnce;
                    AmountWater_L -= DrinkWaterForOnce;
                }
                else if (IndicatorForNeedsWater < DrinkWaterForOnce)
                {
                    temp = DrinkWaterForOnce - IndicatorForNeedsWater;
                    AmountWater_L -= temp;
                    IndicatorForNeedsWater -= temp;
                    Console.WriteLine("I want to drink just " + temp + " L of water.");
                }
            }   
        }

        public void Eat()
        {
            if (AmountApple == 0)
            {
                Console.WriteLine("You havan't got any apples.");
            }

            int temp;
            if (IndicatorOfHungry == 0)
            {
                Console.WriteLine("I don't need to eat!");
            }

            if (IndicatorOfHungry > 0)
            {
                if (IndicatorOfHungry >= EatAppleForOnce)
                {
                    IndicatorOfHungry -= EatAppleForOnce;
                    AmountApple -= EatAppleForOnce;
                }
                else if (IndicatorOfHungry < EatAppleForOnce)
                {
                    temp = EatAppleForOnce - IndicatorOfHungry;
                    AmountApple -= temp;
                    IndicatorForNeedsWater -= temp;
                    Console.WriteLine("I want to eat just " + temp + " apples.");
                }
            }
        }

        public void Buy(string what, int amount)
        {
            if (what == "Apple" && amount <= AmountApple)
            {
                if (Money >= (AppleCosts * amount))
                {
                    AmountApple += amount;
                    Money -= AppleCosts * amount;
                } else { Console.WriteLine("You haven't got money!"); }
                
            } else if(what == "Water" && amount <= AmountWater_L)
            {
                if (Money >= (AppleCosts * amount))
                {
                    AmountWater_L += amount;
                    Money -= WaterCosts * amount;
                } else { Console.WriteLine("You haven't got money!"); }
                
            } else { Console.WriteLine("Not apple and not water"); }
        }

        public void Buy(string what, int amount, Person name)
        {
            if (what == "Apple" && amount <= name.AmountApple)
            {
                if (Money >= (AppleCosts * amount))
                {
                    name.AmountApple -= amount;
                    name.Money += AppleCosts * amount;
                    AmountApple += amount;
                    Money -= AppleCosts * amount;
                } else { Console.WriteLine("You haven't got money!"); }
                
            } else if(what == "Water" && amount <= name.AmountWater_L)
            {
                if (Money >= (WaterCosts * amount))
                {
                    name.AmountWater_L -= amount;
                    name.Money += WaterCosts * amount;
                    AmountWater_L += amount;
                    Money -= WaterCosts * amount;
                } else { Console.WriteLine("You haven't got money!"); }

            } else { Console.WriteLine("Not apple and not water"); }
        }

        public void Sell(string what, int amount)
        {
            if (what == "Apple" && amount <= AmountApple)
            {
                AmountApple -= amount;
                Money += AppleCosts * amount;
            }
            else if (what == "Water" && amount <= AmountWater_L)
            {
                AmountWater_L -= amount;
                Money += WaterCosts * amount;
            }
            else
            {
                Console.WriteLine("Not apple and not water");
            }
        }

        public void Sell(string what, int amount, Person name)
        {
            if (what == "Apple" && amount <= name.AmountApple)
            {
                name.AmountApple += amount;
                name.Money -= AppleCosts * amount;
                AmountApple -= amount;
                Money += AppleCosts * amount;
            }
            else if (what == "Apple" && amount <= name.AmountApple)
            {
                name.AmountApple += amount;
                name.Money -= AppleCosts * amount;
                AmountWater_L -= amount;
                Money += WaterCosts * amount;
            }
            else
            {
                Console.WriteLine("Not apple and not water");
            }
        }


    }
}
