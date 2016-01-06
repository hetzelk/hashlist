using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Dictionary T
    set value
    get value
    private hash
*/
namespace HashLibrary
{
    public class HashWord
    {
        public List<char> splitWord(string item)
        {
            List<char> letterlist = new List<char>();
            foreach (char c in item)
            {
                letterlist.Add(c);
            }
            return letterlist;
        }

        public int hashIt(List<char> letterlist)
        {
            int hashedobject = 14;

            foreach(char c in letterlist)
            {
                int num = (int)c;
                hashedobject += num;
                hashedobject = hashedobject * 2;
                hashedobject = hashedobject - 17;
            }
            Console.WriteLine(hashedobject);
            return hashedobject;
        }
    }
}
