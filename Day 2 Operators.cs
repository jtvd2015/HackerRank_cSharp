using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        double mealCost = Convert.ToDouble(Console.ReadLine());
        int tipPercent = Convert.ToInt32(Console.ReadLine());
        int taxPercent = Convert.ToInt32(Console.ReadLine());

        var tip = tipPercent * mealCost / 100;        
        var tax = taxPercent * mealCost / 100;

        var totalCost = Math.Round(tip + tax + mealCost);

        Console.WriteLine($"The total meal cost is {totalCost} dollars.");
    }
}