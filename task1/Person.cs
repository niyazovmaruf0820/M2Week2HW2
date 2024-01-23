namespace task1;

public class Person
{
    public string FirstName{get; set;}
    public string LastName{get; set;}
    public int Age{get; set;}
    public string Address{get; set;}
    public string GetFullName()
    {
        return $"{FirstName} {LastName}";
    }
    public int GetBirthYear()
    {
        return 2024 - Age;
    }
}
