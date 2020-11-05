using System.Collections.Generic;
using System.Linq;
using FinalProjectRegistration.Core.DomainServices;
using FinalProjectRegistration.Core.Entity;

namespace FinalProjectRegistration.Core.ApplicationServices.Services
{
    public class StudentService: IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        
        public List<Student> GetAll()
        {
            return _studentRepository.GetAll().ToList();
        }

        public Student GetById(int id)
        {
            return _studentRepository.GetById(id);
        }

        public void Add(Student s)
        {
            _studentRepository.Add(s);
        }

        public void Update(Student s)
        {
            _studentRepository.Update(s);
        }

        public void Remove(Student s)
        {
            _studentRepository.Remove(s);
        }
    }
}