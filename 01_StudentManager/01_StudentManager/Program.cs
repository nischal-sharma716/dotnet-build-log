using System;
class Program
{
    static void Main()
    {
        IStudentManager studentManager = new StudentManager();
        int choice = 0;

        while (choice != 6)
        {
            Console.WriteLine("\n--- Student Manager---");
            Console.WriteLine("1. Add Student");
            Console.WriteLine("2. View Students");
            Console.WriteLine("3. Update Student");
            Console.WriteLine("4. Delete Student");
            Console.WriteLine("5. Search Student");
            Console.WriteLine("6. Exit");
            Console.WriteLine("Enter Choice: ");

            if (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Invalid input. Try again.");
                continue;
            }

            switch (choice)
            {
                case 1:
                    AddStudentUI(studentManager);
                    break;
                case 2:
                    studentManager.ViewStudents();
                    break;
                case 3:
                    UpdateStudentUI(studentManager);
                    break;
                case 4:
                    DeleteStudentUI(studentManager);
                    break;
                case 5:
                    SearchStudentUI(studentManager);
                    break;
                case 6:
                    Console.WriteLine("Exiting program...");
                    break;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
        }
    }

    static void AddStudentUI(IStudentManager manager)
    {
        try
        {
            Console.WriteLine("Enter ID: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Age: ");
            int age = int.Parse(Console.ReadLine());

            var student = new Student { Id = id, Name = name, Age = age };
            manager.AddStudent(student);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

    }

    static void UpdateStudentUI(IStudentManager manager)
    {
        try
        {
            Console.WriteLine("Enter ID of student to update: ");
            int id = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter new Name: ");
            string name = Console.ReadLine();

            Console.WriteLine("Enter new Age: ");
            int age = int.Parse(Console.ReadLine());

            if (manager.UpdateStudent(id, name, age))
                Console.WriteLine("Student updated successfully.");
            else
                Console.WriteLine("Student not found or invalid data.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();

    }

    static void DeleteStudentUI(IStudentManager manager)
    {
        Console.WriteLine("Enter ID of student to delete: ");
        int id = int.Parse(Console.ReadLine());

        var student = manager.FindStudent(id);
        if (student == null)
        {
            Console.WriteLine("Student not found.");
            return;
        }

        Console.Write($"Are you sure you want to delete {student.Name}? (Y/N)");
        var confirm = Console.ReadLine()?.ToUpper();
        if (confirm !="Y")
        {
            Console.WriteLine("Delete cancelled.");
            return;
        }

        if (manager.DeleteStudent(id))
            Console.WriteLine("Student deleted Successfully.");

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }

    static void SearchStudentUI(IStudentManager manager)
    {
        Console.WriteLine("Enter name to search: ");
        string query = Console.ReadLine()!;

        var results = manager.SearchStudents(query);
        if (results.Count == 0)
        {
            Console.WriteLine("No matching students found.");
            return;
        }

        Console.WriteLine("\n---Search Results---");
        foreach(var s in results)
        {
            Console.WriteLine($"{s.Id} - {s.Name} - {s.Age}"); 
        }

        Console.WriteLine("\nPress Enter to return to the main menu...");
        Console.ReadLine();
    }

}