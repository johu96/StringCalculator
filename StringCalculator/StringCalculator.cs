using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculator
{
    public class StringCalculator
    {
        /// <summary>
        /// Calculate Sum
        /// </summary>
        /// <param name="expression">Digits to calculate</param>
        /// <returns></returns>
        public int Add( string expression)
        {
            if(string.IsNullOrEmpty(expression))
                return 0;

            int sum = 0;
            if(expression.Contains(","))
            {
                string[] digits = expression.Split(',');
                //sum = int.Parse(digits[0]) + int.Parse(digits[1]);
                foreach (string digit in digits)
                    sum += int.Parse(digit);
                
            }
            else
                sum = int.Parse(expression);

            return sum;

               
           
        }

    }
}
