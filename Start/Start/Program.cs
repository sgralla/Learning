using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;

namespace Start
{
    internal class Program
    {
        static void Main(string[] args)
        {
//            var rect = new Rectangle(5, 4);
//            rect.draw('#',false);
//
//            Console.WriteLine();
//
//            rect.draw('#',true);
//
//            Console.WriteLine();
//
//            rect.draw('#',false);
//
//            Console.WriteLine();
//
//
//            var sq = new Square(7);
//
//            sq.draw('o', false);
//
//
//            var recA = new Rectangle(4, 3);
//
//            recA.draw('+', false);
//            Console.WriteLine();
//
//            recA.draw('+', true);
//
//
//            Console.ReadKey();

            /*
            var rnd = new Random();
            var Arr = new int[5];
            var Arr2 = new int[5];
            var Stopw = new Stopwatch();

            for (var i = 0; i < 5; i += 1)
            {
                Arr[i] = rnd.Next(5);
            }

            Array.Copy(Arr,Arr2,5) ;

            Stopw.Start();

            Array.Sort(Arr);

            Stopw.Stop();

            Console.WriteLine(Stopw.ElapsedMilliseconds);


            Stopw.Start();

//            Sort.BubbleSort(Arr2);
//            Sort.NotinsertionSort(Arr2);
//            Sort.SelectionSort(Arr2);
//            Sort.QuickSort(Arr2);
//            Stopw.Stop();
//            Console.WriteLine(Stopw.ElapsedMilliseconds);

            //

            FileStream ostrm;
            StreamWriter writer;
            var oldOut = Console.Out;
            try
            {
                ostrm = new FileStream ("./Redirect.txt", FileMode.OpenOrCreate, FileAccess.Write);
                writer = new StreamWriter (ostrm);
            }
            catch (Exception e)
            {
                Console.WriteLine ("Cannot open Redirect.txt for writing");
                Console.WriteLine (e.Message);
                return;
            }
            Console.SetOut (writer);
            Console.WriteLine ("This is a line of text");
            Console.WriteLine ("Everything written to Console.Write() or");
            Console.WriteLine ("Console.WriteLine() will be written to a file");

            Sort.VisualMergeSort(Arr2, 10);

            Console.SetOut (oldOut);
            writer.Close();
            ostrm.Close();
            Console.WriteLine ("Done");

            Sort.VisualMergeSort(Arr2, 10);

            Console.ReadKey();

//            foreach (var a in Arr)
//            {
//                Console.WriteLine(a);
//            }

*/
//            var oldOut = Console.Out;
//            var ostrm = new FileStream ("./Linq.txt", FileMode.Create, FileAccess.Write);
//            var streamWriter = new StreamWriter (ostrm);
//            var rnd = new Random();
//            var duoray = new int[255];
//
//            for (var i = 0; i < 512; i += 1)
//            {
//                //streamWriter.Write(rnd.Next(1, 255));
//                //streamWriter.Write(' ');
//                //streamWriter.WriteLine((char)rnd.Next(1, 255));
//    //            duoray[i] = i*i;
//                //duoray[i, 1] = i*i;
//                streamWriter.Write(i);
//                streamWriter.Write(",");
//                streamWriter.WriteLine(Convert.ToChar(i));
//            }
//
//            streamWriter.Close();
//            ostrm.Close();

//            var rstrm = new FileStream("./Linq.txt", FileMode.Open, FileAccess.Read);
//            var strread = new StreamReader(rstrm);
//            var bufferstring = "";
//
//            while (!strread.EndOfStream)
//            {
//                bufferstring = (string)strread.ReadLine();
//                duoray = bufferstring.Split(' ', StringSplitOptions.None);
//
//                duoray;
//            }

//            const string filePath = "./Linq.txt";
//            var data = File.ReadLines(filePath).Select(x => x.Split(',')).ToArray();
//
//            var teststr = "0,€";
//            var testcollection = teststr.Split(',');
//
//            Console.WriteLine(testcollection[0]);
//
//
//            var query =
//                from d in data
//                select d.ToString();

//            var q2 =
//                from e in duoray
//                group e by e % 10;

            //    select e;

//            foreach (var d in query)
//            {
//                Console.WriteLine(d);
//            }

//            foreach (var d in data)
//            {
//                Console.WriteLine(d);
//            }
//            for (var i = 0; i < data.Length; i+=1)
//            {
//                Console.WriteLine(data[i,0]);
//            }


            var rect = new Rectangle(4,7);
            rect.draw('@',false);

            rect.Rotate();

            rect.draw('@',false);

            rect.Inner();

            rect.draw('#', false);

            rect.Hoch2();

            rect.draw('*', false);


            for (var i = 0; i < 8; i += 1)
            {
                for (var j = 0; j < 8; j += 1)
                {
                    if ((i+j)%2 == 0)
                        Console.Write("[+]");
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();



        }

    }
}
