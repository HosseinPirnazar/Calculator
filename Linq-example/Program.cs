using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_example
{
    class Program
    {
        static void Main(string[] args)
        {
            //Linq

            //Select * From Person as p
            //Form p in Person select p   =>  Linq


            int[] numbers={1 ,2, 3, 4,5 , 45, 71, 12 ,41};

            int[] RES45 = (from n in numbers select n).ToArray();
            var lambda45 = numbers.ToArray();
            


            


            //int[] Result1 = (from n in numbers select n).ToArray();
            var lambda1 = numbers.ToArray();

            //int[] Result2 = (from n in numbers orderby n descending select n).ToArray();
            var lambda2 = numbers.OrderByDescending(n => n).ToArray();

            //int[] Result3 = (from n in numbers where n > 30 && n < 80 orderby n descending select n).ToArray();
            var lambda3 = numbers.Where(n => n > 30 && n < 80).OrderByDescending(n => n).ToArray();
            //int Result4 = (from n in numbers where n == 3 select n).First();
            var lambda4 = numbers.First(n => n == 4);
            //int Result5 = (from n in numbers where n == 48 select n).FirstOrDefault();
            var lambda5 = numbers.FirstOrDefault(n => n == 2);
            //int Result6 = (from n in numbers where n == 3 select n).Single();
            
            //int Result7 = (from n in numbers where n == 48 select n).SingleOrDefault();

            //var i1 = 123;

            //var l2="Hossein";

            //var l3 = DateTime.Now;

            //bool Result8 = (from n in numbers where n == 48 select n).Any();
            var lambda6 = numbers.Any(n => n == 2);
            //int Count = (from n in numbers select n).Count();
            var lambda9 = numbers.Count();
            //int Max = (from n in numbers select n).Max();

            //int Min = (from n in numbers select n).Min();

            //int Sum = (from n in numbers select n).Sum();

            List<string> Names = new List<string>();
            //Names.Add("Ali");
            //Names.Add("Hossein");
            //Names.Add("Iman");
            //Names.Add("Reaza");
            //Names.Add("Amir");

            //var Res1 = (from n in Names select n).ToList();
            var lam1 = Names.ToList();
            //var Res2 = (from n in Names where n.ToLower().Contains("i") select n).ToList();
            var lam2 = Names.Where(n => n.ToLower().Contains("i")).ToList();
            //var Res3 = (from n in Names where n.ToLower().StartsWith("i") select n).ToList();
            var lam3 = Names.Where(n => n.ToLower().StartsWith("i")).ToList();
            //var Res4 = (from n in Names where n.ToLower().EndsWith("i") select n).ToList();














            //List<string> Names = new List<string>();

            //Names.Add("Ali");
            //Names.Add("Hossein");
            //Names.Add("Iman");
            //Names.Add("Reaza");
            //Names.Add("Amir");


            //var RES8 = (from n in Names where n.StartsWith("A") select n).ToList();




            //Console.WriteLine(Res1);
            //Console.ReadKey();


        }
    }
}
