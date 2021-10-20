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
            //str[0] = "Khaled"; str[1] = "Mohamed"; str[2] = "Hasnaa"; str[3] = "Afraa";
            //Console.WriteLine(str[0]);
            //Console.WriteLine(str[1]);
            //Console.WriteLine(str[2]);
            //Console.WriteLine(str[3]);
            //Console.WriteLine("==========");
            //int[] numm = new int[3]; numm[0] = 5; numm[1] = 2; numm[2] = numm[0] * numm[1];
            //Console.WriteLine(numm[0]);



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

            //string[] nam = new string[2];
            //nam[0] = "Khaled"; nam[1] = "Alkadi";

            //int arrays = nam.Length;
            //Console.WriteLine(arrays);



            #endregion

            #region إضافة عناصر المصفوفة بشكل أسهل 

            //int[] anzahl = { 10, 20, 30, 80, 90, 60, 45 };
            //Console.WriteLine(anzahl.Length);
            //Console.WriteLine(anzahl[2]);

            #endregion

            #region
            string[] strnames = new string[4];
            strnames[0] = "Khaked";
            strnames[1] = "Hasnaa";
            strnames[2] = "Afraa";
            strnames[3] = "Mohamad";


            for(int x = 0; x < strnames.Length;x++)
            {
                Console.WriteLine(strnames[x]);
            }

            #endregion
        }


    }
}
