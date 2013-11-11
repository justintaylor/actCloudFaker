using System;
using Faker;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Faker
{
    class Program
    {

        
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            // for random dates
            int year = DateTime.Now.Year;

            //tab for delineation
            var tab = (char)9;

            int randomizer = 0;

            using (StreamWriter writer =
        new StreamWriter("..\\..\\..\\data.csv"))
                {
                for (int i = 0; i < 10; i++)
                {
                    //generate a random number to be used in various if statements to generate more random data
                    randomizer = RandomNumber.Next(1, 10);
                    
                    //Console.WriteLine(Name.First() + "    " + Name.Last());

                    //FirstName	LastName	Company	JobTitle	EmailAddress	PrimaryPhoneNumber	AltPhoneNumber	Type	Line1	Line2	Line3	City	State	PostalCode	Country	AltType	AltLine1	AltLine2	AltLine3	AltCity	AltState	AltPostalCode	AltCountry	Website	Birthday

                    writer.WriteLine(

                        (randomizer == 1 || randomizer == 2 ? "" : Name.First()) + tab +    //FistName
                        (randomizer == 3 || randomizer == 2 ? "" : Name.Last()) + tab + //LastName

                        (randomizer == 4 ? "" : Company.Name()) + tab +     //Company
                        Company.CatchPhrase() + tab +   //JobTitle

                        (randomizer == 5 ? "" : Internet.Email()) + tab +   //EmailAddress

                        (randomizer == 6 ? "" : Phone.Number()) + tab +     //PrimaryPhoneNumber
                        (randomizer == 7 ? "" : Phone.Number()) + tab +     //AltPhoneNumber
                        //
                        (IsOdd(i) ? "Home" : "Work") + tab +    //Type
                        Address.StreetAddress() + tab +     //Line1
                        (RandomNumber.Next(1, 5) == 1 ? Address.SecondaryAddress() : "") + tab +  //Line2 - 1 out of every 5 will have an apt or suite
                        "" + tab +     //Line3
                        Address.City() + tab +     //City
                        Address.UsStateAbbr() + tab +     //State
                        Address.ZipCode() + tab +    //PostalCode
                        Address.Country() + tab +     //Country

                        (IsOdd(i) ? "Work" : "Home") + tab +     //AltType
                        Address.StreetAddress() + tab +    //AltLine1
                        (RandomNumber.Next(1, 5) == 1 ? Address.SecondaryAddress() : "") + tab +  //AltLine2 - 1 out of every 5 will have an apt or suite
                        "" + tab +     //AltLine3
                        Address.City() + tab +     //AltCity
                        Address.UsStateAbbr() + tab +     //AltState
                        Address.ZipCode() + tab +    //AltPostalCode
                        Address.Country() + tab +     //AltCountry

                        (randomizer == 5 ? "www." : "") + Internet.DomainName() + tab +     //Website

                        (randomizer == 4 ? "" : GenererateRandomBirthdate(year).ToShortDateString())    //Birthday
                    );
                }
            }


            //leave the following
            Console.WriteLine("Done... press any key to exit");
            Console.ReadKey(true);
        }

        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public static DateTime GenererateRandomBirthdate(int endYear)
        {

            int year = rnd.Next(1900, endYear);
            int month = rnd.Next(1, 12);
            int day = DateTime.DaysInMonth(year, month);

            int Day = rnd.Next(1, day);

            DateTime dt = new DateTime(year, month, Day);
            return dt.Date;
        }
    }
}
