using GraphQLMutationBasicCRUD.Excep;
using GraphQLMutationBasicCRUD.IService;
using GraphQLMutationBasicCRUD.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLMutationBasicCRUD.Service
{
    public class StudentService : IStudentService
    {
        private IList<Student> _students;
        public StudentService()
        {
            _students = new List<Student>()
            {
                new Student() {StudentId = 1, Name = "Anirudh", GroupId =1},
                new Student() {StudentId = 1, Name = "Arnav", GroupId =2},
                new Student() {StudentId = 1, Name = "Rohit", GroupId =3},
                new Student() {StudentId = 1, Name = "Mohit", GroupId =1},
            };
        }
        public Student Create(CreateStudentInput inputStudent)
        {
            var student = new Student()
            {
                StudentId = _students.Max(x => x.StudentId) + 1,
                Name = inputStudent.Name,
                GroupId = inputStudent.GroupId
            };
            _students.Add(student);
            return student;
        }

        public Student Delete(DeleteStudentInput inputStudent)
        {
            var student = _students.FirstOrDefault(x => x.StudentId == inputStudent.StudentId);
            if (student == null) throw new StudentNotFoundException() { StudentId = inputStudent.StudentId };
            _students.Remove(student);
            return student;
        }

        public IQueryable<Student> GetAll()
        {
            return _students.AsQueryable();
        }
    }
}
