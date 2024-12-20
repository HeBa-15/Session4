using System.Runtime.InteropServices;
using System.Text;

namespace Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {


            #region Loop Statments


            //Console.WriteLine(1);
            //Console.WriteLine(2);
            //Console.WriteLine(3);
            //Console.WriteLine(4);
            //Console.WriteLine(5);
            //Console.WriteLine(6);
            //Console.WriteLine(7);
            //Console.WriteLine(8);
            //Console.WriteLine(9);
            //Console.WriteLine(10);

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"{i} T");
            //}

            #endregion


            #region For _Foreach

            //int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //for (int i =0;i<Numbers.Length;i++)
            //{
            //     Numbers[i] += 10;
            //if (Numbers[i] == 5)
            //{
            //    break;
            //}

            //if (Numbers[i] == 5)
            //{
            //    continue;
            //}
            //    Console.WriteLine(i);
            //    Console.WriteLine(Numbers[i] + 10);
            //}


            // Class impliment interface IEnumrable
            //foreach (int Number in Numbers)
            //{
            //    Number += 10;   //invalid
            //    Console.WriteLine(Number + 10);

            //}

            #endregion



            #region While - Do While

            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number :");
            //    // Number = int.Parse(Console.ReadLine());
            //  Flag=  int.TryParse(Console.ReadLine(),out Number );
            //} while (Number % 2 == 1 || !Flag );

            //Console.WriteLine($"{Number} is Even");


            //int Number = 3;
            //bool Flag = false;
            //while(Number % 2 == 1 || !Flag)
            //{
            //   Console.WriteLine("Enter Even Number :");

            //      Flag=  int.TryParse(Console.ReadLine(),out Number );

            //}

            //Console.WriteLine($"{Number} is  Even");

            #endregion


            #region String

            // Class => Reference Type
            //immutable Data Type {Value can not be Changed}
            // Array Of Chars
            //A H M E D

            //  string Name;

            // Name = new string("Ahmed");

            //Name = "Ahmed";

            //string Name01= "Ahmed";

            //string Name02 = "Ahmed";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 Hc : {Name01.GetHashCode()}");

            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 Hc : {Name02.GetHashCode()}");



            //string Name01= "Ahmed";

            //string Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 Hc : {Name01.GetHashCode()}");

            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 Hc : {Name02.GetHashCode()}");

            // Name02 = Name01;

            // Console.WriteLine("***********Name02 = Name01***********");
            // Console.WriteLine(Name01);
            // Console.WriteLine($"Name01 Hc : {Name01.GetHashCode()}");

            // Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 Hc : {Name02.GetHashCode()}");


            // Name01 = "Mostafa";

            // Console.WriteLine("*********** Name01 = Mostafa***********");
            // Console.WriteLine(Name01);
            // Console.WriteLine($"Name01 Hc : {Name01.GetHashCode()}");

            // Console.WriteLine(Name02);
            // Console.WriteLine($"Name02 Hc : {Name02.GetHashCode()}");



            //string Message = "Hello";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message += "Route";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            #endregion


            #region StringBuilder

            //StringBuilder Message;
            // Message = new StringBuilder("Hello");

            //// Message = "Hello"; //invalid

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            ////Message += "Route"; //invalid

            //Message.Append("Route");


            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());







            #endregion



            #region StringBuilder Methods

            //StringBuilder Message = new StringBuilder("Welcome");

            //Message.Append(" To Route ");
            //Message.AppendLine(" Mostafa ");
            //Message.Append(" Hany ");
            //Console.WriteLine(Message);


            //Message.Remove(0,7);


            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);


            //int Age = 10;
            //string Name = "Ali";
            //Message.AppendFormat("Name: {0}, Age : {1}", Name, Age);

            //Console.WriteLine(Message);


            //Message.AppendJoin("/","Mostafa","Hany","Mohamed",2);
            //Console.WriteLine(Message);


            #endregion


            #region Array 1 D
            // int[] Numbers = new int[3] { 1,2,3};
            //  int[] Numbers = new int[] { 1,2,3};
            // int[] Numbers = { 1,2,3};

            //int[] Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;

            //for (int i = 0; i < Numbers.Length; i++)
            //{
            //    Console.WriteLine($"Enter Number {i+1}");
            //    Numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i =0;i<Numbers.Length;i++)
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //Console.WriteLine(Numbers.Length);
            //Console.WriteLine(Numbers.Rank);

            #endregion

            #region Array 2 D

            //int[,] Marks = new int[3, 5]; //{ { 1, 2, 3, 4, 5 }, { 10, 20, 30, 40, 50 }, { 100, 200, 300, 400, 500 } };

            ////Console.WriteLine(Marks.Length);
            ////Console.WriteLine(Marks.Rank);
            ////Console.WriteLine(Marks.GetLength(0));
            ////Console.WriteLine(Marks.GetLength(1));


            //for (int i =0;i<Marks.GetLength(0);i++)
            //{
            //    Console.WriteLine($"Enter Grades Student({i+1}) ");

            //    for (int j = 0; j < Marks.GetLength(1);/* j++*/)
            //    {
            //        bool flag;
            //        Console.WriteLine($"Enter Grades Subject ({j + 1}) ");
            //     // Marks[i,j] = int.Parse(Console.ReadLine());

            //      flag=  int.TryParse(Console.ReadLine(),out Marks[i,j] );

            //        //if (flag && Marks[i,j]>=0)
            //        //{
            //        //    j++;
            //        //}

            //        j = flag && Marks[i, j] >= 0 ? ++j : j;

            //    }

            //}


            //for (int i = 0; i < Marks.GetLength(0); i++)
            //{
            //    Console.WriteLine($" Grades Student({i + 1}) ");
            //    for (int j = 0; j < Marks.GetLength(1); j++)
            //    {
            //        Console.WriteLine($" Grades Subject ({j + 1}) ");

            //        Console.WriteLine(Marks[i, j]);


            //    }

            //}

            //Console.Clear();

            //for (int i = 0; i < Marks.Length; i++)
            //{
            //    Console.WriteLine(Marks[i/Marks.GetLength(1),i% Marks.GetLength(1)]);
            //}


            #endregion


            #region Judged Array

            //int[][] Numbers = new int[3][];

            //Numbers[0] = new int[3] {1,2,3 };
            //Numbers[1] = new int[2] {4,5 };
            //Numbers[2] = new int[1] {6 };

            //for (int i=0;i<Numbers.Length;i++)
            //{
            //    for (int j = 0; j < Numbers[i].Length; j++)
            //    {
            //        Console.WriteLine(Numbers[i][j]);
            //    }
            //}

            #endregion





        }
    }
}