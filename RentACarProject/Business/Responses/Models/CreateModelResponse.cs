﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Responses.Models
{
    public class CreateModelResponse
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
