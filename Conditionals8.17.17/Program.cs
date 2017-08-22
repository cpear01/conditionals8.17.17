using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals8._17._17
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter your age");

            //    int age = int.Parse(Console.ReadLine());

            //    if (age == 21)
            //    {
            //        Console.WriteLine("You can see this movie");
            //    }

            //    if (age == 18)
            //        Console.WriteLine("You are now an Adult");

            //}else if(age >= 17)
            //    {

            //    }
            //    {
            //        Console.WriteLine("Sorry you are too young, you need a parent present");

            //Example #2
            //Console.WriteLine("Enter your percentage");
            //int grade = int.Parse(Console.ReadLine());
            //if (grade >= 90 && grade <= 100) //making sure grade is between 90-100%
            //{
            //    Console.WriteLine("You got an A!!");

            //}
            //else if (grade >= 80 && grade <= 89)
            //{
            //    Console.WriteLine("You got a B!! Not Bad");

            //Example #3 (last week)
            ////At a restaurant, Mike and his three friends decided to divide the bill evenly.
            //If each person paid $13 then what was the total bill?
            ////52
            //int numberPeople = 4;
            //int perPerson = 13;
            //Console.WriteLine(numberPeople * perPerson);

            //MY plan first- ask the user how many people dined with them, ask the user the amount of the total bill
            //calculate the 10% & 5% discounts 
            //should have asked the total bill, not figured out per person

            //Console.WriteLine("Welcome to our resturant");
            //Console.WriteLine("How many people in your party?");
            //int numberPeople = int.Parse(Console.ReadLine());
            //Console.WriteLine("How much was the cost per diner?");
            //double billPerEachPerson = int.Parse(Console.ReadLine());
            //double totalBill = (billPerEachPerson * numberPeople);

            //if (totalBill >= 50)
            //{
            //    Console.WriteLine("Good News! It's customer appreciation and you are entitled to 10% off!");
            //    Console.WriteLine("Your new total is:" + " " + totalBill * .9);
            //}
            //    else if (totalBill <= 50)
            //{ 
            //    Console.WriteLine("Good News! It's customer appreciation and you are entitled to 5% off!");
            //    Console.WriteLine("Your new total is:" + " " + totalBill * .95);


            //JORDAN'S PLAN: ask the user for the total bill
            //ask the user for the number of people at dinner
            //            Console.WriteLine("Please enter your total bill");
            //            double totalBill = double.Parse(Console.ReadLine());

            //            Console.WriteLine("How many people were at dinner");
            //            int numberOfPeople = int.Parse(Console.ReadLine());


            //            if the total bill is over $50, then 10 % discount
            //    double discount = 0.0; //discount will only be 1.10 OR 1.05
            //            if (totalBill > 50.0d)

            //            {
            //                discount = 1.10;
            //                totalBill = totalBill / discount; //can also say: totalBill /= discount; (divided equal)
            //            }
            //            else
            //            {
            //                discount = 1.05;
            //                totalBill = totalBill / discount;
            //            }
            //else the total bill gets a 5 % discount

            //inform the user of the new total and how much each person pays
            //double perPerson = totalBill / numberOfPeople;
            //            Console.WriteLine("Thank you for dining with us! Your new total is " + totalBill +
            //                "Each person will pay" + perPerson);

            //Perfect the statement: add gratuity? user answers survey and they could get a coupon? change the color? family gets another discount
            //REDO THIS PROBLEM!!

            //EXAMPLE #4 - do not use a switch/case in this
            //MY PLAN - ask user their age then use if/statement 

            //You're responsible for providing a demographic report for your local school district based on age. 
            //To do this, you're going to determine which 'category' each person fits into based on their age. 
            //The person's age will determine which category they should be in:

            //If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            //If they're 3 or 4 and should be in preschool print : 'Preschool Maniac' 
            //If they're from 5 to 11 and should be in elementary school print : 'Elementary School' 
            //From 12 to 14: 'Middle School'
            //From 15 to 18: 'High School'
            //From 19 to 22: 'College'
            //From 23 to 65: 'Working for the Man'
            //From 66 to 100: 'The Golden Years'
            //If the age of the person is less than 0 or more than 100 - it might be an alien -print: "This program is for humans".

            //EXAMPLE #4 - do not use a switch/case in this
            //MY PLAN - ask user their age then use if/statement 

            //You're responsible for providing a demographic report for your local school district based on age. 
            //To do this, you're going to determine which 'category' each person fits into based on their age. 
            //The person's age will determine which category they should be in:

            //If they're from 0 to 2 the child should be with parents print : 'Still in Mama's Arms'
            //If they're 3 or 4 and should be in preschool print : 'Preschool Maniac' 
            //If they're from 5 to 11 and should be in elementary school print : 'Elementary School' 
            //From 12 to 14: 'Middle School'
            //From 15 to 18: 'High School'
            //From 19 to 22: 'College'
            //From 23 to 65: 'Working for the Man'
            //From 66 to 100: 'The Golden Years'
            //If the age of the person is less than 0 or more than 100 - it might be an alien -print: "This program is for humans".


            //Console.WriteLine("How old are you?");
            //int personsAge = int.Parse(Console.ReadLine());

            ////if statements

            //if (personsAge <= 2 && personsAge >= 0)
            //{
            //    Console.WriteLine("Still in Mama's Arms");
            //}

            //else if (personsAge >= 3 && personsAge <= 4)

            //{
            //    Console.WriteLine("Preschool Maniac");
            //}

            //else if (personsAge >= 5 && personsAge <= 11)

            //{
            //    Console.WriteLine("Elementary School");
            //}

            //else if (personsAge >= 12 && personsAge <= 14)

            //{
            //    Console.WriteLine("Middle School");
            //}

            //else if (personsAge >= 15 && personsAge <= 18)

            //{
            //    Console.WriteLine("High School");
            //}

            //else if (personsAge >= 19 && personsAge <= 22)

            //{
            //    Console.WriteLine("College");
            //}

            //else if (personsAge >= 23 && personsAge <= 65)

            //{
            //    Console.WriteLine("Working for the Man");
            //}

            //else if (personsAge >= 66 && personsAge <= 100)

            //{
            //    Console.WriteLine("The Golden Years");
            //}

            //else //only need an else because this is only if you are less and 0 and older than 100 (its not one of the else if statements)

            //{
            //    Console.WriteLine("This program is for humans");
            //}

            //EXAMPLE #5
            //write a console application that asks the user for a number. Tell the user if that number is even or odd
            //Input: 15
            //Output: 15 is an odd number
            //hint: look up modulous operator % (give as a remainder)

            Console.WriteLine("Please give me a number");
            int numChoice = int.Parse(Console.ReadLine());

            if (numChoice % 2 > 0)
            {
                Console.WriteLine("Your number is odd");
            }

            else
            {
                Console.WriteLine("Your number is even");
            }

            //Jordans:
            Console.WriteLine("please enter a number");
            int number = int.Parse(Console.ReadLine());

            if (number % 2 == 0) //if number mod 2 doesnt equal a reminder

            {
                Console.WriteLine(number + " is even");
            }
            else
            {
                Console.WriteLine(number + " is odd");
            }
                          
        }
    }
 }
    
