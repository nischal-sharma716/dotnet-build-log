using System;
class Student
{
    private int id;
    private string name;
    private int age;

    public int Id
    {
        get => id;
        set
        {
            if (value <= 0) throw new ArgumentException("Id must be positive.");
            id = value;
        }
    }

    public string Name
    {
        get => name;
        set
        {
            if (string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Name cannot be empty.");
            name = value;
        }
    }

    public int Age
    {
        get => age;
        set
        {
            if (value <= 0) throw new ArgumentException("Age must be positive");
            age = value;
        }
    }
}