using System;

namespace homeWork4
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. Verilmis string deyerini ters sekilde qaytaran metod. Misalcun metodu cagirib "salam" yazisi gondersek geriya "malas" yazisi qayitmalidir.
            #region invertedStr
            Console.WriteLine("String girin:");
            string text = invertedString(Console.ReadLine());
            Console.WriteLine(text);



            #endregion


            //2. Verilmis string deyerinde olan sozlerin sayini qaytaran metod.metoda istenilen formada string gonderildikde icerideki sozlerin sayi qayitmalidir, misalcun "   salam   sag  ol   " deyeri gondersek bele geriye 3 qaytarmalidir.

            #region strwordnumber
            Console.WriteLine("Cumleni girin:");
            var number = strWordNumber(Console.ReadLine());
            Console.WriteLine($"String deyerinde olan sozlerin sayı - {number}");
            #endregion



            
            //3. Verilmis string deyerinde verilmis char-in indexlerinden ibaret array qaytaran metod.Misalcun metodu cagirib "salam" string deyeri ve 'a' char deyeri gondersem geriye icinde 1 ve 3 deyerleri olan array qayitmalidir
            //Eliye bilmemisem(
            #region chrCount
            //foreach (var chrcount in chrCounts("alma", 'a'))
            //{
            //    Console.WriteLine(chrcount);
            //}
            #endregion
        }
        #region invertedStr
        static string invertedString(string str)
        {
            string gnirts = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                gnirts += str[i];

            }
            return gnirts;
        }
        #endregion


        #region strWordNumber
        static int strWordNumber(string words)
        {
            int counter = 1;
            for (int i = 1; i < words.Length - 1; i++)
            {
                if (words[i] == ' ')
                {
                    counter++;
                }
            }
            return counter;
        }
        #endregion


        //Eliye bilmedim bunu(
        #region chrCount1
        //static int [] chrCounts(string text, char letter)
        //{
        //    var counters = -1;
        //    var arry = new int[counters];

        //    for (int i = 0; i < text.Length; i++)
        //    {
        //        if (text[i] == letter)
        //        {
        //            arry[i] = i;
        //            counters++;
        //        }
        //    }
        //    return arry;

        //}
        #endregion
    }
}
