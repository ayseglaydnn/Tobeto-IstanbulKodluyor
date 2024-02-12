using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        public void Add(Course course);
        public void Delete(Course course);
        public void Update(Course course);
        public Course GetByIdCourse(int id);

        public List<Course> GetCourses();
    }
}
