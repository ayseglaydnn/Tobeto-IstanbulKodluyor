using Kodlama_Io_WorkShop.Business.Abstracts;
using Kodlama_Io_WorkShop.Business.Dtos.Requests;
using Kodlama_Io_WorkShop.Business.Dtos.Responses;
using Kodlama_Io_WorkShop.DataAccess.Abstracts;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Concretes
{
    public class CourseManager : ICourseService
    {
        ICourseDal _courseDal;
        public CourseManager(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }
        public void Add(CreateCourseRequest course)
        {
            Course courseToCreate = new();
            courseToCreate.CourseName = course.CourseName;
            _courseDal.Add(courseToCreate);
        }



        public List<GetAllCourseResponse> GetCourses()
        {
            List<GetAllCourseResponse> course = new List<GetAllCourseResponse>();

            foreach (var item in _courseDal.GetCourses())
            {
                GetAllCourseResponse getAllCourseResponse = new GetAllCourseResponse();
                getAllCourseResponse.CourseName = item.CourseName;
                getAllCourseResponse.CourseName = item.CourseName;
                course.Add(getAllCourseResponse);
            }
            return course;
        }
        public void Delete(int courseId)
        {
            Course deleteToCourse = _courseDal.GetByIdCourse(courseId);
            if (deleteToCourse != null)
            {
                _courseDal.Delete(deleteToCourse);
            }
            else
            {
                // Handle category not found error
                throw new Exception("Course not found");
            }
        }

        public void Update(int courseId, UpdateCourseRequest course)
        {
            Course updateToCourse = _courseDal.GetByIdCourse(courseId);
            if (updateToCourse != null)
            {
                updateToCourse.CourseName = course.CourseName;
                _courseDal.Update(updateToCourse);
            }
            else
            {
                // Handle category not found error
                throw new Exception("Course not found");
            }
        }

   
    }
}
