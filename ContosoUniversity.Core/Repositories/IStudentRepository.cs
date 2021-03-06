﻿using ContosoUniversity.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.Core.Repositories
{
    public interface IStudentRepository : IDisposable
    {
        IEnumerable<Student> Get();
        Student Get(int id);
        void Insert(Student student);
        void Delete(int id);
        void Update(Student student);
        void Save();
    }
}
