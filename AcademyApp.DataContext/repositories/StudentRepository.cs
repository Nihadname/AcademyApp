using AcademyApp.DataContext.Interfaces;
using AcademyApp.Domain.Models;


namespace AcademyApp.DataContext.repositories
{
    public class StudentRepository : Irepository<Student>
    {
        public bool Create(Student entity)
        {
            try
            {
                
                DbContext.Students.Add(entity);
                return true;
            }
            catch(Exception) {
                throw;
            
            }
        }

        public bool Delete(Student entity)
        {
            try { 
                
                DbContext.Students.Remove(entity);
                return true;
            }catch(Exception)
            {
                throw;
            }
   
        }

        public Student Get(Predicate<Student> filter)
        {
            return DbContext.Students.Find(filter);
        }

        public List<Student> GetAll(Predicate<Student> filter = null)
        {
           return filter is null?DbContext.Students:DbContext.Students.FindAll(filter);
        }

        public bool Update(Student entity)
        {
            try
            {
                var ExistStudent=Get(s=>s.Id==entity.Id);
                ExistStudent = entity;
                return true;

            }catch(Exception)
            {
                throw;
            }
        }
    }
}
