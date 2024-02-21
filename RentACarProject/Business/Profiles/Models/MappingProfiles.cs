using AutoMapper;
using Business.Requests.Models;
using Business.Responses.Models;
using Entities.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Profiles.Models
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Model, CreateModelRequest>().ReverseMap();
            CreateMap<Model, CreateModelResponse>().ReverseMap();
            CreateMap<Model, GetAllModelResponse>().ReverseMap();
        }
        
    }
}
