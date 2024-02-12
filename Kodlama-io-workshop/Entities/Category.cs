using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Entities
{
    public class Category
    {
        public Category()
        {
           
        }

        public Category(int id, string categoryName)
        {
            CategoryId = id;
            CategoryName = categoryName;
        }

        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public List<Course> Course { get; set; }


    }
}
