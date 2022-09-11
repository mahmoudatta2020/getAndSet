using System;

namespace getAndSet
{
    class person
    {
        private string name;
        public string Name
        {
            set { name = value; }
            get { return name;}
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            person myobJ = new person();
            myobJ.Name = "Mahmoud Reda";
            Console.WriteLine(myobJ.Name);
        }
    }
}
