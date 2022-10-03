/*
 * Simple code to debug.
 * There's a logic error!
 * The output should be 77.83 but it's not
 * Bill Nicholson
 * nicholdw@ucmail.uc.edu
 */

int[] grades = { 100, 95, 95, 77, 100, 0 };
double averageGrade;
int total = 0;

foreach (int grade in grades)
{
    total = total + grade;
}
Console.WriteLine(total);
averageGrade = total / grades.Length;
Console.WriteLine("Average Grade = " + averageGrade);  // Why isn't this 77.83?