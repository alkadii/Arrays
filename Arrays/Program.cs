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
            // ملاحظة هامة 
            // Variable var und object für alle Variable-Typen


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

            #region Anzahl der Arrays Length

            //string[] nam = new string[2];
            //nam[0] = "Khaled"; nam[1] = "Alkadi";

            //int arrays = nam.Length;
            //Console.WriteLine(arrays);


            //string[] str = new string[] { "Khaled", "Hasnaa", "Afraa", "Riad", "Ahmad" };

            //Console.WriteLine(str.Length);





            #endregion

            #region إضافة عناصر المصفوفة بشكل أسهل 
            // 1- Erste Methode 

            //int[] anzahl = { 10, 20, 30, 80, 90, 60, 45 };
            //Console.WriteLine(anzahl.Length);
            //Console.WriteLine(anzahl[2]);

            //2- Zweite Methode 

            //int[] arrays = new int[] { 57, 76, 5, 3, 2, 1, 8, 9, 05 };
            //Console.WriteLine(arrays[8]);




            #endregion

            #region Arrays mit for
            //string[] strnames = new string[4];
            //strnames[0] = "Khaked";
            //strnames[1] = "Hasnaa";
            //strnames[2] = "Afraa";
            //strnames[3] = "Mohamad";


            //for (int x = 0; x < strnames.Length; x++)
            //{
            //    Console.WriteLine(strnames[x]);
            //}

            //int[] anzahl = new int[] { 90, 87, 67, 54, 32 ,45,32};

            //for (int f = 0; f < anzahl.Length; f++) 
            //{
            //    Console.WriteLine(anzahl[f]);
            //}



            #endregion

            #region Console.WriteLine(Array.indexof(Name von Variable,nuhmmer von Variable); رقم الفهرس

            //int[] anzahl = new int[] { 95, 4, 3, 2, 5, 643, 2, 14, 65 };

            //Console.WriteLine(Array.IndexOf(anzahl, 643));



            #endregion

            #region Array.sort(Name von Variable); ترتيب الاعداد في (الاريي) تصاعديا

            //int[] an = new int[] {200, 65, 45, 345, 745, 34, 65 };

            //Array.Sort(an);
            //for (int h = 0; h < an.Length; h++)
            //{
            //    Console.WriteLine(an[h]);

            //}



            #endregion

            #region Array.reverse(Name von Variable); ترتيب الاعداد في (الاريي) عكسيا
            //int[] an = new int[] {76,45,42,65,87,33};
            //Array.Reverse(an);
            //for (int h = 0; h < an.Length; h++)
            //{

            //    Console.WriteLine(an[h]);
            //}

            //string h = " nereimargorP ebeiL hcI ";
            //char[] name = h.ToCharArray();
            //Array.Reverse(name);
            //Console.WriteLine(name);



            #endregion

            #region Array.sort(Name von Variable); dann Array.reverse(Name von Variable); ترتيب الاعداد في (الاريي) تنازليا

            //int[] an = new int[] { 76, 45, 42, 65, 87, 33 };
            //Array.Sort(an);
            //Array.Reverse(an);

            //for (int d = 0; d < an.Length; d++)
            //{
            //    Console.WriteLine(an[d]);
            //}
            //int[] an = new int[] { 76, 45, 42, 65, 87, 33 };

            //Array.Reverse(an);
            //Array.Sort(an);
            //for (int i = 0; i < an.Length; i++)
            //{
            //    Console.WriteLine(an[i]);
            //}
            #endregion

            #region Array mit foreach

            //int[] r = new int[] { 2, 6, 5, 6, 8 };
            //foreach(int t in r)
            //{
            //    Console.WriteLine(t);
            //}

            //string[] st = new string[] { " Ich liebe Programmieren " };





            #endregion





            #region الاستلام من المستخدم


            //Console.Write(" Anzahl der gewümschten Eingaben: ");
            //int a = int.Parse(Console.ReadLine());
            //string[] arr = new string[a];
            //for (int x = 0; x < arr.Length; x++)
            //{

            //    Console.Write("Eingabe " + (x + 1) + " : ");
            //    arr[x] = Console.ReadLine();


            //}
            //Console.WriteLine(" Der zweite Name war: "+arr[1]);

            Console.Write(" Gewünschte Anzahl eingeben: ");
            int an = int.Parse(Console.ReadLine());
            string[] str = new string[an];

            for (int x = 0; x < an; x++)
            {
                Console.Write(" Eingabe " + (x + 1) + " : ");
                str[x] = Console.ReadLine();
            }

            Console.WriteLine(" Ihre Eingaben sind ...");
            for(int k = 0; k < str.Length; k++)
            {
                Console.WriteLine(str[k]);
            }


            #endregion




        }


        
    }
}
