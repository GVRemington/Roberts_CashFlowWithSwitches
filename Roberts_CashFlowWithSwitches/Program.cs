using System;

/*
 * Name:  Rayleen Roberts
 * Class: IT 112
 * Notes: I did it!! I tried a variety of if/else bools to check for 
 *        full array, to no avail when used in conjunction 
 *        with Switch...I finally thought of a check variable
 *        as you can see...works like a charm. YEY.
 *        It was fun to challenge myself on this assignment.
 *        C++ actually helped me alot in regards to using bools
 *        and switches. This is the 4th iteration of this assignment,
 *        could implement interfaces, inheritance, and enums in my 
 *        sleep at this point hahaha. 
 *        
 * Behaviors Not Implemented: None
 * PS:     It's been a great year!! I've come to enjoy your class
 *         a great deal. Thank You for the patience and good teaching;
 *         See You In the Fall!!
 */

namespace Roberts_CashFlowWithSwitches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ledger ledger = new Ledger();
            IPayable[] payables = new IPayable[9];
            string firstName;
            string lastName;
            string ssn;
            int arrayFull = 6;//**this is my check for array Full...I left enough room
                              //**for you to add one more of each kind and then my array full
                              //**catch will kick in.

            bool Go = true;
            int choice;

            payables[0] = new SalariedEmployee("John", "Smith", "111-11-1111", 800.50M);
            payables[1] = new SalariedEmployee("Susan", "Matthews", "222-22-2222", 1110.00M);
            payables[2] = new HourlyEmployee("Karen", "Williams", "444-44-4444", 16.75M, 40);
            payables[3] = new HourlyEmployee("Carol", "Walsh", "333-33-3333", 19.50M, 42);
            payables[4] = new Invoice("4567", "Flux Capacitor", 2, 3655.66M);
            payables[5] = new Invoice("3456", "Baseball Bat", 3, 14.50M);
            /*
             * Note on Invoices: the numbers you see here represent part numbers,
             * random invoice numbers are generated in the class itself,
             * and will print out in the report.
             */
            Console.WriteLine("--->Cash Flow Manager<---");
        
            while(Go)
            {

                for (int i = 6; i < payables.Length; i++)
                {
                    arrayFull++;

                    if (arrayFull <= 9)
                    {
                        Console.WriteLine(ledger.Menu1());
                        choice = int.Parse(Console.ReadLine());
                       
                        switch (choice)
                        {
                            case 1:
                                Console.WriteLine("Employee First Name:  ");
                                firstName = Console.ReadLine();
                                Console.WriteLine("Employee Last Name:   ");
                                lastName = Console.ReadLine();
                                Console.WriteLine("Social Security Number (include dashes): ");
                                ssn = Console.ReadLine();
                                Console.WriteLine("Hourly Wage:  ");
                                decimal wage = decimal.Parse(Console.ReadLine());
                                Console.WriteLine("Hours Worked: ");
                                int hours = int.Parse(Console.ReadLine());
                                payables[i] = new HourlyEmployee(firstName, lastName, ssn, wage, hours);
                                break;
                            case 2:
                                Console.WriteLine("Employee First Name:  ");
                                firstName = Console.ReadLine();
                                Console.WriteLine("Employee Last Name:   ");
                                lastName = Console.ReadLine();
                                Console.WriteLine("Social Security Number (include dashes): ");
                                ssn = Console.ReadLine();
                                Console.WriteLine("Weekly Salary:  ");
                                decimal salary = decimal.Parse(Console.ReadLine());
                                payables[i] = new SalariedEmployee(firstName, lastName, ssn, salary);
                                break;
                            case 3:
                                Console.WriteLine("Part No.     ");
                                string partNum = Console.ReadLine();
                                Console.WriteLine("Part Description:   ");
                                string partDesc = Console.ReadLine();
                                Console.WriteLine("Quantity: ");
                                int quantity = int.Parse(Console.ReadLine());
                                Console.WriteLine("Price Per Unit:  ");
                                decimal price = decimal.Parse(Console.ReadLine());
                                payables[i] = new Invoice(partNum, partDesc, quantity, price);
                                break;
                            case 4:
                                Go = false;
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\t****Attention: Ledger is Now Full****"+
                                          "\n\t***Press Any Key to Print and Exit***");
                        Console.ReadKey(true);
                        Go = false;
                        break;
                    }
                   
                }
          
            }
            foreach (IPayable payable in payables)
            {
                if (payable == null)
                {
                    continue;
                }
                else
                {
                    if (payable.ledgerType == Ledger.LedgerType.Hourly)
                    {
                        ledger.setHourlyTotal(payable.Payable);
                    }
                    else if (payable.ledgerType == Ledger.LedgerType.Salaried)
                    {
                        ledger.setSalariedTotal(payable.Payable);
                    }
                    else if (payable.ledgerType == Ledger.LedgerType.Invoice)
                    {
                        ledger.setInvoiceTotal(payable.Payable);
                    }
                    Console.WriteLine(payable.ToString());
                }
            }
            Console.WriteLine("\n\tWeekly Total and Breakdowns:");
            Console.WriteLine(ledger.ToString());
            Environment.Exit(0);
           
        }
    }
}

