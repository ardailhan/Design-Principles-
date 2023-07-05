using Single_Responsibility;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_IdealCode
{
    class Database
    {
        public void Connect()
        {
            //...
            Console.WriteLine("Veritabanı bağlantısı sağlanmıştır.");
        }

        public void Disconnect()
        {
            //...
            Console.WriteLine("Veritabanı bağlantısı kesilmiştir.");
        }
        public string State { get; set; }
    }

    class PersonService
    {
        public List<Person> GetPersons()
        {
            return new()
            {
                new(){Name = "Arda", Surname = "İlhan"},
                new(){Name = "Falan", Surname = "İlhan"},
                new(){Name = "Filan", Surname = "İlhan"}
            };
        }
    }
}
