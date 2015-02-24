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
            // for random dates, can't have any one born in the future ;-)
            int year = DateTime.Now.Year - 1;

            // character(s) for delineation
            // tab: (char)9
            var delimeter = ",";

            int randomizer = 0;

        #region user config

            int toCreate = 15000; // # of contacts to create

            // maximum random number to be used when generating random data
            // the larger this is in relation to the last case statement below (currently 9) the more contacts with 'full data' will be created
            int randomness = 9; 

            // save file in this dir
            string dir = System.Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\Downloads\";
        #endregion

            using(StreamWriter writer = new StreamWriter(dir + toCreate + " contacts.csv"))
            {
                // headers
                writer.WriteLine("FirstName,LastName,Company,JobTitle,EmailAddress,PrimaryPhoneNumber,AltPhoneNumber,Type,Line1,Line2,Line3,City,State,PostalCode,Country,AltType,AltLine1,AltLine2,AltLine3,AltCity,AltState,AltPostalCode,AltCountry,Website,Birthday,CustomField1");
                
                // contacts
                for (int i = 0; i < toCreate; i++)
                {
                    randomizer = RandomNumber.Next(1, randomness);

                    #region generate
                        string firstName = Name.First(); //FistName
                        string lastName = Name.Last();   //LastName

                        string company = Company.Name();     //Company
                        string title = Company.CatchPhrase();   //JobTitle

                        string email = Internet.Email();  //EmailAddress

                        string phone = Phone.Number();  //PrimaryPhoneNumber
                        string altPhone = Phone.Number();  //AltPhoneNumber
                        //
                        string type = (IsOdd(i) ? "Home" : "Work"); //Type
                        string line1 = Address.StreetAddress();  //Line1
                        string line2 = (RandomNumber.Next(1, 5) == 1 ? Address.SecondaryAddress() : "");  //Line2 - 1 out of every 5 will have an apt or suite
                        string line3 = (RandomNumber.Next(1, 5) == 1 && line2.Contains("Suite")) ? "Office " + RandomNumber.Next(1, 99) : "";  //Line3
                        string city = Address.City();  //City
                        string state = Address.UsStateAbbr();  //State
                        string zip = Address.ZipCode(); //PostalCode
                        string country = Address.Country();  //Country
                        //
                        string altType = (IsOdd(i) ? "Work" : "Home");  //AltType
                        string altLine1 = Address.StreetAddress(); //AltLine1
                        string altLine2 = (RandomNumber.Next(1, 5) == 1 ? Address.SecondaryAddress() : "");  //AltLine2 - 1 out of every 5 will have an apt or suite
                        string altLine3 = (RandomNumber.Next(1, 5) == 1 && altLine2.Contains("Suite")) ? "Office " + RandomNumber.Next(1, 99) : "";  //AltLine3
                        string altCity = Address.City();  //AltCity
                        string altState = Address.UsStateAbbr();  //AltState
                        string altZip = Address.ZipCode(); //AltPostalCode
                        string altCountry = Address.Country();  //AltCountry

                        string website = Internet.DomainName();  //Website

                        string birthday = GenererateRandomBirthdate(year).ToShortDateString();   //Birthday

                        string custom1 = i.ToString();
                    #endregion

                    #region modify

                    switch(randomizer)
                    {
                        case 1:
                            // no first name
                            firstName = "";
                            break;
                        case 2:
                            // no last name
                            lastName = "";
                            break;
                        case 3:
                            // a Company
                            firstName = "";
                            lastName = "";

                            title = "";

                            type = "Work";

                            altType = "" ;
                            altLine1 = "" ;
                            altLine2 = "" ;
                            altLine3 = "" ;
                            altCity = "" ;
                            altState = "" ;
                            altZip = "" ;
                            altCountry = "" ;
 
                            birthday = "" ;
                            break;
                        case 4:
                            // lower case first, last & company
                            firstName = firstName.ToLower();
                            lastName = lastName.ToLower();
                            company = company.ToLower();
                            break;
                        case 5:
                            // just an email
                            firstName = "" ;
                            lastName = "" ;
 
                            company = "" ;
                            title = "" ;
 
                            // email = "" ;
 
                            phone = "" ;
                            altPhone = "" ;
 
                            type = "" ;
                            line1 = "" ;
                            line2 = "" ;
                            line3 = "" ;
                            city = "" ;
                            state = "" ;
                            zip = "" ;
                            country = "" ;
 
                            altType = "" ;
                            altLine1 = "" ;
                            altLine2 = "" ;
                            altLine3 = "" ;
                            altCity = "" ;
                            altState = "" ;
                            altZip = "" ;
                            altCountry = "" ;
 
                            website = "" ;
 
                            birthday = "" ;
                            break;
                        case 6:
                            // no secondary address
                            altType = "" ;
                            altLine1 = "" ;
                            altLine2 = "" ;
                            altLine3 = "" ;
                            altCity = "" ;
                            altState = "" ;
                            altZip = "" ;
                            altCountry = "" ;
                            break;
                        case 7:
                            // add http:// to website
                            website = "http://" + website;
                            break;
                        case 8:
                            // add www. to website
                            website = "www." + website;
                            break;
                        case 9:
                            // just a company and a phone
                            firstName = "" ;
                            lastName = "" ;
 
                            // company = "" ;
                            title = "" ;
 
                            email = "" ;
 
                            // phone = "" ;
                            altPhone = "" ;
 
                            type = "" ;
                            line1 = "" ;
                            line2 = "" ;
                            line3 = "" ;
                            city = "" ;
                            state = "" ;
                            zip = "" ;
                            country = "" ;
 
                            altType = "" ;
                            altLine1 = "" ;
                            altLine2 = "" ;
                            altLine3 = "" ;
                            altCity = "" ;
                            altState = "" ;
                            altZip = "" ;
                            altCountry = "" ;
 
                            website = "" ;
 
                            birthday = "" ;
                            
                            break;
                        
                        default:
                            // full data contact
                            break;
                    }
 
                    #endregion


                    // generate email related to name(s) and company
                    if(email.Length > 0)
                    {

                        //create new email address based off of name and company
                        if (firstName.Length == 0 && lastName.Length == 0 && company.Length == 0)
                        {
                            // keep generated email
                        }
                        else
                        {
                            string prefix = "";
                            string suffix = "";

                            // email prefix
                            if (firstName.Length == 0 || lastName.Length == 0)
                            {
                                prefix = firstName + lastName;
                            }
                            else
                            {
                                switch (RandomNumber.Next(1, 4))
                                {
                                    case 1:
                                        // email with dot between names
                                        prefix = firstName + "." + lastName;
                                        break;
                                    case 2:
                                        // email with underscore between names
                                        prefix = firstName + "_" + lastName;
                                        break;
                                    case 3:
                                        // email both names
                                        prefix = firstName + lastName;
                                        break;
                                    case 4:
                                        // email with first char of first and then last names
                                        prefix = firstName.Substring(0, 1) + lastName;
                                        break;
                                }
                            }

                            // email suffix
                            if (company.Length > 0)
                            {
                                email = RemoveDomain(email);
                                email = email.Replace("@.", "@" + company.Replace(",", "").Replace(" ", "") + ".").Replace("'", ""); // replace commas, spaces and single quotes
                            }

                            if(prefix.Length != 0) 
                            {
                                //remove existing prefix
                                email = prefix + RemoveLocal(email);
                            }
                        }

                        #region doesn't correctly create email addresses if only first name is missing

                        /*
                        if (firstName.Length == 0 && lastName.Length == 0 && company.Length == 0)
                        {
                            //do nothing
                        }
                        else if(firstName.Length > 0 && lastName.Length > 0 && company.Length > 0)
                        {
                            email = RemoveDomain(email);
                            email = email.Replace("@.", "@" + company.Replace(",", "").Replace(" ", "") + ".").Replace("'", "");
                            email = RemoveLocal(email);
                            switch (RandomNumber.Next(1, 4))
                            {
                                case 1:
                                    // email with dot between names
                                    email = firstName + "." + lastName + email;
                                    break;
                                case 2:
                                    // email with underscore between names
                                    email = firstName + "_" + lastName + email;
                                    break;
                                case 3:
                                    // email both names
                                    email = firstName + lastName + email;
                                    break;
                                case 4:
                                    // email with first char of first and then last names
                                    email = firstName.Substring(0, 1) + lastName + email;
                                    break;
                            }
                        }
                        else
                        {
                            if (company.Length > 0)
                            {
                                email = RemoveDomain(email);
                                email = email.Replace("@.", "@" + company.Replace(",", "").Replace(" ", "") + ".").Replace("'", ""); // replace commas, spaces and single quotes
                            }

                            if (firstName.Length > 0 && lastName.Length > 0)
                            {
                                if (firstName.Length == 0)
                                {
                                    // only last
                                    // remove the local part
                                    email = RemoveLocal(email);
                                    email = lastName + email;
                                }

                                if (lastName.Length == 0)
                                {
                                    // only first
                                    email = RemoveLocal(email);
                                    email = firstName + email;
                                }
                            }
                        }
                        */
                        
                    #endregion

                    #region old and clunky???
                        /* // 
                    // make email a derivative of the actual first & last names
                    if (email.Length > 0 && randomizer != 5) // 5 = just and email
                    {
                        
                        if (firstName.Length == 0 && lastName.Length == 0)
                        {
                            // do nothing
                        }
                        else
                        {
                            // remove the local part
                            email = email.Remove(0, email.IndexOf("@"));

                            if (firstName.Length > 0 && lastName.Length > 0)
                            {
                                switch (RandomNumber.Next(1, 4))
                                {
                                    case 1:
                                        // email with dot between names
                                        email = firstName + "." + lastName + email;
                                        break;
                                    case 2:
                                        // email with underscore between names
                                        email = firstName + "_" + lastName + email;
                                        break;
                                    case 3:
                                        // email both names
                                        email = firstName + lastName + email;
                                        break;
                                    case 4:
                                        // email with first char of first and then last names
                                        email = firstName.Substring(0, 1) + lastName + email;
                                        break;
                                }
                            }
                            else if (firstName.Length == 0)
                            {
                                // firstname is blank
                                email = lastName + email;
                            }
                            else if (lastName.Length == 0)
                            {
                                // last name is blank
                                email = firstName + email;
                            }
                        }

                        // replace the domain part with company
                        if (company.Length > 0)
                        {
                            string remove = email.Substring(email.IndexOf("@"), email.IndexOf(".") - 1);
                            string insert = company.Replace(",", "").Replace(" ", "");
                            email = email.Replace(remove, insert);
                        }
                    */
                     #endregion
                        // lowercase
                        email = email.ToLower();
                    }

                    #region check various fields for quotes or apostrophes

                    // wrap quotes around company if there is a comma or apostrophe
                    AddQuotes(ref firstName);
                    AddQuotes(ref lastName);
                    AddQuotes(ref company);
                    AddQuotes(ref title);
                    AddQuotes(ref email);
                    AddQuotes(ref line1);
                    AddQuotes(ref line2);
                    AddQuotes(ref line3);
                    AddQuotes(ref city);
                    AddQuotes(ref country);
                    AddQuotes(ref altLine1);
                    AddQuotes(ref altLine2);
                    AddQuotes(ref altLine3);
                    AddQuotes(ref altCity);
                    AddQuotes(ref altCountry);
                    
                    #endregion
                    
                    string output = firstName + delimeter + 
                                    lastName + delimeter + 
                 
                                    company + delimeter + 
                                    title + delimeter + 
                 
                                    email + delimeter + 
                 
                                    phone + delimeter + 
                                    altPhone + delimeter + 
                 
                                    type + delimeter + 
                                    line1 + delimeter + 
                                    line2 + delimeter + 
                                    line3 + delimeter + 
                                    city + delimeter + 
                                    state + delimeter + 
                                    zip + delimeter + 
                                    country + delimeter + 
                 
                                    altType + delimeter + 
                                    altLine1 + delimeter + 
                                    altLine2 + delimeter + 
                                    altLine3 + delimeter + 
                                    altCity + delimeter + 
                                    altState + delimeter + 
                                    altZip + delimeter + 
                                    altCountry + delimeter + 
                 
                                    website + delimeter + 
                 
                                    birthday + delimeter +

                                    custom1;
                    writer.WriteLine(output);
                }
            }


            //leave the following
            Console.WriteLine("Done - file location: " + dir + toCreate + " contacts.csv");
        }

        #region helper methods
        
        public static bool IsOdd(int value)
        {
            return value % 2 != 0;
        }

        public static DateTime GenererateRandomBirthdate(int endYear)
        {

            int year = rnd.Next(1940, endYear);
            int month = rnd.Next(1, 12);
            int day = DateTime.DaysInMonth(year, month);

            int Day = rnd.Next(1, day);

            DateTime dt = new DateTime(year, month, Day);
            return dt.Date;
        }

        public static string RemoveDomain(string email)
        {
            string removed;
            int at = email.IndexOf("@");
            int end = email.IndexOf(".", at);
            string remove = email.Substring(at + 1, end - at-1);
            return removed = email.Replace(remove, "");
        }

        public static string RemoveLocal(string email)
        {
            return email = email.Remove(0, email.IndexOf("@"));
        }

        public static void AddQuotes( ref string str)
        {
            if (str.Contains(",") || str.Contains("'")) str = "\"" + str + "\"";
        }

        #endregion
    }
}
