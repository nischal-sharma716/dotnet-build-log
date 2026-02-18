using _02_StudentManager_LINQ.Services;

class Program
{
    static void Main()
    {
        StudentService service = new StudentService();
        service.ShowAll();
    }
}