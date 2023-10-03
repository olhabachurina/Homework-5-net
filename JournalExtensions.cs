using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_5_net
{
    public static class JournalExtensions
    {
        public static Journal AddPeople (this Journal journal, int increment)
        {
            journal.NumberOfPeople += increment;
            return journal; 
        }
        public static Journal RemovePeople(this Journal journal, int decrement)
        {
            journal.NumberOfPeople -= decrement;
            return journal;
        }

        public static bool AreJournalsEqual(Journal journal1, Journal journal2)
        {
            return  journal1.Equals(journal2);
        }

        public static bool AreJournalsNotEqual(Journal journal1, Journal journal2)
        {
            return !journal1.Equals(journal2);
        }

        public static bool IsJournalLessThan(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfPeople < journal2.NumberOfPeople;
        }

        public static bool IsJournalGreaterThan(Journal journal1, Journal journal2)
        {
            return journal1.NumberOfPeople > journal2.NumberOfPeople;
        }
    }
}

