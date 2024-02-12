using Kodlama_Io_WorkShop.Business.Concretes;
using Kodlama_Io_WorkShop.Business.Dtos.Requests;
using Kodlama_Io_WorkShop.Business.Dtos.Responses;
using Kodlama_Io_WorkShop.DataAccess.Concretes.InMemory;
using Kodlama_Io_WorkShop.Entities;
using System.Globalization;

namespace Kodlama_Io_WorkShop
{
    internal class Program
    {
        static void Main(string[] args)
        {


            TrainerManager trainerManager = new TrainerManager(new ImTrainerDal());
            foreach (var category in trainerManager.GetTrainers())
            {
                Console.WriteLine(category.TrainerName);
                Console.WriteLine(category.TrainerId);
            }
            Console.WriteLine("-------------------");
            trainerManager.Delete(1);

            trainerManager.Update(2,new UpdateTrainerRequest { TrainerName="sdasdasd"});

            foreach (var category in trainerManager.GetTrainers())
            {
                Console.WriteLine(category.TrainerName);
            }





        }
    }
}
