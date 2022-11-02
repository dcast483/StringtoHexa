using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringtoHexa
{
    internal class Program
    {
        static string decToHexa(int n)
        {
            
            char[] hexaDeciNum = new char[100];
                   
            int i = 0;

            while (n != 0)
            {
                int temp = 0;

                // Storing remainder in temp variable
                temp = n % 16;

                if (temp < 10)
                {
                    hexaDeciNum[i] = (char)(temp + 48);                       
                    i++;
                }
                else
                {
                    hexaDeciNum[i] = (char)(temp + 87);                      
                    i++;
                }

                n = n / 16;
            }

            string ans = "";

            // Printing hexadecimal number array in reverse order
            for (int j = i - 1; j >= 0; j--)                   
            {
                ans += hexaDeciNum[j];
            }

            return ans;
        }

        public static string ASCIItoHEX(string ascii)
        {
            // Initialize final String
            string hex = "";

            for (int i = 0; i < ascii.Length; i++)                    
            {
                // Take a char from position i of string
                char ch = ascii[i];

                int tmp = (int)ch;

                // Change this ascii value integer to hexadecimal value
                string part = decToHexa(tmp);

                hex += part;
            }

            // Return the final string hex
            return hex;
        }

        // Driver code
        public static void Main(string[] arg)
        {

            Console.Write(ASCIItoHEX("Hoes be Hoing"));
            Console.ReadLine();
        }
    }
}
