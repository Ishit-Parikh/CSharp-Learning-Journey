namespace Section06;

/*
Create a C# program that declares a dictionary where the key is a string and the value is a custom object. The program should:
Define a class Student with properties Id, Name, and Grade.

To be robust across graders that treat warnings as errors, initialize Name to string.Empty (i.e., public string Name { get; set; } = string.Empty;).
Initialize a dictionary with keys as student names and values as Student objects.

Add at least three Student objects to the dictionary.
Iterate through the dictionary and print each student’s details from the object (use student.Name, not the dictionary key).

Print exactly the following three lines, in this order:
Name: John, Id: 1, Grade: 85
Name: Alice, Id: 2, Grade: 90
Name: Bob, Id: 3, Grade: 78
Notes:
• Use Console.WriteLine and ensure you print Name, Id, and Grade from the Student object so the output matches the expected lines exactly.
• The provided unit test captures console output and compares it exactly, including line breaks.
*/


public class Student
{
    public string? Name {get; set;} = string.Empty;
    public int? ID {get; set;}
    public int? Grade {get; set;}
}


public class CodeExe16
{
    public static void Run()
    {
        Student student1 = new Student { Name = "John",ID = 1, Grade = 85 };
        Student student2 = new Student { Name = "Alice",ID = 2, Grade = 90 };
        Student student3 = new Student { Name = "Bob", ID = 3, Grade = 78 };

        Dictionary<string, Student> stds = new Dictionary<string, Student>(); 

        stds.Add(student1.Name, student1);
        stds.Add(student2.Name, student2);
        stds.Add(student3.Name, student3);

        foreach (KeyValuePair<string, Student> kvp in stds)
        {
            Student student = kvp.Value;
            Console.WriteLine($"Name: {student.Name}, Id: {student.ID}, Grade: {student.Grade}");
        }

    }
}