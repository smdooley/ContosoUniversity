using AutoMapper;
using ContosoUniversity.Application.DTOs;
using ContosoUniversity.Core.Models;
using ContosoUniversity.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Application.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IEnumerable<StudentDto> Get()
        {
            return Mapper.Map<IEnumerable<Student>, IEnumerable<StudentDto>>(_studentRepository.Get());
        }

        public StudentDto Get(int id)
        {
            return Mapper.Map<Student, StudentDto>(_studentRepository.Get(id));
        }

        public void Insert(StudentDto item)
        {
            Student student = Mapper.Map<StudentDto, Student>(item);
            _studentRepository.Insert(student);
        }

        public void Delete(int id)
        {
            _studentRepository.Delete(id);
        }

        public void Update(StudentDto item)
        {
            Student student = Mapper.Map<StudentDto, Student>(item);
            _studentRepository.Update(student);
        }

        public void Save()
        {
            _studentRepository.Save();
        }
    }
}
