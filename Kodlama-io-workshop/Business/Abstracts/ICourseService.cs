using Kodlama_Io_WorkShop.Business.Dtos.Requests;
using Kodlama_Io_WorkShop.Business.Dtos.Responses;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Abstracts
{
    public interface ICourseService
    {
        public void Add(CreateCourseRequest course);
        public List<GetAllCourseResponse> GetCourses();
        public void Delete(int courseId);
        public void Update(int courseId, UpdateCourseRequest course);




    }
}
