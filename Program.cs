using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_net
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Journal journal = new Journal { NumberOfPeople = 12 };
            Journal journal2 = new Journal { NumberOfPeople = 8 };
            journal = journal.AddPeople(4);
            journal2 = journal2.RemovePeople(3);
            Console.WriteLine(journal.NumberOfPeople); 
            Console.WriteLine(journal2.NumberOfPeople);
            Console.WriteLine(JournalExtensions.AreJournalsEqual(journal, journal2));    
            Console.WriteLine(JournalExtensions.AreJournalsNotEqual(journal, journal2)); 
            Console.WriteLine(JournalExtensions.IsJournalGreaterThan(journal, journal2)); 
            Console.WriteLine(JournalExtensions.IsJournalLessThan(journal, journal2));    
        }
    }
}
