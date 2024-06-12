using System;
using System.Collections.Generic;
using System.Linq;

public class UserAccountLab5
{
    public string name;
    public int rank;
    public float winRate;
    public string type;
    public int skin;

    public UserAccountLab5(string _name, int _rank, float _winRate, string _type, int _skin)
    {
        name = _name;
        rank = _rank;
        winRate = _winRate;
        type = _type;
        skin = _skin;
    }
}

class Program
{
    static void Main()
    {
        
        List<UserAccountLab5> userAccounts = new List<UserAccountLab5>
        {
            new UserAccountLab5("Alice", 5, 65.5f, "Type1", 3),
            new UserAccountLab5("Bob", 2, 70.0f, "Type2", 2),
            new UserAccountLab5("Charlie", 8, 85.0f, "Type1", 1),
            new UserAccountLab5("David", 4, 50.5f, "Type3", 4),
            new UserAccountLab5("Eve", 7, 90.0f, "Type2", 3),
            new UserAccountLab5("Bruce", 3, 77.5f, "Type1", 5),
            new UserAccountLab5("Brian", 6, 80.0f, "Type3", 2)
        };

       
        var typeLookup = userAccounts.ToLookup(u => u.type);

       
        Console.WriteLine("User accounts grouped by Type:");

        foreach (var group in typeLookup)
        {
            Console.WriteLine($"\nType: {group.Key}, Count: {group.Count()}");
            foreach (var user in group)
            {
                Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, WinRate: {user.winRate}, Type: {user.type}, Skin: {user.skin}");
            }
        }
    }
}