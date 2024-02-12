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
    public interface ITrainerService
    {
        public void Add(CreateTrainerRequest trainer);
        public List<GetAllTrainerResponse> GetTrainers();
        public void Delete(int trainerId);
        public void Update(int trainerId, UpdateTrainerRequest trainer);




    }
}
