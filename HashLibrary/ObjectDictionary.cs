using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashLibrary
{
    public class ObjectDictionary
    {
        string[] mykeys = new string[6500];
        int[] myvalues = new int[6500];
        /*List<string> mykeys = new List<string>() myArr1.SetValue( "three", 3 );
        List<int> myvalues = new List<int>() { 6473, 1535, 3123, 1359 };*/
        List<bool?> mybools = new List<bool?>();

        public bool? checkMyDictionary(int valueinput, string word)
        {
            /*mykeys[6473] = "keith";
            mykeys[1535] = "ray";
            mykeys[3123] = "drew";
            mykeys[1359] = "abc";*/

            bool? contains = null;
            int count = 0;
            foreach (string key in mykeys)
            {
                //Console.WriteLine(count);
                if (word == mykeys[count])
                {
                    mybools.Add(true);
                }

                if (word != mykeys[count])
                {
                    mybools.Add(false);
                }
                count++;
            }

            if (mybools.Contains(true))
            {
                contains = true;
            }

            else
            {
                contains = false;
            }
            foreach (bool bo in mybools)
            {
                if (mybools.Contains(false))
                {
                    //Console.WriteLine(bo);
                }
            }
            return contains;
        }

        public Array Keys
        {
            get
            { return mykeys; }
        }

        public Array Values
        {
            get
            { return myvalues; }
        }
        
        public void addKey(string key, int value)
        {
            Keys.SetValue(key, value);
        }

        public void addValue(int value)
        {

        }

        public void PushBoth(string key, int value)
        {
            addKey(key, value);
            //addValue(value);
        }

        /*public void PopBoth()
        {
            mykeys.RemoveAt(mykeys.Count-1);
            myvalues.RemoveAt(myvalues.Count - 1);
        }*/

        public void displayDictionary()
        {
            int count = 0;
            foreach (string key in mykeys)
            {
                if (mykeys.GetValue(count) != null)
                Console.WriteLine("key {0}- {1}, value -{2}",count,mykeys.GetValue(count), myvalues[count]);
                count++;
            }
        }

    }
}
/*Dictionary<string, int> hashdict = new Dictionary<string, int>
        {
            ["keith"] = 533,
            ["ray"] = 332,
            ["drew"] = 434
        };
        public bool checkDictionary(int value)
        {
            bool contains = false;
            if (hashdict.ContainsValue(value) == true)
            {
                contains = true;
            }
            if (!hashdict.ContainsValue(value) == true)
            {
                contains = false;
            }
            return contains;
        }*/