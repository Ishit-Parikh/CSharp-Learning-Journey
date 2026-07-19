using System.Linq;

namespace Challenge;

public class User
{
    private Student[] _students;

    public User(Student[] students)
    {
        this._students = students;
    }

    public void UserOperations()
    {
        bool isTrue = true;
        while(isTrue)
        {
            int userChoice = 0;
            Console.ForegroundColor = ConsoleColor.Gray;
            System.Console.WriteLine("Welcome, please select the number that corresponds to the operation that you want to perform: ");
            System.Console.WriteLine("1.  Add Student");
            System.Console.WriteLine("2.  Add Grades to a student");
            System.Console.WriteLine("3.  See Student Report Card");
            System.Console.WriteLine("4.  Exit");
            System.Console.Write("Enter your choice: ");
            bool isInt = int.TryParse(Console.ReadLine(), out userChoice);
            Console.ResetColor();
            if (isInt)
            {
                if (userChoice == 1)
                {
                    string? name = null;
                    int subjectCount;
                    System.Console.WriteLine("You chose to add a student record");
                    System.Console.Write("Please enter name of the student: ");
                    name = Console.ReadLine();
                    System.Console.Write("How many subjects of grade do you want to enter: ");
                    int.TryParse(Console.ReadLine(), out subjectCount);
                    int[] grades = new int[subjectCount];
                    for(int i = 0; i < subjectCount; i++)
                    {
                        int grade = 0;
                        System.Console.Write($"Enter numeric grades for Subject {i + 1}: ");
                        int.TryParse(Console.ReadLine(), out grade);
                        grades[i] = grade;
                    }
                    AddStudentRecord(name, grades);
                    UserOperations();
                }

                else if(_students.Length == 0)
                {
                    System.Console.WriteLine("No student record exists. Please enter some records.");
                }

                else
                {
                    switch (userChoice)
                    {
                        case 2:
                            System.Console.WriteLine("You chose 2");
                            break;

                        case 3:
                            System.Console.WriteLine("You want to see the reports of students");
                            foreach (var student in _students)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                System.Console.WriteLine("======================");
                                System.Console.WriteLine($"Name: {student.Name}");
                                System.Console.WriteLine("======================");
                                System.Console.WriteLine("");
                                for(int i = 0; i < student.Grades.Length; i++)
                                {
                                    System.Console.WriteLine($"Marks for Subject{i+1}: {student.Grades[i]}");
                                }
                                Console.ForegroundColor = ConsoleColor.Blue;
                                double average = student.CalculateAverag();
                                System.Console.WriteLine($"{student.Name}'s Average marks are {average}");
                            }
                            break;

                        case 4:
                            isTrue = false;
                            break;

                        default:
                            System.Console.WriteLine("Invlaid choice");
                            UserOperations();
                            break;           
                    }
                }
            }
        }
    }

    private void AddStudentRecord(string Name, int[] Grades)
    {
        _students = _students.Concat(
            new Student[] 
            {
                new Student(Name, Grades)
            }).ToArray(); 
    }
}