
public record Student(string Name, string Number) : Person(Name);
/*
public class Student : Person
{
    string _number;
    public Student(string name, string number) : base(name)
    {
        _number = number;
    }
    public string Get_Number()
    {
        return _number;
    }
}
*/

