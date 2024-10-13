using System;
using SampleSecuredWeb.Models;

namespace SampleSecuredWeb.Data;

public interface IStudent
{
    IEnumerable<Student> GetStudents();
    Student GetStudent(string nim);
    Student AddStudent (Student student);
    Student UpdateStudent (Student student);
    void DeleteStudent (string nim);   

}
