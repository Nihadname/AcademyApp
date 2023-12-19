using AcademyApp.Business.interfaces;
using AcademyApp.DataContext.repositories;
using AcademyApp.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyApp.Business.Services
{
    public class StudentService : IStudent
    {
        private readonly StudentRepository _studentRepository;
        private readonly GroupRepository _groupRepository;
        private static int Count = 1;
        public StudentService()
        {
            _studentRepository = new StudentRepository();
            _groupRepository = new GroupRepository();
        }
        public Student Create(Student student, string groupName)
        {
            var ExistGroup = _groupRepository
                .Get(g => g.Name.Equals(groupName, StringComparison.OrdinalIgnoreCase));
            if (ExistGroup is null) return null;
            student.Id = Count; 
            student.group = ExistGroup;
           bool result= _studentRepository.Create(student);
            if (!result) return null;
            Count++;
            return student;
        }

        public Student Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Student Get(int id)
        {
            throw new NotImplementedException();
        }

        public List<Student> GetAll()
        {
           return _studentRepository.GetAll();
        }

        public List<Student> GetAll(string name)
        {
          return _studentRepository.GetAll(s=>s.Name.ToLower()==name.ToLower());
        }

        public List<Student> GetAll(int age)
        {
        return _studentRepository.GetAll(s=>s.Age==age);
        }

        public Student Uptade(int id, Student student, string groupName)
        {
            throw new NotImplementedException();
        }
    }
}
