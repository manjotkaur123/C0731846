using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2019WCSD3354WEEK05
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestion2();
            a.PlayingWithForLoops();
        }
    }

    class TestQuestion2
    {
        public int myFavoriteVariable = 0;

        public void PlayingWithForLoops()
        {
            // write a For Loop to Add 10 Numbers
            for (; MyMethod();)
            {
                if (myFavoriteVariable > 10)
                {
                    Console.WriteLine("i am so out of here!");
                    break;
                }
                Console.WriteLine("oh no I have to go through this stupid loop again...");
            }
        }
        public bool MyMethod()
        {
            myFavoriteVariable++;
            return true;
        }
    }
    class DOG
    {
        public DOG(string name, string bread, DOG next, DOG prev)
        {
            dog_name = name;
            dog_bread = bread;
           
        }
        public string dog_name;
        public string dog_bread;
            public DOG next_dog;
            public DOG previous_dog;
          

    }
    class birthday_party {
        public DOG peanut;
        public DOG fifi;
        public DOG clarence;
        public DOG ruy;

        public DOG head;
        public DOG tail;
        public DOG temporary;
        public void pea()
        {
            peanut = new DOG 
("peanut ", "bichon");
            fifi = new DOG("fifi", "poodle");
            clarence = new DOG("clearenc", "gernam sheppard");
            ruy = new DOG("ruy", "bengle");

            peanut.previous_dog = null;
            peanut.next_dog = fifi;
            fifi.previous_dog = peanut;
            fifi.next_dog = clarence;
            clarence.previous_dog = fifi;
            clarence.next_dog = roy;
            ruy.previous_dog = clarence;
            ruy.next_dog = null;
            head = peanut;
            tail = ruy;
        }

        public void setupPartyList()
        {

        }
            


    }
}

