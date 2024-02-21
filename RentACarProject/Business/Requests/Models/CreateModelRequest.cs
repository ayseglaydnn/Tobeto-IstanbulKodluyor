using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Requests.Models
{
    public class CreateModelRequest
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
    }
}
