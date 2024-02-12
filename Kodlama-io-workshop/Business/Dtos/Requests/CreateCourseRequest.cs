using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Dtos.Requests
{
    public class CreateCourseRequest
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Trainer { get; set; }
        public string Category { get; set; }
    }
    public class DeleteCourseRequest
    {
        public int Id { get; set; }
    }
    public class UpdateCourseRequest
    {
        public string CourseName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string Trainer { get; set; }
        public string Category { get; set; }
    }
}
