using HomeTask4_Classes.Classes;
using HomeTask4_Classes.Enums;
using System;

//init age
int age = 0;

//init genderType


//call method to calc age from user birth year
CalcAge();

User user1 = new User(age);
user1.Gender = GetUserGenderType();
Console.WriteLine(user1.Gender);

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
void CalcAge()
{
    try
    {
        GetAge();
    }
    catch
    {
        Console.Write("\n!!! Please enter only digits !!!\n");
        CalcAge();
    }
}
void GetAge()
{
    while (age <= 0 || age > 100)
    {
        Console.Write("Please enter your birth year(only by numbers in format XXXX):");
        int birthYear = Convert.ToInt32(Console.ReadLine());
        age = DateTime.Now.Year - birthYear;
    }
}
#endregion