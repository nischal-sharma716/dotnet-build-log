using _02_StudentManager_LINQ.Services;

class Program
{
    static void Main()
    {
        StudentService service = new StudentService();

        Console.WriteLine("\nAll Students:");
        service.ShowAll();

        Console.WriteLine("\nStudents older than 20:");
        service.ShowOlderThan20();

        Console.WriteLine("\nFind Students names 'Ram':");
        service.FindByName("Ram");

        Console.WriteLine("\nSort by GPA descending:");
        service.SortByGPA();

        Console.WriteLine("\nCheck if any high performer exists:");
        service.CheckHighPerformer();

        Console.WriteLine("\nCount students above 3.5 GPA:");
        service.CountGoodStudents();
    }
}