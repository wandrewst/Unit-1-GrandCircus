using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_1_Grand_Circus
{
    class Program
    {
        static void Main(string[] args)
        {
            //Input numbers//
          double number1, number2, number3;
            Console.WriteLine("Enter the First dollar amount: ");
                 number1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Second dollar amount: ");
                number2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the Third dollar amount: ");
                number3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Sum is equal to: " + 
                  (number1 + number2 + number3));
            double sum = (number1 + number2 + number3);

            //SUM and AVERAGE//
            double result = (number1 + number2 + number3) / 3;
                Console.WriteLine("The average of your amounts of {0}, {1}, {2}, \n is: {3} ",
             number1, number2, number3, result);
            
            //Largest and Smallest numbers//

            Console.WriteLine("Largest Amount enter today was: " +
                Math.Max(number1, Math.Max(number2, number3)));
            Console.WriteLine("Smallest Amount enter today was: "
                + Math.Min(number1, Math.Min(number2, number3)));

            //Different Currency//

            double value = sum;

            Console.OutputEncoding = System.Text.Encoding.UTF8;

                 Console.WriteLine("US Dollar Amount:" + value.ToString("C2", System.Globalization.CultureInfo.CurrentCulture));

            CultureInfo sv = new CultureInfo("sv-SE");
                        Console.WriteLine("Swedish Krona: {0}",
                            value.ToString("C2", CultureInfo.CreateSpecificCulture("sv-SE")));

            CultureInfo th = new CultureInfo("th-TH");
                        Console.WriteLine("Thai Baht: {0:C2}",
                            value.ToString("C", th));

            CultureInfo jp = new CultureInfo("ja-JP");
                        Console.WriteLine("Japan Yen: {0}", 
                            value.ToString("C", CultureInfo.CreateSpecificCulture( "ja-JP")));

            

                       





            Console.ReadLine();




        }
    }
}
