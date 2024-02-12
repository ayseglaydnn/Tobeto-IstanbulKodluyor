using Kodlama_Io_WorkShop.DataAccess.Abstracts;
using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.DataAccess.Concretes.InMemory
{
    public class ImTrainerDal : ITrainerDal
    {
        List<Trainer> trainers = new List<Trainer>();
        public ImTrainerDal()
        {
            trainers.Add(new Trainer { TrainerId = 1, TrainerName = "Engin Demiroğ", });
            trainers.Add(new Trainer { TrainerId = 2, TrainerName = "Halit Enes Kalaycı", });

        }


        public void Add(Trainer trainer)
        {
            trainers.Add(trainer);
        }

        public void Delete(Trainer trainer)
        {
            trainers.Remove(trainer);
        }

        public void Update(Trainer trainer)
        {
            Trainer updateToTrainer = trainers.FirstOrDefault(t => t.TrainerId == trainer.TrainerId);
            if (updateToTrainer != null)
            {
                updateToTrainer.TrainerName = trainer.TrainerName;
            }
            else
            {
                // Handle trainer not found error
                throw new Exception("Trainer not found");
            }
        }
        public Trainer GetByIdTrainer(int id)
        {
            return trainers.FirstOrDefault(t => t.TrainerId == id);
        }

        public List<Trainer> GetTrainers()
        {
            return trainers;
        }

    }



}
