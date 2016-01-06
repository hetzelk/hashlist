using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HashLibrary;
using System.ComponentModel;

namespace HashConsole
{
    class Program
    {

        static void Main(string[] args)
        {
            Run();
        }

        static public void Run()
        {
            HashWord hash = new HashWord();
            ObjectDictionary objectd = new ObjectDictionary();
            
            Console.WriteLine("----------CheckBaseDict---------");
            objectd.displayDictionary();
            Console.WriteLine("--------------------------------");
            
            Console.WriteLine("Please enter a word to check to see if it's hashed version exists. ");
            string word = Console.ReadLine();
            addItem("keith");
            addItem("ray");
            addItem("drew");
            addItem("abc");
            
            List<char> letterlist = hash.splitWord(word);
            int hasheditem = hash.hashIt(letterlist);
            bool? answer = objectd.checkMyDictionary(hasheditem, word);

            if (answer == false)
            {
                Console.WriteLine("False, it does not exist, it has been added. ");
                addItem(word);
                Console.WriteLine("------------Added--------------");
                objectd.displayDictionary();
                Console.WriteLine("-------------------------------");
            }
            if (answer == true)
            {
                Console.WriteLine("This already exists. Try again with a different word. ");
                Run();
            }
            Run();
            Console.Read();
        }

        public static void addItem(string input)
        {
            HashWord hash = new HashWord();
            ObjectDictionary objectd = new ObjectDictionary();
            List<char> letterlist = hash.splitWord(input);
            int hasheditem = hash.hashIt(letterlist);
            bool? answer = objectd.checkMyDictionary(hasheditem, input);
            objectd.PushBoth(input, hasheditem);
        }
    }
}
