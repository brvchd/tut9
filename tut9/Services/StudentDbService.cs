using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using tut9.DTOs.Request;
using tut9.DTOs.Response;
using tut9.Models;

namespace tut9.Services
{
    public class StudentDbService : IStudentDbService
    {
        private s18963Context _context;

        public StudentDbService(s18963Context context)
        {
            _context = context;
        }

        public void DeleteStudent(DeleteStudentRequest request)
        {
            var student = _context.Student.Find(request.IndexNumber);
            if(student == null)
            {
                throw new ArgumentException("Student wasn't found");
            }
            _context.Remove(student);
            _context.SaveChanges();
        }

        public EnrollStudentResponse EnrollStudent(EnrollStudentRequest request)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetStudentList()
        {
            List<Student> StudentList = _context.Student.ToList();
            return StudentList;
            
        }

        public InsertStudentResponse InsertStudent(InsertStudentRequest request)
        {
            throw new NotImplementedException();
        }

        public void ModifyStudent(ModifyStudentRequest request)
        {
            var student = _context.Student.Find(request.IndexNumber);
            student.FirstName = request.FirstName;
            student.LastName = request.LastName;
            student.BirthDate = request.BirthDate;
            _context.SaveChanges();
        }
    }
}
