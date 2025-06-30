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
        }
    }
}
