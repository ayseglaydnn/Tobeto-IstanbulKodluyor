using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Dtos.Responses
{
    public class GetAllCourseResponse
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Complete { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Trainer { get; set; }
        public string Category { get; set; }
    }
}
