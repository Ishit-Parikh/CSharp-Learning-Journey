using System.Windows.Markup;

namespace Challenge;

public class Student
{
    private string _name;
    private int[] _grades;

    public string Name
    {
        get => _name;
        set => _name = value;
    }

    public int[] Grades
    {
        get => _grades;
    }

    public Student(string name, int[] grades)
    {
        this._name = name;
        this._grades = grades;
    }

    public double CalculateAverag()
    {
        double average = 0;

        int marksTotal = 0;
        foreach(int grade in _grades)
        {
            marksTotal += grade;
        }

        return average = marksTotal/_grades.Length;
    }
}