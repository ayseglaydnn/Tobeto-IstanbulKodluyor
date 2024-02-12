using Kodlama_Io_WorkShop.Business.Abstracts;
using Kodlama_Io_WorkShop.Business.Dtos.Requests;
using Kodlama_Io_WorkShop.Business.Dtos.Responses;
using Kodlama_Io_WorkShop.DataAccess.Abstracts;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Business.Concretes
{
    public class TrainerManager : ITrainerService
    {
        ITrainerDal _trainerDal;
        public TrainerManager(ITrainerDal trainerDal)
        {
            _trainerDal = trainerDal;
        }
        public void Add(CreateTrainerRequest trainer)
        {
            Trainer trainerToCreate = new();
            trainerToCreate.TrainerName = trainer.TrainerName;
            _trainerDal.Add(trainerToCreate);
        }



        public List<GetAllTrainerResponse> GetTrainers()
        {
            List<GetAllTrainerResponse> trainer = new List<GetAllTrainerResponse>();

            foreach (var item in _trainerDal.GetTrainers())
            {
                GetAllTrainerResponse getAllTrainerResponse = new GetAllTrainerResponse();
                getAllTrainerResponse.TrainerId = item.TrainerId;
                getAllTrainerResponse.TrainerName = item.TrainerName;
                trainer.Add(getAllTrainerResponse);
            }
            return trainer;
        }
        public void Delete(int trainerId)
        {
            Trainer deleteToTrainer = _trainerDal.GetByIdTrainer(trainerId);
            if (deleteToTrainer != null)
            {
                _trainerDal.Delete(deleteToTrainer);
            }
            else
            {
                // Handle trainer not found error
                throw new Exception("Trainer not found");
            }
        }

        public void Update(int trainerId, UpdateTrainerRequest trainer)
        {
            Trainer updateToTrainer = _trainerDal.GetByIdTrainer(trainerId);
            if (updateToTrainer != null)
            {
                updateToTrainer.TrainerName = trainer.TrainerName;
                _trainerDal.Update(updateToTrainer);
            }
            else
            {
                // Handle trainer not found error
                throw new Exception("Trainer not found");
            }
        }
    }
}
