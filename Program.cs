using System;

namespace Classy
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] breed1 = { "Bulldog", "Great Dane", "Pitbull", "Poodle", "Pug" };
            string[] dname1 = { "Dukes", "Bentley", "Dean", "Tsu", "Ruff" };

            foreach(string item in dname1)
            foreach(string item1 in breed1)
            {
                Console.WriteLine(item);
                Console.WriteLine(item1);
            }

            string[] dname2 = { "gore", "deek", "tundy", "ferg", "Xanz" };
            string[] breed2 = { "bulldog", "pitbull", "poodle", "hound", "rotweiler" };

            foreach(string item in dname2)
            foreach(string item1 in breed2)
            {
                Console.WriteLine(item);
                Console.WriteLine(item1);
            }
            string[] cname1 = { "fluffs", "tickles", "cream", "queen", "kimz" };

            foreach(string item in cname1)
            {
                Console.WriteLine(item);
            }
            bool sixORno = true; 
        }
    }
    class Animal
    {        
        
     public string _dname {get; set;}  
     public string _breed {get; set;}
     public Animal(string Adname1, string Abreed1)
        {
            _dname = Adname1;
            _breed = Abreed1;
           
        }
        
        public string dname1 { get; set; }
        public string breed1 { get; set; }
        class Dogs : Animal
        {
            public Adname(string Adname1, string Abreed1) : base(Adname1, Abreed1)
            {
                dname1 = Adname1;
                breed1 = Abreed1;
            }
        }
        public string _cname { get; set; }
        public bool _sixORno { get; set; }
        class Cats : Animal
        {
            public Canimal(string Acname, bool sixORno)
            {
                _cname = Acname;
                _sixORno = sixORno;

                if (sixORno)
                {
                    Console.WriteLine("That my cat!!!");
                }
                else
                {
                    Console.WriteLine("Yea, I'll just get a new cat...");
                }
            }
        }
    }
}
