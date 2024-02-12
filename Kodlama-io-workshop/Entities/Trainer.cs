using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.Entities
{
    public class Trainer
    {
        public Trainer()
        {
            
        }

        public Trainer(int id, string trainerName)
        {
            TrainerId = id;
            TrainerName = trainerName;
        }

        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public List<Course> Course { get; set; }
    }
}
