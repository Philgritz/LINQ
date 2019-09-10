using System;
using System.Linq;
using CSharp2SqlLibrary;
using ExtensionMethods;

namespace LINQConsole {
    class States {
        public string Code { get; set; }
        public string Name { get; set; }
    }

    class Program {

    void Run() {
            var Connection = new Connection(@"localhost\sqlexpress", "PRS");
            Connection.Open();

            Products.Connection = Connection;


            var products = Products.GetAll();
            foreach(var product in products) {
                product.PrintBrief();
            }


            //Vendors.Connection = Connection;

            //var states = new States[] {
            //    new States() { Code = "WA", Name = "Washington"},
            //    new States() { Code = "CA", Name = "California"},
            //    new States() { Code = "OR", Name = "Oregon"},
            //};

            //var vendorsWithState = from v in Vendors.GetAll()
            //                       join s in states
            //                       on v.State equals s.Code
            //                       select new {
            //                           Vendor = v.Name,
            //                           State = s.Name
            //                       };

            //foreach(var v in vendorsWithState) {
            //    Console.WriteLine($"Vendor {v.Vendor} is in state {v.State}");
            //}


            //Products.Connection = Connection;

            //var products = from p in Products.GetAll()
            //               join v in Vendors.GetAll()
            //               on p.VendorId equals v.Id
            //               select new {
            //                   Product = p.Name, Price = p.Price, Vendor = v.Name  //list out data you want                        
            //               };
            //foreach (var p in products) {
            //    Console.WriteLine($"{p.Product} priced at {p.Price} is from {p.Vendor}");
            //}



            //#region
            //Products.Connection = Connection;

            //var totalAllProducts = (from p in Products.GetAll()
            //                        select p).Sum(p => p.Price);
            //Console.WriteLine($"Total all prices is {totalAllProducts}");


            //var priceTotal = Products.GetAll().Sum(p => p.Price);
            //Console.WriteLine($"Total of all prices is {priceTotal}");
            //#endregion



            //var vendors = from v in Vendors.GetAll()
            //              orderby v.Name
            //              select v;

            //foreach(var v in vendors) { Console.WriteLine($"{v} "); }


            //var adidas = from v in Vendors.GetAll()
            //             where v.Code.Equals("11111")
            //             select v;

            //foreach(var v in adidas) { Console.WriteLine(v); }



            //var users = from u in Users.GetAll()
            //            where u.IsReviewer  //comparing two strings, use Equals method, not ==
            //             select u;


            //foreach(var user in users) {
            //    Console.WriteLine($"{user.Firstname} {user.Lastname} is a Username");
            //}

            Connection.Close();

    }
   
        static void Main(string[] args) {
            var pgm = new Program();
            pgm.Run();


            

            //int[] ints = { 2, 4, 6, 8, 7, 5, 3, 1 };  //put collection in sequence (query syntax)

            //var ascInts = (from i in ints  // Defines query, doesn't execute until something uses ascInts variable
            //               where i % 2 == 1 && i < 7 //modulus 1 returns only odd numbers, & <7
            //               orderby i descending 
            //               select i); //what we want in the output, () allows addition of method syntax .Average

            //var avg = ascInts.Average(i => i); // (i => i) is lambda syntax. look at everynumber in collection, puts in avg

            //Console.WriteLine($"Average of odds less than 7 is {avg}");

            //foreach(var i in ascInts) { //ascInts is input into loop
            //    Console.Write($"{i} ");

            //}
        }
    }
}
