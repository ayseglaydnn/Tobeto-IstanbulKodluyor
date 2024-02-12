using Kodlama_Io_WorkShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama_Io_WorkShop.DataAccess.Abstracts
{
    public interface ITrainerDal
    {
        public void Add(Trainer trainer);
        public void Delete(Trainer trainer);
        public void Update(Trainer trainer);

        public Trainer GetByIdTrainer(int id);

        public List<Trainer> GetTrainers();

    }
}
