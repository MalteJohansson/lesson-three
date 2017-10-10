using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture3
{
    class Program
    {
        static void Main(string[] args)
        {
            //void Multiply()
            //{
            //    Console.WriteLine("Write a number");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Write another number");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"{num1} x {num2} = {num1 * num2}");
            //}

            //Multiply();
            //__________________________________________________________

            //void Divide()
            //{
            //    Console.WriteLine("Write a number.");
            //    int num1 = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Write another number");
            //    int num2 = int.Parse(Console.ReadLine());

            //    Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
            //}

            //Divide();

            //James solution

            //int Divide (int num1, int num2)
            //{
            //    return num1 / num2;
            //}

            //Console.WriteLine(Divide(6, 3));

            //_________________________________________________________

            //string Greeting()
            //{
            //    return "Hello world.";
            //}

            //Console.WriteLine(Greeting());

            //___________________________________________________________


            //string FirstName()
            //{
            //    string firstName = Console.ReadLine();

            //    return "Hello " + firstName;
            //}
            //Console.WriteLine("Greetings, what is your first name?");
            //Console.WriteLine(FirstName());

            //James Solution

            //string Greeting()
            //{
            //    Console.WriteLine("Write your first name");
            //    string fName = Console.ReadLine();
            //    Console.WriteLine($"Hello {fName}");
            //    return $"Hello + {fName}";
            //}
            //Greeting();

            //________________________________________________________

            //string NameSayer(string fName, string lName)
            //{
            //    return $"Your full name is {fName} {lName}";
            //}

            //Console.WriteLine("Write your first name.");
            //string firstName = Console.ReadLine();
            //Console.WriteLine("Write your last name.");
            //string lastName = Console.ReadLine();

            //Console.WriteLine(NameSayer(firstName, lastName));
            //_______________________________________________________

            //bool TrueOrFalse()
            //{
            //    bool isTrue;

            //    Console.WriteLine("Should I be true or false? (yes/no)");
            //    string answer = Console.ReadLine();

            //    if (answer.ToLower() == "yes")
            //    {
            //        isTrue = true;
            //    }

            //    else
            //    {
            //        isTrue = false;
            //    }
            //    Console.WriteLine($"This will return as: {isTrue}");
            //    return isTrue;
            //}

            //TrueOrFalse();

            //________________________________________________________

            #region In Class Assignment / Homework

            //int TotalSumMethod()
            //{
            //    Console.WriteLine("Please write a series of numbers");
            //    int userNumbers = Convert.ToInt32(Console.ReadLine());

            //    int sum;

            //    foreach (char num in userNumbers)
            //    {
            //        int result;
            //        if (int.TryParse(num.ToString()), out result)
            //        {
            //            sum += num;
            //        }
            //    }
            //}
            //TotalSumMethod();

            //James Solution

            //void Calculate()
            //{
            //    Console.WriteLine("Please write a series if numbers (No space!)");
            //    string numString = Console.ReadLine();

            //    int sum = 0;

            //    foreach (char num in numString)
            //    {
            //        int result;

            //        if (int.TryParse(num.ToString(), out result))
            //        {
            //            sum += result;
            //        }
            //    }

            //    Console.WriteLine(sum);
            //}

            //Calculate();

            //all should be void, 2 cases 

            //int[] userNumbers = new int[10];
            //int numbersInarray;
            //int sum = 0;

            //Console.WriteLine("Please write the amount of numbers to be stored in the array, no more than 10!");
            //numbersInarray = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine($"Input {numbersInarray} value in the array");

            //for (int i = 0; i < numbersInarray; i++)
            //{
            //    Console.WriteLine($"Value to element {i}");
            //    userNumbers[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbersInarray; i++)
            //{
            //    sum += userNumbers[i];
            //}

            //Console.WriteLine($"The total value of your numbers are {sum}");




            //int[] intArray = new int[10];
            //int numberOfArrayElement;
            //int sum = 0;

            //Console.WriteLine("Please write the numbers to be stored in the array, no more than 10!");
            //numberOfArrayElement = Convert.ToInt32(Console.ReadLine());

            //if (numberOfArrayElement <= 10)
            //{

            //    for(int i = 0; i < numberOfArrayElement; i++)
            //{
            //        Console.WriteLine($"Enter the number for element {i}");
            //        intArray[i] = Convert.ToInt32(Console.ReadLine());

            //    }

            //    for (int i = 0; i < numberOfArrayElement; i++)
            //    {
            //        sum += intArray[i];
            //    }

            //    Console.WriteLine($"The total sum of all your numbers are {sum}.");

            //}

            //else
            //{
            //    Console.WriteLine("Invalid input.");
            //}
            #endregion


            //int[] numArray = new int[5];
            //int numberOfArray;
            //int sum = 0;

            //Console.WriteLine("Please write how many numbers you'd like to include in the array, no more than 5!");
            //numberOfArray = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < numberOfArray; i++)
            //{
            //    Console.WriteLine($"Please enter the value for number {i + 1}");
            //    numArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numberOfArray; i++)
            //{
            //    sum += numArray[i];
            //}

            //Console.WriteLine($"The total sum of all your numbers are {sum}");

            //int[] numArray = new int[10];
            //int numbersInArray;
            //int numberLeft = 0;
            //int sum = 0;

            //Console.WriteLine("Please write how many numbers you want to add together, no more than 10!");
            //numbersInArray = Convert.ToInt32(Console.ReadLine());
            //numberLeft = numbersInArray - 1;

            //for (int i = 0; i < numbersInArray; i++, --numberLeft)
            //{
            //    Console.WriteLine($"Please enter the value for number {i + 1}, you have {numberLeft} left to declare");
            //    numArray[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //for (int i = 0; i < numbersInArray; i++)
            //{
            //    sum += numArray[i];
            //}

            //Console.WriteLine($"The total sum of all your {numbersInArray} numbers are equal to {sum}");


            int lengthOfArray;

            Console.WriteLine("Please write the names of your family members, how many members are there in your family?");
            lengthOfArray = Convert.ToInt32(Console.ReadLine());
            string[] famMembers = new string[lengthOfArray];

            for (int i = 0; i < lengthOfArray; i++)
            {
                Console.WriteLine($"Please write the name of family member number {i + 1}");
                famMembers[i] = Console.ReadLine();
            }

            Console.WriteLine("The names of your family members are: {0}", string.Join(", ", famMembers));
        }
    }
}
