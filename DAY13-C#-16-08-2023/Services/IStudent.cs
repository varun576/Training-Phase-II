using JwtAuth.Models;

namespace JwtAuth.Services
{
    public interface IStudent
    {
        Task<List<Student>> GetAllStudents(); // interface can be given without access specifier

        Task<Student> GetStudentByRollno(int id);

        Task<Student> AddStudent(Student student);

        Task<Student> UpdateStudent(int rollno, Student student);

        Task<List<Student>> DeleteStudent(int rollno);
    }
}
