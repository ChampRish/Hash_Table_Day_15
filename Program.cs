using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable_Day15_Assignment_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UC4_HashTableBuilder hashTable = new UC4_HashTableBuilder();
            hashTable.Sentence = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
            hashTable.WordToCheck = "paranoid";
            Console.WriteLine($"Frequency of word is {hashTable.FindFrequencyOfWord()}");

            Hashtable obj = new Hashtable();
            obj.Add(1, "be");
            obj.Add(2, "to");
            obj.Add(3, "not");
            obj.Add(4, "or");
            obj.Add(5, "be");
            obj.Add(6, "To");
            foreach (DictionaryEntry item in obj)
            {
                Console.Write(item.Value+" ");
            }

            Console.ReadLine();
        }
    }
}
