using AutoMapper;
using Business.Requests.Cars;
using Business.Responses.Cars;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Cars
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Car, CreateCarRequest>().ReverseMap();
            CreateMap<Car, CreateCarResponse>().ReverseMap();
            CreateMap<Car, GetAllCarResponse>().ReverseMap();
        }
    }
}
