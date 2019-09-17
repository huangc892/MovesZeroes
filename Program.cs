using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            String cont = "yes";
            int[] s;
            do
            {
                Console.Write("Please input a range of numbers: ");
                String values = Console.ReadLine();
                String[] valueInArr = values.Split(',');
                s = convertToIntArr(valueInArr);
                Console.WriteLine("Input: [{0}]", string.Join(", ", s));
                s = output(s);
                Console.WriteLine("Output: [{0}]", string.Join(", ", s));
                Console.Write("Again? ");
                cont = Console.ReadLine();
            }
            while (cont.ToLower().Equals("yes"));
        }

        public static int[] convertToIntArr(String[] v)
        {
            int[] newV = new int[v.Length];
            for (int i = 0; i < v.Length; i++)
            {
                newV[i] = Convert.ToInt32(v[i]);
            }
            return newV;
        }

        public static int[] output(int[] input)
        {
            int count = 0;
            for (int i = 0; i < input.Length; i++){
                if (input[i] != 0)
                {
                    input[count] = input[i];
                    count++;
                }
            }
            while (count < input.Length){
                input[count] = 0;
                count++;
            }
            return input;
        }
    }
}
