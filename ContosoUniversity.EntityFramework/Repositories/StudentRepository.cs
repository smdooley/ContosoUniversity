using ContosoUniversity.Core.Models;
using ContosoUniversity.Core.Repositories;
using ContosoUniversity.EntityFramework.Infrastructure;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContosoUniversity.EntityFramework.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private SchoolContext context;

        public StudentRepository()
        {
            context = new SchoolContext();
        }

        public StudentRepository(SchoolContext context)
        {
            this.context = context;
        }

        public IEnumerable<Core.Models.Student> Get()
        {
            return context.Students.ToList();
        }

        public Core.Models.Student Get(int id)
        {
            return context.Students.Find(id);
        }

        public void Insert(Core.Models.Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }

        public void Delete(int id)
        {
            Student student = context.Students.Find(id);
            context.Students.Remove(student);
            
            //context.Entry(student).State = EntityState.Deleted;
            //context.SaveChanges();
        }

        public void Update(Core.Models.Student student)
        {
            context.Entry(student).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void Save()
        {
            context.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if(!this.disposed)
            {
                if(disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
