using System.Collections.Generic;
using FinalProjectRegistration.Core.Entity;

namespace FinalProjectRegistration.Core.ApplicationServices
{
    public interface IStudentService
    {
        List<Student> GetAll(); 
        Student GetById(int id);
        void Add(Student s);
        void Update(Student s);
        void Remove(Student s);
    }
}