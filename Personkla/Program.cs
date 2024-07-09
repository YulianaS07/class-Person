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

            string[] dane = value.Trim().Split("-");
            if (dane.Length > 2)
                throw new ArgumentException("Incorrect data for FamilyName");

            if (value.Length < 2)
                throw new ArgumentException("Incorrect data for FamilyName");

            _familyName = value;
        }
    }

    public string FirstName { get; set; }
    public DateTime Birthday { get; set; }

    public Person(string familyName, string firstName, DateTime birthday)
    {
        FamilyName = familyName;
        FirstName = firstName;
        Birthday = birthday;
    }

    public override string ToString()
    => $"{FirstName} {FamilyName} ({Birthday:yyyy-MM-dd})";

}