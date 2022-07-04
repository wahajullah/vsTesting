using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public static class Program
    {
        static void Main(string[] args)
        {

            string[] i = { "1","3a","3" };
            foreach (var item in i)
            {
                try
                {
                    var j = Convert.ToInt16(item);
                    Console.WriteLine(j);
                }
                catch 
                {
                    
                }
            }


            //int i = 10;
            //var j =  "ME-" + i.ToString("000000");

            //List<string> abc = new List<string>();
            // var list = new List<string> { "notebook", "notebook", "mouse", "keyboard", "mouse" };
            //var cList = from x in list
            //            group x by x into g
            //            let count = g.Count()
            //           let val = g.Key
            //            orderby val ascending
            //            select new { Value = g.Key, Count = count };

            //var list1 = cList.ToList();
            //list1.OrderBy(x => x.Value).ToList();
            //foreach (var item in list1)
            //{
            //    abc.Add(item.Value + " "+ item.Count);
            //}
            //abc.Sort();
            ////list1.OrderBy((value)=>value.Value);
            //var sortedList = list1.OrderBy(x => x.Value).ToList();
            //string a, b;
            //SplitName("wahaj Ullah",out a,out b);
            int n = 15;// { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //for(int i = 1; i <= n; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //        Console.WriteLine("FizzBuzz");
            //    else if (i % 3 == 0)
            //        Console.WriteLine("Fizz");
            //    else if (i % 5 == 0)
            //        Console.WriteLine("Buzz");
            //    else
            //        Console.WriteLine(i);
            //}


            Console.ReadKey();
        }
        static void SplitName(string name, out string firstNames, out string lastName)
        {
            int i = name.LastIndexOf(' ');
            firstNames = name.Substring(0, i);
            lastName = name.Substring(i + 1);
        }
        //public NotesStore() { }
        //public void AddNote(String state, String name) { }
        //public List<String> GetNotes(String state) { }

        
    }
}
