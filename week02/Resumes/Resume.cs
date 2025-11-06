
using System.ComponentModel.DataAnnotations;

public class Resume
{

    string _name = "Allison Rose";
    List<Job> _job;

    public Resume()
    {
        _job = new List<Job>();
    }
    public void Display()
    {
        Console.WriteLine($"Name : {_name}");
        Console.WriteLine($"Jobs : ");
    }

}
