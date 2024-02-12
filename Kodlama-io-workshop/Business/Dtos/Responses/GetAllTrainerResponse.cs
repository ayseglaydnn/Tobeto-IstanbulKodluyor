using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Dtos.Responses
{
    public class GetAllTrainerResponse
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public List<Course> Course { get; set; }
    }
}
