using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    class Firma
    {
        public string name { get; set; }
        public int begin { get; set; }
        public string profile { get; set; }
        public string fio { get; set; }
        public int count { get; set; }
        public string address { get; set; }



        public Firma() { }
        public Firma(string n, int b, string p, string f, int c, string a) { name = n;begin = b;profile = p;fio = f;
            count = c;address = a;
        }
    }
    class employee
    {
        public string fio { get; set; }
        public string job { get; set; }
        public string phone { get; set; }
        public string Email { get; set; }
        public decimal zarob { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Firma[] firms = new Firma[]
            {
                new Firma{name = "Apple", begin = 1995, profile="IT", fio="Steve Jobs",
                address ="California", count=164000},
                new Firma{name="Food Market", begin=2015, profile="Marketing", fio="Aleks Cuper", count=12000,
                address="London"},
                new Firma { name="McDonald Odessa", begin=1990, profile="Marketing", fio="Ronald", count=250,
                address="Odessa" },
                new Firma { name="Firma1", begin=2023, profile="Building", fio="White", count=200,
                address="Kyiv" },
                new Firma { name="White", begin=2023, profile="Building", fio="Black", count=200,
                address="Kyiv" },
            };

            foreach (var s in firms)
                Console.WriteLine(s);


            Console.WriteLine("Firms with Food:");
            var food = firms.Where(f => f.name.Contains("Food"));
            foreach (var s in food)
                Console.WriteLine(s);


            Console.WriteLine("Firms with marketing:");
            var prof = firms.Where(p => p.profile.Contains("Marketing"));
            foreach (var c in prof)
                Console.WriteLine(c);


            Console.WriteLine("Firms with marketing or IT:");
            var profmar = firms.Where(p => p.profile=="Marketing" || p.profile=="IT");
            foreach (var c in profmar)
                Console.WriteLine(c);


            Console.WriteLine("Count employee > 100:");
            var countemp = firms.Where(u => u.count > 100);
            foreach (var empl in countemp)
                Console.WriteLine(empl);


            Console.WriteLine("Count employee > 100 && <300:");
            var counemp = firms.Where(u1 => u1.count > 100&&u1.count<300);
            foreach (var empl in counemp)
                Console.WriteLine(empl);


            Console.WriteLine("Address in London");
            var adr = firms.Where(a => a.address.Contains("London"));
            foreach (var ad in adr)
                Console.WriteLine(ad);


            Console.WriteLine("Name with White: ");
            var surname = firms.Where(a => a.name.Contains("White"));
            foreach (var ad in surname)
                Console.WriteLine(ad);


            Console.WriteLine("Firma > 2 years: ");
            var year = firms.Where(a => a.begin<2021);
            foreach (var ad in year)
                Console.WriteLine(ad);


            Console.WriteLine("Firma > 2 years: ");
            var beg = firms.Where(a => a.name.Contains("White")&& a.fio.Contains("Black"));
            foreach (var ad in beg)
                Console.WriteLine(ad);

            /////////////////////////////////////////////
            ///

            employee[] users = new employee[]
            {
                new employee {fio="Том", job="Developer", phone="9804329804", Email="fsfwe@gmail.com",
                zarob=12000},
                new employee {fio="Lionel", job="Designer",  phone="9804222804", Email="1233@gmail.com",
                zarob=12000},
                new employee {fio="Джон", job="Manager",phone="3380432944" , Email="ffere@mail.ru",
                zarob=12000},
                new employee {fio="Элис", job="Admin", phone="238049804", Email="di2e@mail.ru",
                zarob=12000}
            };

            foreach (var s in users)
                Console.WriteLine(s);


            Console.WriteLine("Manager: ");
            var m = users.Where(a => a.job.Contains("Manager"));
            foreach (var ad in m)
                Console.WriteLine(ad);


            Console.WriteLine("Phone begin 23: ");
            var ph = users.Where(a => a.phone.Contains("23"));
            foreach (var ad in ph)
                Console.WriteLine(ad);


            Console.WriteLine("Email begin 23: ");
            var em = users.Where(a => a.Email.Contains("di"));
            foreach (var ad in em)
                Console.WriteLine(ad);


            Console.WriteLine("Lionel: ");
            var na = users.Where(a => a.fio.Contains("Lionel"));
            foreach (var ad in na)
                Console.WriteLine(ad);
        }
    }
}
