using System;
using System.Collections.Generic;
using System.Text;

partial class Person
{
    string Name;
    int Age;
}

partial class Person
{
    public void Print(string name, int age)
    {
        Name = name;
        Age = age;
        Console.WriteLine($"{Name}: {Age}");
    }
}