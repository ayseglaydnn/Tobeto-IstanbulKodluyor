using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Dtos.Requests
{
    public class CreateCategoryRequest
    {
        public string Name { get; set; }

    }
    public class DeleteCategoryRequest
    {
        public int Id { get; set; }

    }
    public class UpdateCategoryRequest
    {
        public string Name { get; set; }

    }
}
