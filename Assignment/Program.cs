namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            ////Q1
            //Console.WriteLine("Enter Number: ");  
            //int.TryParse(Console.ReadLine(), out int num);
            //Console.WriteLine(num);
            #endregion

            #region Q2
            ////Q2

            //Console.WriteLine("Enter String: ");
            //int value = Convert.ToInt32(Console.ReadLine());
            ////int value = int.Parse(Console.ReadLine());
            //////int.TryParse(Console.ReadLine(), out int value);
            //Console.WriteLine(value);

            //What Will Happen?
            //1. Using Convert & Parse : It will throw exeption.
            //2. Using Try Parse : Will Print 0
            #endregion

            #region Q3
            ////Q3

            //float num1 = 0.5f;
            //float num2 = 0.25f;
            //double num3 = 0.75;
            //decimal num4 = 1.5m;

            //double result;

            //result = num1 + num2;
            //Console.WriteLine(result);

            //result = num1 + num3;
            //Console.WriteLine(result);

            //result = num1 - num2;
            //Console.WriteLine(result);

            //result = num1 * num2;
            //Console.WriteLine(result);

            //result = num1 / num2;
            //Console.WriteLine(result);

            //What Will Happen?
            //1. (Operations on Float & Float || Double & Double || Float & Double ) Will Run Successfully.
            //2. (Operations on Decimal Number) Will Thorw an Error.
            #endregion

            #region Q4
            ////Q4

            //string fullString = "Hello World";
            //string subString = fullString.Substring(0, 5);
            //Console.WriteLine(subString);
            #endregion

            #region Q5
            ////Q5

            //int X = 5;
            //int Y = X;
            //X = 10;

            //Console.WriteLine(X);
            //Console.WriteLine(Y);

            //What Will Happen?
            //Modifying one variable does not affect the other once assignment is done. 

            #endregion

        }
    }
}
