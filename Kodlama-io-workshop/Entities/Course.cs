using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Entities
{
    public class Course
    {
        public Course()
        {

        }

        public Course(int courseId, string courseName,
            int complete, string description,
            decimal price)
        {
            CourseId = courseId;
            CourseName = courseName;
            Complete = complete;
            Description = description;
            Price = price;

        }

        public int CourseId { get; set; }
        public string CourseName { get; set; }
        public int Complete { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public decimal DiscountedRate => Price - (Price * DiscountedRate / 100);
        public Trainer Trainer { get; set; }
        public Category Category { get; set; }
        
    }
}
