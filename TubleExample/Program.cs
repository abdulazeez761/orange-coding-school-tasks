var person = Tuple.Create(1, "Steve", "Jobs");
Console.WriteLine(person);
Console.WriteLine(person.Item1);
Console.WriteLine(person.Item2);
Console.WriteLine(person.Item3);


var person2 = (id: 1, name: "Bill");
Console.WriteLine(person2.id);
Console.WriteLine(person2.name);

(int Id, string FirstName, string LastName) person3 = (1, "Bill", "Gates");



static (int, string, string) GetPerson()
{
    return (Id: 3, FirstName: "khalid", LastName: "Gates");
}
(var PersonId, var FName, var LName) = GetPerson();

Console.WriteLine($"PersonId: {PersonId}");
Console.WriteLine($"lastName: {LName}");