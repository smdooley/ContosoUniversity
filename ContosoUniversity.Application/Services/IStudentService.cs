using ContosoUniversity.Application.DTOs;
using ContosoUniversity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Application.Services
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
