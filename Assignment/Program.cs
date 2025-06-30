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

            #region Q6
            ////Q6
            //Person person01 = new Person();
            //person01.Name = "Ali";
            //person01.Age = 30;

            //Person person02 = person01;

            //person02.Name = "Ahmed";
            //person02.Age = 35;

            //Console.WriteLine($"Person01 Name: {person01.Name}, Person01 Age: {person01.Age}");
            //Console.WriteLine($"Person02 Name: {person02.Name}, Person02 Age: {person02.Age}");

            //What Will Happen?
            //When we modify person02 Name or Age, the change will reflect in person01, because they both point to the same object.

            #endregion

            #region Q7
            ////Q7

            //Console.WriteLine("Enter Your First Name: ");
            //string firstName = Console.ReadLine();

            //Console.WriteLine("Enter Your Second Name: ");
            //string secondName = Console.ReadLine();

            //string fullName = $"{firstName} {secondName}";
            //Console.WriteLine(fullName);
            #endregion

            #region Q8
            ////Q8

            //Console.WriteLine("===== Interest Calculator =====");
            //Console.WriteLine("Enter the Principal amount: ");
            //double.TryParse(Console.ReadLine(), out double principal);

            //Console.WriteLine("Enter the Rate of interest: ");
            //double.TryParse(Console.ReadLine(), out double rate);

            //Console.WriteLine("Enter the Time: ");
            //double.TryParse(Console.ReadLine(), out double time);

            //double Interest = (principal * rate * time) / 100;

            //Console.WriteLine($"Interest = {Interest}%");

            #endregion

            #region Q9
            ////Q9

            //Console.WriteLine("===== BMI Calculator =====");
            //Console.WriteLine("Enter Your Weight: ");
            //float.TryParse(Console.ReadLine(), out float weight);

            //Console.WriteLine("Enter Your Height: ");
            //float.TryParse(Console.ReadLine(), out float height);

            //float BMI = (weight)/(height * height);
            //Console.WriteLine($"Your Body Mass Index (BMI): {BMI}");
            #endregion

            #region Q10
            ////Q10
            //Console.Write("Enter the temperature: ");
            //float temperature = float.Parse(Console.ReadLine());

            //string result = (temperature < 10) ? "Just Cold" : (temperature > 30) ? "Just Hot" : "Just Good";


            //Console.WriteLine(result);

            #endregion

            #region Q11
            ////Q11

            //Console.WriteLine("Enter Todays Day: ");
            //string day = Console.ReadLine();
            //Console.WriteLine("Enter Current Month: ");
            //string month = Console.ReadLine();
            //Console.WriteLine("Enter Current Year: ");
            //string year = Console.ReadLine();

            //Console.WriteLine($"Today's date: {day} , {month} , {year}");
            //Console.WriteLine($"Today's date: {day} / {month} / {year}");
            //Console.WriteLine($"Today's date: {day} - {month} - {year}");
            #endregion

        }
    }
}
