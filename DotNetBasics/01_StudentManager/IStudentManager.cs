using System.Collections.Generic;
interface IStudentManager
{
    void AddStudent(Student student);
    void ViewStudents();
    Student? FindStudent(int id);

    bool DeleteStudent(int id);
    bool UpdateStudent(int id, string newName, int newAge);
    List<Student> SearchStudents(string namePart);
}