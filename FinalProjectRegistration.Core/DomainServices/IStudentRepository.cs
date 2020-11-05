using System.Collections.Generic;
using FinalProjectRegistration.Core.Entity;

namespace FinalProjectRegistration.Core.DomainServices
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAll(); 
        Student GetById(int id);
        void Add(Student s);
        void Update(Student s);
        void Remove(Student s);
    }
}