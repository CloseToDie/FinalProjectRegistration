using System.Collections.Generic;
using FinalProjectRegistration.Core.DomainServices;
using FinalProjectRegistration.Core.Entity;

namespace FinalProjectRegistration.InfraStructure.Data
{
    public class StudentRepository: IStudentRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return FakeDb.Students;
        }

        public Student GetById(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Add(Student s)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Student s)
        {
            throw new System.NotImplementedException();
        }

        public void Remove(Student s)
        {
            throw new System.NotImplementedException();
        }
    }
}