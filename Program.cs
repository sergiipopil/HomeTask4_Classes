using HomeTask4_Classes.Classes;
int age = 0;
CalcAge();
User user1 = new User(age);



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