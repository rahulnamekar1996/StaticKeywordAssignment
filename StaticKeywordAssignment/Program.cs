using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticKeywordAssignment
{
    public class Program
    {
        static void Main(string[] args)
        {

            // Home Work Assignment //


            // Q.2 and Q3 use of static keyword in Employee class 

            /*   Employee emp1 = new Employee( "Rhul", 50000);
               Employee emp2 = new Employee( "rani", 60000);
               Employee emp3 = new Employee( "rushikesh", 55000);
               Employee emp4 = new Employee( "devesh", 65000);
               Employee emp5 = new Employee( "onkar", 70000);

               emp1.DisplayInfo();
               emp2.DisplayInfo();
               emp3.DisplayInfo();
               emp4.DisplayInfo();
               emp5.DisplayInfo();

               Console.WriteLine($"Total number of employees: {Employee.TotalEmp()}");*/

            // Q.4 Overloading Demo

            /* OverloadingDemo o1 = new OverloadingDemo();

             int result1 = o1.Add(5, 10);
             Console.WriteLine($"Result of adding two integers: {result1}");

             double result2 = o1.Add(2.5, 3.5);
             Console.WriteLine($"Result of adding two doubles: {result2}");

             int result3 = o1.Add(3, 6, 9);
             Console.WriteLine($"Result of adding three integers: {result3}");*/

            // Q.5 Overriding demo with Example

            /*OverridingDemo o = new Circle(5);
            OverridingDemo o1 = new Rectangle(4, 6);

            Console.WriteLine("Area of circle: " + o.CalculateArea());
            Console.WriteLine("Area of rectangle: " + o1.CalculateArea());*/

            // Q.6 This keyword Demo

            /*ThisKeyWordDemo book1 = new ThisKeyWordDemo("p.v shantaram", "1942 a love story", 1925);
            book1.DisplayDetails();

            // Changing the book details
            book1.SetTitle("RamCharn");
            book1.SetAuthor("mishra p.j");
            book1.SetYear(1960);

            Console.WriteLine("\nUpdated Details:");
            book1.DisplayDetails();*/


            // Q.8 1.	WAP which contain default constructor,
            // parameterized constructor, one static method,
            // one instance method, and show the execution sequence.
            // Accessing static variable directly


            /* Creating an instance of the class
            DemoOfAllMembers obj = new DemoOfAllMembers();

            // Calling parameterized constructor
            DemoOfAllMembers obj2 = new DemoOfAllMembers(20);

            // Calling static method
            DemoOfAllMembers.StaticMethod();

            // Calling instance method
            obj.InstanceMethod();*/


            // Q.9 .	WAP to show ambiguity in method overloading
            /* AmbuiguityOverloadingDemo obj = new AmbuiguityOverloadingDemo();
             obj.OverloadedMethod(5, 10); */



            // Q.10 	WAP to overload static method.
            /* Console.WriteLine("Add(5, 10): " + StaticMethodOverloading.Add(5, 10));
             Console.WriteLine("Add(5, 10, 15): " + StaticMethodOverloading.Add(5, 10, 15));
             Console.WriteLine("Add(3.5, 2.7): " +StaticMethodOverloading.Add(3.5, 2.7));*/




            //  Additional Assignment //

            /*Q.1  Write a method to convert currency from rs.to dollars.
             It will take rs.As input and return the equivalent amount in dollars.
             The exchange rate is 69.2 rs equals 1$ */

            /* double rupeesAmount = 1000;
             double dollarsEquivalent = ConvertCurrancy. ConvertToDollars(rupeesAmount);
             Console.WriteLine(rupeesAmount + " Rs is equivalent to $" + dollarsEquivalent);*/


            /* A customer has a certain balance in his account. 
             * This balance is deducted by a specified amount if he withdraws the money or uses his debit card for payment or uses netbanking.
             * Write a program that handles this scenario.*/
            // Create a customer account with initial balance


            /* CustomerAccount account = new CustomerAccount(1000);

             account.Withdraw(500);
             account.MakeDebitCardPayment(200);
             account.UseNetBanking(300);*/

            /* Q.3You need to create a super car. 
             * It has horsepower and fastest speed. You need to make sure nobody can take your basis of the super car to create a base for a supercar of their own.
             * Write a Java program to ensure the same.*/
            // Create an instance of the supercar

            /*SuperCar mySuperCar = new SuperCar(1000, 250);
            // Display details of the supercar
            mySuperCar.DisplayDetails();*/


            /* Q.4 You need to create a secret bank account for the President of the nation.
             * The bank allows his/her account to be accessed by other family members.
             * The bank account should have a method which allows you to add a specified amount of money to the account.
             * Make sure that you make the method in such a manner that 
             * the method can be accessed by only the President while keeping rest of the account visible to the family members*/

            // Create a secret bank account for the President
            /* SecreteBankAccount presidentAccount = new SecreteBankAccount("President", 10000);

             // Family members accessing the account
             presidentAccount.DisplayBalance(); // Display balance
             presidentAccount.RequestAddMoney(5000, "President"); // President adds money
             presidentAccount.RequestAddMoney(2000, "Spouse"); // Spouse attempts to add money
             presidentAccount.DisplayBalance(); // Display updated balance*/



            //Q.5 
            // Create special edition phones for Apple
            SpecialEditionPhone phone1 = new SpecialEditionPhone("iPhone 13 Pro");
            SpecialEditionPhone phone2 = new SpecialEditionPhone("iPhone 13");

            // Display details of the phones
            phone1.DisplayDetails();
            phone2.DisplayDetails();

            // Attempt to change the color (this will result in a compilation error)
             //phone1.Color = "Gold";
            // phone2.Color = "Silver";
        }


    }


}




