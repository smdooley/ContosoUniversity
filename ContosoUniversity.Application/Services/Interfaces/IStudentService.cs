using ContosoUniversity.Application.DTOs;
using System.Collections.Generic;

namespace ContosoUniversity.Application.Services.Interfaces
{
    public interface IStudentService
    {
        IEnumerable<StudentDto> Get();
        StudentDto Get(int id);
        void Insert(StudentDto item);
        void Delete(int id);
        void Update(StudentDto item);
        void Save();
    }
}
