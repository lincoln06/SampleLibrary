using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleLibrary
{
    public class Rent : Book
    {
        public string OwnerFirstName { get; set; }
        public string OwnerLastName { get; set; }
        public DateTime WasTaken { get; set; }
        public DateTime MustGiveBack { get; set; }
        public Rent(string ownerFirstName, string ownerLastName, string title, int year, string firstName, string lastName, DateTime wasTaken, DateTime mustGiveBack)
            :base(firstName, lastName, title, year)
            {
            OwnerFirstName = ownerFirstName;
            OwnerLastName = ownerLastName;
            WasTaken = wasTaken;
            MustGiveBack = mustGiveBack;
            }
        public static Rent RentBook(string ownerFirstName, string ownerLastName, string title, int year, string firstName, string lastName, DateTime wasTaken, DateTime mustGiveBack)
        {
            return new Rent(ownerFirstName, ownerLastName, title, year, firstName, lastName, wasTaken, mustGiveBack);
        }

    }
}
