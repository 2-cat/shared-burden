// https://repl.it/languages/csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SoloLearn
{
    class Program
    {
        private static decimal NetIncome_M = 1981m;
        private static decimal NetIncome_P = 2402m;
        private static decimal NetTotalIncome { get { return NetIncome_M + NetIncome_P; } }
        
        private static List<decimal> SharedExpenses = new List<decimal>();
        private static decimal TotalSharedExpenses { get { return SharedExpenses.Sum(); } }
        
        private static List<decimal> SharedSavings = new List<decimal>();
        private static decimal TotalSharedSavings { get { return SharedSavings.Sum(); } }
        
        private static List<decimal> Expenses_M = new List<decimal>();
        private static List<decimal> Expenses_P = new List<decimal>();
        private static decimal TotalExpenses_M { get { return Expenses_M.Sum(); } }
        private static decimal TotalExpenses_P { get { return Expenses_P.Sum(); } }
        
        private static decimal IncomePercentage_M { get; set; }
        private static decimal IncomePercentage_P { get; set; }
        
        private static decimal ToPay_M { get; set; }
        private static decimal ToPay_P { get; set; }
        
        private static decimal Remaining_M { get { return NetIncome_M - TotalExpenses_M - ToPay_M; } }
        private static decimal Remaining_P { get { return NetIncome_P - TotalExpenses_P - ToPay_P; } }
        
        static void Main(string[] args)
        {
            SetExpenses_P();
            SetExpenses_M();
            SetSharedExpenses();
            SetSharedSavings();
            
            IncomePercentage_M = GetPercentageOfIncome(NetIncome_M);
            IncomePercentage_P = GetPercentageOfIncome(NetIncome_P);
            
            ToPay_M = GetPercentageOfSharedExpenses(IncomePercentage_M);
            ToPay_P = GetPercentageOfSharedExpenses(IncomePercentage_P);
            
            
            
            Console.WriteLine("\t\tM\t\tP");
            Console.WriteLine("---------------------------------------");
            
            Console.WriteLine($"Income:\t\t\t{NetIncome_M}\t\t{NetIncome_P}");
            Console.WriteLine($"Percentage:\t\t{IncomePercentage_M} %\t\t{IncomePercentage_P} %");
            Console.WriteLine($"Shared burden:\t\t{ToPay_M}\t\t{ToPay_P}");
            Console.WriteLine($"Expenses: \t\t{TotalExpenses_M}\t\t{TotalExpenses_P}");
            Console.WriteLine($"Income left:\t\t{Remaining_M}\t\t{Remaining_P}");
            Console.WriteLine("");
            Console.WriteLine("-----");
            Console.WriteLine($"Shared Expenses:");
            Console.WriteLine($"{TotalSharedExpenses}");
            Console.WriteLine("-----");
            Console.WriteLine($"Shared Savings:");
            Console.WriteLine($"{TotalSharedSavings}");
            Console.WriteLine("-----");
            Console.WriteLine($"Total Burden:");
            Console.WriteLine($"{TotalSharedExpenses + TotalSharedSavings}");
            Console.WriteLine("-----");
            Console.WriteLine($"Total Income:");
            Console.WriteLine($"{NetIncome_M + NetIncome_P}");
            
            
            
        }
        
        private static decimal GetPercentageOfIncome(decimal income)
        {
            decimal percentage = income / NetTotalIncome;
            
            return decimal.Round(percentage * 100, 2, MidpointRounding.AwayFromZero);
        }
        
        private static decimal GetPercentageOfSharedExpenses(decimal percentage)
        {
            var total = TotalSharedExpenses + TotalSharedSavings;
            
            return decimal.Round((total / 100) * percentage, 2, MidpointRounding.AwayFromZero);
        }
        
        private static void SetSharedExpenses()
        {
            SharedExpenses.Add(21.44m);
            
            SharedExpenses.Add(8.28m); 
            
            SharedExpenses.Add(111.24m); 
            
            SharedExpenses.Add(22.98m); 
            
            SharedExpenses.Add(10m); 
            
            SharedExpenses.Add(28m); 
            
            SharedExpenses.Add(53m); 
            
            SharedExpenses.Add(1.7m); 
            
            SharedExpenses.Add(1.1m); 
            
            SharedExpenses.Add(400m); 
            
            SharedExpenses.Add(100m); 
            
            SharedExpenses.Add(921.84m); 
            
            SharedExpenses.Add(20m);
             
        }
        
        private static void SetSharedSavings() 
        {
            SharedSavings.Add(140m);  
            
            SharedSavings.Add(100m);  
            
            SharedSavings.Add(25m); 
            
            SharedSavings.Add(100m);  
            
            SharedSavings.Add(100m); 
            
            SharedSavings.Add(100m); 
            
            SharedSavings.Add(200m); 
        }
        
        private static void SetExpenses_M() 
        {
            Expenses_M.Add(25.78m);
            
            Expenses_M.Add(7.50m);
            
            Expenses_M.Add(113m);
            
            Expenses_M.Add(120m);
            
            Expenses_M.Add(55.34m);
            
            Expenses_M.Add(14.99m);
            
            Expenses_M.Add(2.40m);
            
            Expenses_M.Add(2.93m);
            
        }
        
        private static void SetExpenses_P()
        {
            Expenses_P.Add(18.32m);
            
            Expenses_P.Add(33.21m);
            
            Expenses_P.Add(91.00m);
            
            Expenses_P.Add(5m);
            
            Expenses_P.Add(12.15m);
            
            Expenses_P.Add(12.10m);
            
            Expenses_P.Add(3.5m);
            
            Expenses_P.Add(1.70m);
            
            Expenses_P.Add(75m);
        }
    }
}
