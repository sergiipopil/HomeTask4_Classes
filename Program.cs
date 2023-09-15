using HomeTask4_Classes.Classes;
using HomeTask4_Classes.Enums;
using System;
using System.Xml.Linq;

//init age
int age = 0;

//call method to calc age from user birth year
SetAge();

User user1 = new User(age);

user1.Gender = GetUserGenderType();
user1.FirstName= GetUserFirstAndLastName("First Name");
user1.LastName= GetUserFirstAndLastName("Last Name");

//Show all user data
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine();
Console.WriteLine(user1.ToString());
Console.ResetColor();



#region Method to get User FirstName And LastName, parameter NameType will show in console
string GetUserFirstAndLastName(string nameType) {
    string input = string.Empty;
    while (true)
    {
        Console.Write($"\nPlease enter your {nameType}:");
        input = Console.ReadLine();
        if (!string.IsNullOrEmpty(input) && input.All(char.IsLetter))
        {
            break;
        }
    }
    return input;
}
#endregion
#region Method to get Gender enum type
GenderType GetUserGenderType()
{
    GenderType gender = GenderType.None;
    while (true)
    {
        Console.Write("\nPlease enter your gender - Male or Female:");
        string genderType = Console.ReadLine();
        Enum.TryParse(genderType, true, out gender);
        bool isMatch = Enum.IsDefined(typeof(GenderType), gender);
        if (isMatch && gender != GenderType.None)
        {
            break;
        }
    }
    return gender;
}
#endregion
#region Methods to get birth date and calculate user age
void SetAge()
{
    try
    {
        CalcAge();
    }
    catch
    {
        Console.Write("\n!!! Please enter only digits !!!\n");
        SetAge();
    }
}
void CalcAge()
{
    while (age <= 0 || age > 100)
    {
        Console.Write("Please enter your birth year(only by numbers in format XXXX):");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        age = DateTime.Now.Year - birthYear;
    }
}
#endregion