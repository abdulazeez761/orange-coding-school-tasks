namespace model.HrClassLib;

public abstract class Person
{
    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public DateOnly BirthDate { get; private set; }

    public void SetBirthDate(DateOnly date)
    {
        if (date < new DateOnly(1880, 9, 10))
            throw new ArgumentException("invalid date yasta");

        BirthDate = date;

    }
    public void SetName(string firstName, string lastName)
    {
        if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))

            throw new WrongName("first name and last name must be included");

        FirstName = firstName;
        LastName = lastName;

    }
}
