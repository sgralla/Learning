//using System;

using System;

namespace Start
{
    public class Program
    {
        public static void Main(string[] args)
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

            //Console.BackgroundColor = ConsoleColor.Blue;

//            var rect = new Rectangle(4,7);
//            rect.Draw('@',false);
//
//            rect.Rotate();
//
//            rect.Draw('@',false);
//
//            rect.Inner();
//
//            rect.Draw('#', false);
//
//            rect.Square();
//
//            rect.Draw('*', false);
//
//
//            for (var i = 0; i < 8; i += 1)
//            {
//                for (var j = 0; j < 8; j += 1)
//                {
//                    Console.Write((i + j) % 2 == 0 ? "[+]" : "   ");
//                }
//                Console.WriteLine();
//            }
//
//            var tri = new Triangle(5);
//            tri.Draw('+',false);
//
//            Console.WriteLine();
//            Console.WriteLine();
//
//            tri.Draw('௵', true, Operator.Down);
//
//
//            tri.Drawfourbyfour('M',false);

//            var cir = new Circle(3);
//            cir.Draw('+', false);
//
//            var rho = new Diamond(27);
//            rho.Draw('+', false);
//
//            var rho2 = new Diamond(14);
//            rho2.Draw('+',false);
//
//            Console.ReadKey();

//            Console.Clear();
//            Console.WriteLine();
//
//            var sq = new Square(3);
//            sq.Draw('#', true);
//            Console.WriteLine();
//            sq.Square();
//            sq.Draw('@', true);
//            Console.WriteLine();
//            sq.Inner();
//            sq.Draw('*', false);
//            Console.WriteLine();
//            sq.Move(3, 5);
//            sq.Draw('o', false);
//            Console.WriteLine();
//
//            var rec = new Rectangle(3,4,5,6);
//            rec.Draw('#', true);
//
//            var squ = new Square(5,4,3);
//            squ.Square();
//            squ.ResetPosition();
//            squ.Draw();
//
//            squ.Move(-1,-1);
//            squ.Draw();
//            squ.Root();
//            squ.Move(-1,-1);
//            squ.Draw();
//
//            squ.ResetPosition();

//            var squ = new Square(5);
//            squ.Draw();
//            Rhombus rho;
////            squ.Tilt(ref squ, out rho);
////            rho.Draw();
//            Square.ToRhombus(squ, out rho, true);
//
//            rho.Draw();
//
//            Rhombus.ToSquare(rho, out squ, true);
//            squ.Draw();
//
//            var dia = new Diamond(7);
//            dia.Draw();
//            Square sq;
//            Rhombus.ToSquare(dia, out sq);
//            sq.Draw();



//            var cro = new Cross(3,3,15,3,3);
//            cro.Draw('+');
//            Console.WriteLine();
//            cro.Tilt(true);
//
//            Console.WriteLine();
//            cro.Tilt(true, 'ä');

//            CWriter.A();
//            CWriter.B();
//
//            CWriter.CWriteLine("ABC");

//            var gList = new GenericList<Shape>();
//            gList.Add(new Circle(3));
//            gList.Add(new Diamond(4));
//            Console.WriteLine(gList.Index(1));
//            var post = "This is a rather long post which needs to be shortened.";
//            var shortenedpost = post.Shorten(5);
//            Console.WriteLine(shortenedpost);
//
//            DateTime? Date2;
//            if (Console.ReadKey().Equals(value: 'a'))
//                Date2 = new DateTime(2015, 09, 08);
//            else
//                Date2 = null;
//            var date3 = Date2 != null ? Date2.GetValueOrDefault() : DateTime.Today;
//            Console.WriteLine(date3);




        }

        public enum Operator { Top = 0, Down = 1, Left = 2, Right = 3
        }

    }
}
