using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace klasaPerson
{
    public class Person
    {
        private string _familyName;
        public string FamilyName
        {
            get => _familyName;
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Incorrect data for FamilyName");

                if (value.Length < 2)
                    throw new ArgumentException("Incorrect data for FamilyName");

                char[] dane = value.ToCharArray();
                int il = 0;
                for (int i = 0; i < dane.Length; i++)
                {
                    if (dane[i] == '-')
                        il++;
                    if (Char.IsLetter(dane[i]) == false && dane[i] != '-' && dane[i] != ' ')
                        throw new ArgumentException("Incorrect data for FamilyName");
                }

                if (il >= 2)
                    throw new ArgumentException("Incorrect data for FamilyName");
                else
                {
                    string dane1 = value.Trim();
                    if (dane1.Length < 2)
                        throw new ArgumentException("Incorrect data for FamilyName");
                }

                _familyName = value.Trim();
            }
        }

        private string _firstName;
        public string FirstName 
        { 
            get => _firstName; 
            set
            {
                if (value == null || value == "")
                    throw new ArgumentException("Incorrect data for FirstName");

                if (value.Length < 2)
                    throw new ArgumentException("Incorrect data for FirstName");

                char[] dane = value.ToCharArray();
                for (int i = 0; i < dane.Length; i++)
                {
                    if (Char.IsLetter(dane[i]) == false && dane[i] != ' ')
                        throw new ArgumentException("Incorrect data for FirstName");
                }

                    string dane1 = value.Trim();
                    if (dane1.Length < 2)
                        throw new ArgumentException("Incorrect data for FirstName");

                _firstName = value.Trim();
            }
        }

        private DateTime _birthday;
        public DateTime Birthday 
        {
            get => _birthday;
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Incorrect data for Birthday");

                _birthday = value;
            }
        }

        public Person(string familyName, string firstName, DateTime birthday)
        {
            FamilyName = familyName;
            FirstName = firstName;
            Birthday = birthday;
        }

        public override string ToString()
        => $"{FirstName} {FamilyName} ({Birthday:yyyy-MM-dd})";


    }
}
