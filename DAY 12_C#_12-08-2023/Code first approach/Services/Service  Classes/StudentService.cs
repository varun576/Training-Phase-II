using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentDetailsCF.Context;
using StudentDetailsCF.Exceptions;
using StudentDetailsCF.Models;
using StudentDetailsCF.Services.Interfaces;

namespace StudentDetailsCF.Services.Service__Classes
{
    public class StudentService : IStudent
    {
        public StudentContext? _studentContext;

        public StudentService(StudentContext? studentContext)
        {
            _studentContext = studentContext;
        }

        public async Task<Student> AddStudent(Student student)
        {
            _studentContext.Students.Add(student);
            await _studentContext.SaveChangesAsync();
            Student? rstudent = await _studentContext.Students.FindAsync(student.Rollno);
            return rstudent;
        }

        async Task<List<Student>> IStudent.DeleteStudent(int rollno)
        {
            var deletedstudent = await _studentContext.Students.FindAsync(rollno);
            if (deletedstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.ExecptionMessages[1]);
            }
            _studentContext.Students.Remove(deletedstudent);
            await _studentContext.SaveChangesAsync();
            List<Student> students = await _studentContext.Students.ToListAsync();
            return students;
        }

        public async Task<List<Student>> GetAllStudents()
        {
            var response = await _studentContext.Students.ToListAsync();
            if (response == null)
            {
                throw new Exception(StudentDetailsExceptions.ExecptionMessages[0]);
            }
            return response;
        }

        public async Task<Student> GetStudentByRollno(int id)
        {
            var student = await _studentContext.Students.FindAsync(id);
            if(student == null)
            {
                throw new Exception(StudentDetailsExceptions.ExecptionMessages[3]);
            }
             return student;
        }

        public async Task<Student> UpdateStudent(int rollno,Student student)
        {
            Student? rstudent = await _studentContext.Students.FindAsync(rollno);
            if (rstudent == null)
            {
                throw new Exception(StudentDetailsExceptions.ExecptionMessages[2]);
            }
            rstudent.Stuname = student.Stuname;
            rstudent.Addr = student.Addr;
            rstudent.Phno = student.Phno;
            await _studentContext.SaveChangesAsync();
            rstudent = await _studentContext.Students.FindAsync(rollno);
            return rstudent;
        }
    }
}
