using System.Globalization;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Fractions & Discards
            ////Fractions===========================================
            //float X = 3.55859468874548f;
            //double Y = 3.5;
            //decimal Z = 3.5m;
            //Console.WriteLine(X);

            //var W = 3.5f;


            ////Discards============================================
            //long L = 351_572_964_875;
            //Console.WriteLine($"{L:c}");

            //var cultureInfo = new CultureInfo("ar-SA");
            //Console.WriteLine(L.ToString("C", cultureInfo));
            #endregion

            #region Implicit & Explicit Casting
            ////Implicit Casting===================================
            //int X = 1000; ////4 Bytes
            //long Y = X;   ////8 Bytes 
            //Console.WriteLine(Y);

            ////Explicit Casting=Unsafe Casting====================
            //long Z = 1000;
            //int W = (int)Z;
            //Console.WriteLine(W);

            ////Overflow - Data Loss===============================
            //checked
            //{
            //    long A = 2345651231564;
            //    int B = (int)A;
            //    Console.WriteLine(B);
            //}

            ////Handling Overflow
            //long X = 85468348974354896;

            //if (X > int.MaxValue || X < int.MinValue)
            //    Console.WriteLine("Exception");
            //else 
            //{ 
            //    int Y = (int)X;
            //    Console.WriteLine(Y);
            //}

            #endregion

            #region Convert
            //Console.WriteLine("Please Enter Your Name: ");
            //string? name = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age: ");
            //int age = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal salary = Convert.ToDecimal(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("========== Employee Data ==========");
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Salary: " + salary);
            #endregion

            #region Parse
            //Console.WriteLine("Please Enter Your Name: ");
            //string? name = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age: ");
            //int age = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal salary = decimal.Parse(Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("========== Employee Data ==========");
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Salary: " + salary);
            #endregion

            #region TryParse
            //string number1 = "100";
            //int X1 = int.Parse(number1);
            //Console.WriteLine(number1);

            //string number2 = "Ahmed";
            //bool isParsed = int.TryParse(number2, out int X2);
            //Console.WriteLine(X2);

            //Console.WriteLine("Please Enter Your Name: ");
            //string? name = Console.ReadLine();

            //Console.WriteLine("Please Enter Your Age: ");
            //int.TryParse(Console.ReadLine(), out int age);

            //Console.WriteLine("Please Enter Your Salary: ");
            //decimal.TryParse(Console.ReadLine(), out decimal salary); 

            //Console.Clear();
            //Console.WriteLine("========== Employee Data ==========");
            //Console.WriteLine("Name: " + name);
            //Console.WriteLine("Age: " + age);
            //Console.WriteLine("Salary: " + salary);
            #endregion

            #region Operators
            // Unary Operators
            //1. ++
            //2. --
            //Prefix(++X, --X) [Increment then Print]
            //Postfix(X++, X--)[Print then increment]

            //Binary | Arthemitic Operators
            //[+ , - , * , / , %]

            //Assignment Operators
            //[= , += , -= , *= , /= , %=]

            //Relational Operators
            //[== , != , < , > , <= , >=]

            //Logical Opertators
            //[! , && , ||]

            //Bitwise Opertors
            //[& , | , ^ , ~ , << , >>]

            //Ternary Operators
            //[Conditional Operators (condition? true : false)]
            #endregion

            #region String Formatting
            //// Equation : 10 + 5 = 15
            //int X = 10, Y = 5, result;
            //result = X + Y;
            //string message;

            ////1. String Concatenations
            //message = "Equation : " + X + " + " + Y + " = " + result;
            //Console.WriteLine(message);

            ////2. Composite Formatting
            //Console.WriteLine("Equation : {0} + {1} = {2}", X, Y, result);

            ////3. String.Format
            //message = string.Format("Equation : {0} + {1} = {2}", X, Y, result);
            //Console.WriteLine(message);

            ////4. String Interpolation
            //message = $"Equation : {X} + {Y} = {result}";
            //Console.WriteLine(message); 

            ////5. Path
            //string path = @"C:\Users\gamal\source\repos\C44-G03-CS03\Demo\Program.cs";
            //Console.WriteLine(path);
            #endregion
        }
    }
}
