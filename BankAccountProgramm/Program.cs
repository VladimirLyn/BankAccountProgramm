using System;
using System.Collections.Generic;
using System.IO;

namespace BankAccountProgramm
{
    class Program
    {
       public class  BankAccount
        {
          static public decimal Money;
          static public decimal name;
          static public decimal ID;
        }

      public class Transaction
        {
            public static void Receiving()
            {
                Console.WriteLine("Сколько");
                string S_sum = Console.ReadLine();
                decimal D_sum = decimal.Parse(S_sum);
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

           
        }

            
        

        BankAccount MyBankAccount = new BankAccount();

        static void Main(string[] args)
        {
           
           
                Console.WriteLine("Введите количество Денег");
                BankAccount.Money = decimal.Parse( Console.ReadLine());
                
            

            while (true)
            {
                Console.WriteLine("Выберите тип Операции 1) Получение, 2) Трата");
                string S_TypeOfOperation = Console.ReadLine();
                byte B_TypeOfOperation = byte.Parse(S_TypeOfOperation);



                if(B_TypeOfOperation == 1)
                {
                    Transaction.Receiving();
                }
                       
                if (B_TypeOfOperation == 2)
                {
                    Transaction.Waste();
                }
                
            }

            
            
        }
    }
}
