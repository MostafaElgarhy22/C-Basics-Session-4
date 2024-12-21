using System.Text;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Loop Statement
            //for (int i = 1; i <= 10; i++) 
            //{
            //    Console.WriteLine($"{i} T");
            //}
            #endregion
            #region For - Foreach
            // int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //for (int i = 0; i <= Numbers.Length; i++)              // if then break stop in it .. if then continue skip this number
            //{
            //    Console.WriteLine(Numbers[i]);
            //}

            //foreach(int Number in Numbers)
            //{
            //    Console.WriteLine(Number + 10);
            //}


            #endregion
            #region While - Do While
            //int Number;
            //bool Flag;
            //do
            //{
            //    Console.WriteLine("Enter Even Number : ");
            //    //Number = int.Parse(Console.ReadLine());
            //   Flag = int.TryParse(Console.ReadLine(), out Number);      // طبق فاضي (out Number)
            //} while (Number % 2 == 1 || !Flag);

            //Console.WriteLine($"{Number} is Even");

            //int Number = 3;
            //bool Flag = false;
            //while (Number % 2 == 1 || !Flag)
            //{
            //    Console.WriteLine("Enter Even Number : ");
            //    Flag = int.TryParse(Console.ReadLine(), out Number);
            //}

            //Console.WriteLine($"{Number} is Even");
            #endregion
            #region String

            //String Name01 = "Ahmed";
            //String Name02 = "Ahmed";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            //String Name01 = "Ahmed";
            //String Name02 = "Ali";

            //Console.WriteLine(Name01);
            //Console.WriteLine($"Name01 HC : {Name01.GetHashCode()}");
            //Console.WriteLine(Name02);
            //Console.WriteLine($"Name02 HC : {Name02.GetHashCode()}");

            //Name02 = Name01;

            //string Message = "Hello";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            //Message += " Route";

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder
            //StringBuilder Message;

            //Message = new StringBuilder("Hello");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());

            ////Message += " Route";

            //Message.Append(" Route");

            //Console.WriteLine(Message);
            //Console.WriteLine(Message.GetHashCode());
            #endregion
            #region StringBuilder Methods
            //StringBuilder Message = new StringBuilder("Welcome");

            //Message.Append(" To Route");
            //Message.AppendLine(" Mostafa");
            //Message.Append(" Hany");

            //Message.Remove(0, 7);

            //Message.Insert(0, "Hello");
            //Console.WriteLine(Message);

            //Message.AppendFormat();
            // Message.AppendJoin(", ");
            #endregion
            #region Array 1 D
            //int[] Numbers = new int[3] { 1, 2, 3 };
            //int[] Numbers = new int[] { 1, 2, 3 };
            //int[] Numbers = { 1, 2, 3 };

            //int[] Numbers = new int[3];

            //Numbers[0] = 1;
            //Numbers[1] = 2;
            //Numbers[2] = 3;


            #endregion

        }
    }
}
