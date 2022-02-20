using System;
using System.Collections.Generic;



namespace Task
{
    public class Error : Exception
    {
        public Error(String message) : base(message)
        {



        }



    }
    public delegate int AccountDeposit();
    class Bank
    {
        String Acc_name, Address;
        int Acc_Amount, Acc_Number, am_wd;
        string choice;
        double Balance = 500;
        int count = 0;
        int user_choice;
        public void DisplayCustomerDetails()
        {
            Employee emp = new Employee()
            {
                id = 101,
                name = "Praveen",
                Gender = "male",
                salary = 20000
            };
            Employee emp1 = new Employee()
            {
                id = 102,
                name = "Anu",
                Gender = "Female",
                salary = 20500



            };
            Employee emp2 = new Employee()
            {
                id = 103,
                name = "Aravind",
                Gender = "male",
                salary = 20333
            };



            List<Employee> employeeList = new List<Employee>();
            employeeList.Add(emp);
            employeeList.Add(emp1);
            employeeList.Add(emp2);
            foreach (Employee employees in employeeList)
            {
                Console.Write("The Employees list are displayed here\n");
                Console.WriteLine("id={0} || name={1} || gender={2} || Salary={3}", employees.id, employees.name, employees.Gender, employees.salary);
            }
        }
        public int Savings_Account()
        {
            try
            {
                Console.WriteLine("------------------------------");
                Console.WriteLine("Welcome to the Savings Account");
                Console.WriteLine("Your daily limit is 100000");
                Console.WriteLine("-----------------------------");
                Console.Write("Enter Account Holder Name:\n");
                Acc_name = Console.ReadLine();
                Console.WriteLine("Enter Account Number");
                Console.Write("Enter the Last Four Digit of your account number: \n");
                Acc_Number = int.Parse(Console.ReadLine());
                Console.Write("Enter the Address:\n");
                Address = Console.ReadLine();
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 100000)
                {
                    throw (new Error("Please Check the amount you have entered"));
                }
                else
                {
                    this.Balance = Balance + Acc_Amount;
                    Console.WriteLine("The amount is deposited");
                    Console.Write("The amount deposited is : " + this.Balance);
                }
                Console.WriteLine("\nIf you need ATM Card! Press\n 1. To WithDraw \n 2. To skip this step");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        while (count < 3)
                        {
                            Console.WriteLine("\n---------------------------------------");
                            Console.WriteLine("ATM Card WithDrawl is Processing");
                            Console.Write("Enter the amount to be withdrawl:\n");
                            am_wd = int.Parse(Console.ReadLine());
                            if (this.Balance == 0)
                            {
                                Console.WriteLine("Insufficient balance");
                            }
                            else if (am_wd > this.Balance)
                            {
                                Console.WriteLine("Insufficient Balance");
                            }
                            else
                            {
                                this.Balance = this.Balance - am_wd;
                                Console.Write("Balance: " + this.Balance);
                            }
                            Console.Write("\n^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
                            Console.WriteLine("\nDo you want to continue?");
                            Console.Write("Press\n1.Yes\n2.No\n");

                            user_choice = int.Parse(Console.ReadLine());
                            count++;
                            if (count == 3)
                            {
                                this.Balance = this.Balance - 500;
                                Console.Write("Current Balance is: " + this.Balance);
                                Console.WriteLine("\nAs you have exceeded the limit we have debited Rs-500/ from your account");
                                Console.WriteLine("\nYou have exceeded the limit please wait for next 24 hours");
                            }
                            if (user_choice == 2)
                            {
                                break;
                            }
                            else
                            {
                                continue;
                            }
                        }
                        break;
                    case "2":
                        return 1;
                    default:
                        Console.WriteLine("Invalid Choice!!");
                        break;
                }
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }
            return 1;
        }
        public int Current_Account()
        {
            try
            {
                Console.WriteLine("---------------------------------");
                Console.WriteLine("Currently you are in Current Account");
                Console.WriteLine("Your daily limit is 200000");
                Console.WriteLine("---------------------------------");
                Console.Write("Enter Account Holder Name:\n");
                Acc_name = Console.ReadLine();
                Console.WriteLine("Enter Account Number");
                Console.Write("Enter the Last Four Digit of ur account number: \n");
                Acc_Number = int.Parse(Console.ReadLine());
                Console.Write("Enter the Address:\n");
                Address = Console.ReadLine();
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 200000)
                {
                    throw (new Error("Please Check the amount you have entered"));
                }
                else
                {
                    Console.WriteLine("The amount is deposited");
                    Console.Write("The amount deposited is : " + Acc_Amount);
                }
                Console.WriteLine("\nIf you need ATM Card!!! Press\n 1. To Activate \n 2. To skip this step");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("ATM Card Activation is Processing");
                        break;
                    case "2":
                        return 2;
                    default:
                        Console.WriteLine("Invalid input! Please ensure that you are giving correct choice");
                        break;
                }
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }
            return 2;
        }
        public int ChildCare_Account()
        {
            try
            {
               
                Console.WriteLine("Welcome to the ChildCare Account");
                Console.WriteLine("Your daily limit is 500000");
                Console.WriteLine("-----------------------------------");
                Console.Write("Enter Account Holder Name: ");
                Acc_name = Console.ReadLine();
                Console.WriteLine("Enter Account Number");
                Console.Write("Enter the Last Four Digit of your account number: \n");
                Acc_Number = int.Parse(Console.ReadLine());
                Console.Write("Enter the Address:\n");
                Address = Console.ReadLine();
                Console.WriteLine("Enter the amount to be deposited: ");
                Acc_Amount = int.Parse(Console.ReadLine());
                if (Acc_Amount > 500000)
                {
                    throw (new Error("The deposit limit is exceeded. Please enter the amount within 500000\n"));
                }
                else
                {
                    Console.WriteLine("The amount is deposited\n");
                    Console.Write("The amount deposited is : " + Acc_Amount);
                }
                Console.WriteLine("\nIf you need ATM Card!!! Press\n 1. To Activate \n 2. To skip this step");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("ATM Card Transaction is Processing");



                        break;
                    case "2":
                        return 3;
                    default:
                        Console.WriteLine("Invalid input! Please ensure that you are giving correct choice");
                        break;
                }
            }
            catch (Error e)
            {
                Console.WriteLine(e.Message);
            }
            return 3;
        }
        public class Employee
        {
            public int id
            {
                get; set;
            }
            public string name
            {
                get;
                set;
            }
            public string Gender
            {
                get;
                set;
            }
            public double salary
            {
                get;
                set;
            }
        }
        class bank1
        {
            public static void Main(String[] args)
            {
                int choice_selected;
                String ch;
                Bank bank = new Bank();
                AccountDeposit accDep = new AccountDeposit(bank.Savings_Account);
                for (; ; )
                {
                    Console.WriteLine("Welcome to the HDFC Bank");
                    Console.WriteLine("********************");
                    Console.WriteLine("Enter any one number to proceed further : \n 1. Savings Account\n 2. Current Account\n 3. ChildCare Account\n 4. Employee List\n 5. Exit");
                    Console.WriteLine("******************");
                    ch = Console.ReadLine();



                    switch (ch)
                    {
                        case "1":
                            accDep();
                            break;
                        case "2":
                            accDep += bank.Current_Account;
                            accDep();
                            break;
                        case "3":
                            accDep += bank.ChildCare_Account;
                            accDep();
                            break;
                        case "4":
                            bank.DisplayCustomerDetails();
                            break;
                        case "5":
                            System.Environment.Exit(0);
                            break;
                        default:
                            Console.WriteLine("Invalid Choice!!");
                            break;



                    }



                }



            }
        }
    }
}