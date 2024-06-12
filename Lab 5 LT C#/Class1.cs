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
        // a/ Create a list of UserAccountLab5 with more than 5 items
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

        // b/  Sắp xếp danh sách UserAccount theo “Rank” giảm dần 
        List<UserAccountLab5> sortedByRank = userAccounts.OrderByDescending(u => u.rank).ToList();

        // c/  Sắp xếp danh sách UserAccount theo “Name” và “Skin” giảm dần
        List<UserAccountLab5> sortedByNameAndSkin = userAccounts.OrderByDescending(u => u.name).ThenByDescending(u => u.skin).ToList();

        // d/ / Liệt kê danh sách các người có Name bắt đầu bằng ký tự “B”
        List<UserAccountLab5> namesStartingWithB = userAccounts.Where(u => u.name.StartsWith("B")).ToList();

        // Output the original list
        Console.WriteLine(" List:");
        DisplayUserAccounts(userAccounts);

        // Output the list sorted by Rank
        Console.WriteLine("\ndanh sách UserAccount theo “Rank” giảm dần :");
        DisplayUserAccounts(sortedByRank);

        // Output the list sorted by Name and Skin
        Console.WriteLine("\ndanh sách UserAccount theo “Name” và “Skin” giảm dần:");
        DisplayUserAccounts(sortedByNameAndSkin);

        // Output the list of users whose names start with "B"
        Console.WriteLine("\ndanh sách các người có Name bắt đầu bằng ký tự “B”:");
        DisplayUserAccounts(namesStartingWithB);
    }

    static void DisplayUserAccounts(List<UserAccountLab5> userAccounts)
    {
        foreach (var user in userAccounts)
        {
            Console.WriteLine($"Name: {user.name}, Rank: {user.rank}, WinRate: {user.winRate}, Type: {user.type}, Skin: {user.skin}");
        }
    }
}