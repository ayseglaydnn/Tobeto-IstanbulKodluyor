using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Dtos.Requests
{
    public class CreateTrainerRequest
    {
        public string TrainerName { get; set; }
    }
    public class UpdateTrainerRequest
    {
        public string TrainerName { get; set; }
    }
    public class DeleteTrainerRequest
    {
        public int Id { get; set; }
    }
}
