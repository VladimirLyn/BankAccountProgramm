using System;
using System.Collections.Generic;
using System.IO;

namespace BankAccountProgramm
{
    class Program
    {
        public class BankAccount
        {
            static public decimal Money;
            static public string Name;
            static public decimal ID;
        }

        public class HistoryTransaction
        {
            public decimal Score;
            public HistoryTransaction(decimal Score)
            {
                this.Score = Score;
            }
        }

      public class Transaction
        {
            public static string S_sum;
            public static decimal D_sum;
            public decimal MoneyForHistory = D_sum;

            public static void Receiving()
            {
                Console.WriteLine("Сколько");
                S_sum = Console.ReadLine();
                D_sum = decimal.Parse(S_sum);
                BankAccount.Money += D_sum;
                Console.WriteLine("Ваши деньги : " + BankAccount.Money);
            }
            public static void Waste()
            {
                Console.WriteLine("Сколько");
                string S_sum = Console.ReadLine();
                decimal D_sum = decimal.Parse(S_sum);
                BankAccount.Money -= D_sum;
                Console.WriteLine("Ваши деньги : " + BankAccount.Money);
            }
            public static void Credit ()
            {
                Console.WriteLine("Сколько всего, сколько месяцев");
                string S_sum = Console.ReadLine();
                decimal D_sum = decimal.Parse(S_sum);
                int HowManyMonth = int.Parse(Console.ReadLine());
                BankAccount.Money -= D_sum;
                decimal PerMonth = D_sum / HowManyMonth;
                Console.WriteLine($"Вы будете выплачиать по{PerMonth} и у вас останется" + BankAccount.Money) ;
            }

        }

        BankAccount MyBankAccount = new BankAccount();

        static void Main(string[] args)
        {
            List<decimal> L = new List<decimal>();

            Console.WriteLine("Введите Ваше имя");
            BankAccount.Name = Console.ReadLine();
            Console.WriteLine("Введите ID вашего банковского счёта");
            BankAccount.ID = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество Денег");
            BankAccount.Money = decimal.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Выберите тип Операции 1) Получение, 2) Трата 3) Расчёт длительности оплаты по кредиту 4) История Транзакций 5)");
                string S_TypeOfOperation = Console.ReadLine();
                byte B_TypeOfOperation = byte.Parse(S_TypeOfOperation);


                if (B_TypeOfOperation == 1)
                {
                    Transaction.Receiving();
                    L.Add(Transaction.D_sum);
                }

                if (B_TypeOfOperation == 2)
                {
                    Transaction.Waste();
                    L.Add(Transaction.D_sum);
                }

                if (B_TypeOfOperation == 3)
                {
                    Transaction.Waste();
                    L.Add(Transaction.D_sum);
                }

                if(B_TypeOfOperation == 4)
                    {
                    foreach (decimal d in L)
                    {
                        Console.WriteLine($"{d}");
                    }
                }
            }

        }
    }
}

