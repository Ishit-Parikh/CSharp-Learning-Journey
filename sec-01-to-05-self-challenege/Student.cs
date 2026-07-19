namespace Challenge;

public class Student
{
    public string Name { get; set; }
    public int[] Grades { get; set; }

    public Student(string name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public double CalculateAverage()
    {
        int marksTotal = 0;
        foreach (int grade in Grades)
        {
            marksTotal += grade;
        }

        return Grades.Length == 0 ? 0.0 : (double)marksTotal / Grades.Length;
    }
}