namespace Challenge;

public class User
{
    private Student[] _students;
    private int _count;

    public User(int capacity)
    {
        if (capacity <= 0)
            throw new ArgumentException("Capacity must be a positive number.", nameof(capacity));
        _students = new Student[capacity];
        _count = 0;
    }

    public void UserOperations()
    {
        bool running = true;
        while (running)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Welcome, please select the number that corresponds to the operation that you want to perform: ");
            Console.WriteLine("1.  Add Student");
            Console.WriteLine("2.  Add Grades to a student");
            Console.WriteLine("3.  See Student Report Card");
            Console.WriteLine("4.  Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int userChoice))
            {
                Console.ResetColor();
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }
            Console.ResetColor();

            switch (userChoice)
            {
                case 1:
                    AddStudentFlow();
                    break;

                case 2:
                    AddGradesFlow();
                    break;

                case 3:
                    ShowReportCards();
                    break;

                case 4:
                    running = false;
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please select 1-4.");
                    break;
            }
        }
    }

    private void AddStudentFlow()
    {
        if (_count >= _students.Length)
        {
            Console.WriteLine("Student list is full. Cannot add more students.");
            return;
        }

        Console.WriteLine("You chose to add a student record");
        Console.Write("Please enter name of the student: ");
        string? name = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }

        Console.Write("How many subjects of grade do you want to enter: ");
        if (!int.TryParse(Console.ReadLine(), out int subjectCount) || subjectCount <= 0)
        {
            Console.WriteLine("Invalid subject count.");
            return;
        }

        int[] grades = new int[subjectCount];
        for (int i = 0; i < subjectCount; i++)
        {
            Console.Write($"Enter numeric grade for Subject {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Invalid grade. Setting to 0.");
                grade = 0;
            }
            grades[i] = grade;
        }

        _students[_count] = new Student(name, grades);
        _count++;
        Console.WriteLine("Student added successfully!\n");
    }

    private void AddGradesFlow()
    {
        if (_count == 0)
        {
            Console.WriteLine("No student records exist. Please add a student first.");
            return;
        }

        Console.Write("Enter the name of the student to add grades to: ");
        string? targetName = Console.ReadLine();

        Student? found = null;
        for (int i = 0; i < _count; i++)
        {
            if (_students[i].Name.Equals(targetName, StringComparison.OrdinalIgnoreCase))
            {
                found = _students[i];
                break;
            }
        }

        if (found == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write("How many new grades do you want to add: ");
        if (!int.TryParse(Console.ReadLine(), out int newCount) || newCount <= 0)
        {
            Console.WriteLine("Invalid count.");
            return;
        }

        int[] oldGrades = found.Grades;
        int[] newGrades = new int[oldGrades.Length + newCount];
        for (int i = 0; i < oldGrades.Length; i++)
        {
            newGrades[i] = oldGrades[i];
        }
        for (int i = 0; i < newCount; i++)
        {
            Console.Write($"Enter new grade {i + 1}: ");
            if (!int.TryParse(Console.ReadLine(), out int grade))
            {
                Console.WriteLine("Invalid grade. Setting to 0.");
                grade = 0;
            }
            newGrades[oldGrades.Length + i] = grade;
        }

        found.Grades = newGrades;
        Console.WriteLine("Grades added successfully!\n");
    }

    private void ShowReportCards()
    {
        if (_count == 0)
        {
            Console.WriteLine("No student records exist. Please add a student first.");
            return;
        }

        Console.WriteLine("Student Report Cards");
        for (int i = 0; i < _count; i++)
        {
            Student s = _students[i];
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("======================");
            Console.WriteLine($"Name: {s.Name}");
            Console.WriteLine("======================");
            Console.ResetColor();

            for (int j = 0; j < s.Grades.Length; j++)
            {
                Console.WriteLine($"Marks for Subject {j + 1}: {s.Grades[j]}");
            }

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"{s.Name}'s Average marks are {s.CalculateAverage():F2}\n");
            Console.ResetColor();
        }
    }
}