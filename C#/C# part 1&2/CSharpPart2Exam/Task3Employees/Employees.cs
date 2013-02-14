using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Dictionary<string, int> posit = new Dictionary<string, int>();
        for (int i = 0; i < n; i++)
        {
            string[] temp = Console.ReadLine().Split('-');
            if (posit.ContainsKey((temp[0].Trim()))) continue;
            posit.Add(temp[0].Trim(), int.Parse(temp[1]));
        }
        int m = int.Parse(Console.ReadLine());
        Employee[] sortedNames = new Employee[m];

        for (int i = 0; i < m; i++)
        {
            string[] temp = Console.ReadLine().Split('-');
            string[] names = temp[0].Split(' ');

            sortedNames[i] = new Employee(names[0].Trim(), names[1].Trim(), Rank(temp[1].Trim(), posit));
        }
        Array.Sort(sortedNames);
        foreach (var item in sortedNames)
        {
            Console.WriteLine(item);
        }
    }

    private static int Rank(string name, Dictionary<string, int> T)
    {
        int value = -1;
        T.TryGetValue(name, out value);
        return value;
    }
}
public class Employee : IComparable<Employee>
{
    string firstName;
    public string FirstName { get; set; }

    string lastName;
    public string LastName { get; set; }

    int rank;
    public int Rank { get; set; }

    public Employee(string fname, string lastname, int rank)
    {
        firstName = fname;
        lastName = lastname;
        this.rank = rank;
    }

    public int CompareTo(Employee other)
    {
        if (this.rank > other.rank)
        {
            return -1;
        }
        else if (this.rank == other.rank)
        {
            if (this.lastName.CompareTo(other.lastName) < 0)
            {
                return -1;
            }
            else if (this.lastName.CompareTo(other.lastName) == 0)
            {
                return this.firstName.CompareTo(other.firstName);
            }
            else
            {
                return 1;
            }
        }
        else
        {
            return 1;
        }
    }
    public override string ToString()
    {
        return (firstName + " " + lastName);
    }
}
