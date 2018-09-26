using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromic_Product
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 999;
            int num2 = 999;
            string tempVar = "";
            string tempVar2 = "";
            List<int> productsList = new List<int>();

            for (int i = 1; i < 100000; i++)
            {
                tempVar2 = "";

                var product = num1 * num2;

                tempVar = Convert.ToString(product);

                char[] varChar = tempVar.ToCharArray();

                for (int j = varChar.Length - 1; j >= 0; j--)
                {
                    tempVar2 += tempVar[j];
                }
                if (Convert.ToString(product) == tempVar2)
                {
                    Console.WriteLine(num1 + " X " + num2 + " = " + product);
                    productsList.Add(product);
                }

                num2--;

                if (num2 == 0)
                {
                    num2 = 999;
                    num1--;
                }
                if (num1 == 0)
                {
                    break;
                }
            }
            productsList.Sort();
            {
                Console.WriteLine(productsList[productsList.Count - 1]);
            }

        }
    }
}
