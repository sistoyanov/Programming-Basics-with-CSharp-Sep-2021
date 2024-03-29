﻿using System;

namespace _11._Clever_Lily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double washingMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            int money = 0;
            int totalMoney = 0;
            int toys = 0;
            int missingMoney = 0;
            double savedMoney = 0;

            for (int i = 1; i <= years ; i++)
            {
                if (i % 2 == 0)
                {
                   money += 10;
                   totalMoney = money + totalMoney;
                   missingMoney++;
                }
                else
                {
                    toys++;
                }
            }

            savedMoney = (totalMoney - missingMoney) + (toyPrice * toys);
           
            if (savedMoney >= washingMachinePrice)
            {
                Console.WriteLine($"Yes! {(savedMoney - washingMachinePrice):f2}");
            }
            else
            {
                Console.WriteLine($"No! {(washingMachinePrice - savedMoney):f2}");
            }
        }
    }
}
