using System;

namespace Cats
{
    class Cat
    {
        private int its_age;

        public int Age
        {
            get { return its_age; }
            set { its_age = value;}
        }

        public Cat(int its_age)
        {
            Age = its_age;
        }

        public void Meow()
        {
            Console.WriteLine("Meow!");
        }

    }
}
