using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Arrays (مصفوفات) Variable[] V-Name = new V-Type[V-Anzahl];

            //string[] str = new string[4];
            //str[0] = "Khaled"; str[1] = "Mohamed";str[2] = "Hasnaa";str[3] = "Afraa";
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str[1]);
            //Console.WriteLine(str[2]);
            //Console.WriteLine(str[3]);
            //Console.WriteLine("==========");
            //int[] numm = new int[3];numm[0] = 5;numm[1] = 2;numm[2] = numm[0]*numm[1];
            //Console.WriteLine(numm[2]);



            // Variable object (لكل الصيغ)


            /*
            object[] data = new object[7];
            data[0] = "Khaled";
            data[1] = -2462342;
            data[2] = 34372824;
            data[3] = false;
            data[4] = true;
            data[5] = 'K';
            data[6] = "Mohammad";

            Console.WriteLine(data[0]);
            Console.WriteLine(data[1]);
            Console.WriteLine(data[2]);
            Console.WriteLine(data[3]);
            Console.WriteLine(data[4]);
            Console.WriteLine(data[5]);
            Console.WriteLine(data[6]);
            */

            #endregion

            #region Anzahl der Arrays 

            string[] nam = new string[2];
            nam[0] = "Khaled";nam[1] = "Alkadi";

            Console.WriteLine(nam[0] + " " + nam[1]);

            int arrays = nam.Length;
            Console.WriteLine(arrays);



            #endregion


        }
    }
}
