namespace Assigment4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1:1- Write a program that allows the user to insert an integer then print all numbers between 1 to that number.

            //Console.WriteLine("Enter Integer Number");
            //int Num = int.Parse(Console.ReadLine());

            //for (int i=1;i<=Num;i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #region Q2:  Write a program that allows the user to insert an integer then  print a multiplication table up to 12.

            //Console.WriteLine("Enter integer Number");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 1; i <= 12; i++)
            //{
            //    Console.WriteLine(num * i);

            //}


            #endregion


            #region Q3: Write a program that allows to user to insert number then print all even numbers between 1 to this number

            //Console.WriteLine("Enter integer Number");

            //int num = int.Parse(Console.ReadLine());

            //for (int i = 0; i <= num; i += 2)
            //{
            //    Console.WriteLine(i);

            //}


            #endregion


            #region Q4: Write a program that takes two integers then prints the power.


            //Console.WriteLine("Enter the base :");
            //int Base = int.Parse(Console.ReadLine());

            //Console.WriteLine("Enter the exponent :");
            //int exponent = int.Parse(Console.ReadLine());

            //int res = 1;
            //for (int i = 0; i < exponent; i++)
            //{
            //    res *= Base;
            //}
            //Console.WriteLine($"Result is {res}");


            #endregion


            #region Q5:Write a program to allow the user to enter a string and print the REVERSE of it.

            //Console.WriteLine("Enter String");
            //string Message = Console.ReadLine();


            //char[] charArray = Message.ToCharArray();
            //Array.Reverse(charArray); 
            //string reversedString = new string(charArray);


            //Console.WriteLine($"Reversed string:{reversedString} ");
            #endregion




            #region Q6: Write a program in C# Sharp to find prime numbers within a range of numbers.


            //int start;
            //bool flag01;

            //do
            //{
            //    Console.WriteLine("Enter start Number");
            //    flag01 = int.TryParse(Console.ReadLine(), out start);

            //} while (!flag01);


            //int end;
            //bool flag02;

            //do
            //{
            //    Console.WriteLine("Enter end Number");
            //    flag02 = int.TryParse(Console.ReadLine(), out end);

            //} while (!flag02);

            //for(int i = start; i < end; i++)
            //{
            //    int count = 0;
            //    for (int j=2;j<i;j++)
            //    {
            //        if (i % j == 0)
            //        {
            //            count++;
            //            break;
            //        }

            //    }

            //    if (count == 0 & i !=1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            #endregion


            #region Q7: Write a program in C# Sharp to convert a decimal number into binary without using an array.

            //int Num;
            //bool flag;
            //string Res = " ";

            //do
            //{
            //    Console.WriteLine("Enter  Number");
            //    flag = int.TryParse(Console.ReadLine(), out Num);

            //} while (!flag);

            //for (int i =0;Num > 0;i++)
            //{
            //    Res = (Num % 2) + Res;
            //    Num /= 2;

            //}

            //Console.WriteLine(Res);
            #endregion

            #region Q8:Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //int Num;
            //bool flag;


            //do
            //{
            //    Console.WriteLine("Enter Number");
            //    flag = int.TryParse(Console.ReadLine(), out Num);

            //} while (!flag);


            //for (int i =0; i <Num;i++)
            //{
            //    for (int j =0; j< Num; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write($" {1} ");
            //        }
            //        else
            //        {
            //            Console.Write($" {0} ");
            //        }

            //    }
            //    Console.WriteLine();
            //}


            #endregion


            #region Q9:Write C# program that Extract a substring from a given string.


            //Console.Write("Enter the string: ");
            //string Stringg = Console.ReadLine();

            //Console.Write("Enter the start index: ");
            //int startIndex = int.Parse(Console.ReadLine());

            //Console.Write("Enter the length of the substring: "); 
            //int length = int.Parse(Console.ReadLine()); 


            //string substring = Stringg.Substring(startIndex, length); 

            //Console.WriteLine("Extracted substring: " + substring);

            #endregion


            #region Q10:Write C# program that take two string variables and print them as one variable 

            //Console.Write("Enter the first string: ");
            //string String1 = Console.ReadLine();

            //Console.Write("Enter the second string: "); 
            //string String2 = Console.ReadLine(); 

            // string String3 = String1 + String2;

            //Console.WriteLine(String3);
            #endregion

            #region Q11:Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n.

            //int Num;
            //bool flag;


            //do
            //{
            //    Console.WriteLine("Enter Number");
            //    flag = int.TryParse(Console.ReadLine(), out Num);

            //} while (!flag);


            //for (int i =0; i <Num;i++)
            //{
            //    for (int j =0; j< Num; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write($" {1} ");
            //        }
            //        else
            //        {
            //            Console.Write($" {0} ");
            //        }

            //    }
            //    Console.WriteLine();
            //}



            #endregion

            #region Q12: Write a program in C# Sharp to find the sum of all elements of the array.

            //int size;
            //bool flag;
            //int sum = 0;


            //do
            //{
            //    Console.WriteLine("Enter size");
            //    flag = int.TryParse(Console.ReadLine(), out size);

            //} while (!flag);

            //int[] arr = new int[size];

            //for (int i=0;i < size; i++)
            //{
            //    int num;
            //    bool flag2;


            //    do
            //    {
            //        Console.WriteLine("Enter Numbers");
            //        flag2 = int.TryParse(Console.ReadLine(), out arr[i]);

            //    } while (!flag2);

            //}

            //for (int i =0;i<size;i++)
            //{
            //    sum += arr[i];
            //}

            //Console.WriteLine($"Sum of Array = {sum}");

            #endregion

        }
    }
}