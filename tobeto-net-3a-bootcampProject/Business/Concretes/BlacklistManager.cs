using AutoMapper;
using Business.Abstracts;
using Business.Requests.Blacklists;
using Business.Responses.Applications;
using Business.Responses.Blacklists;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using DataAccess.Concretes.Repositories;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Business.Concretes
{
    public class BlacklistManager : IBlacklistService
    {
        private readonly IBlacklistRepository _blacklistRepository;
        private readonly IMapper _mapper;

        public BlacklistManager(IBlacklistRepository blacklistRepository, IMapper mapper)
        {
            _blacklistRepository = blacklistRepository;
            _mapper = mapper;
        }

        public async Task<IDataResult<CreateBlacklistResponse>> AddAsync(CreateBlacklistRequest request)
        {
            Blacklist blacklist = _mapper.Map<Blacklist>(request);

            await _blacklistRepository.AddAsync(blacklist);

            var response = _mapper.Map<CreateBlacklistResponse>(blacklist);

            return new SuccessDataResult<CreateBlacklistResponse>(response, "Added Successfully.");

        }

        public async Task<IDataResult<DeleteBlacklistResponse>> DeleteAsync(DeleteBlacklistRequest request)
        {
            var blacklist = await _blacklistRepository.GetByIdAsync(predicate: blacklist => blacklist.Id == request.Id);

            if (blacklist == null)
            {
                return new ErrorDataResult<DeleteBlacklistResponse>("Blacklist not found");
            }

            await _blacklistRepository.DeleteAsync(blacklist);

            var response = _mapper.Map<DeleteBlacklistResponse>(blacklist);

            return new SuccessDataResult<DeleteBlacklistResponse>(response, "Deleted Successfully");
        }

        public async Task<IDataResult<List<GetAllBlacklistResponse>>> GetAllAsync()
        {
            List<Blacklist> blacklists = await _blacklistRepository.GetAllAsync(include: x => x.Include(x => x.Applicant));

            List<GetAllBlacklistResponse> responses = _mapper.Map<List<GetAllBlacklistResponse>>(blacklists);

            return new SuccessDataResult<List<GetAllBlacklistResponse>>(responses, "Listed Successfully");
        }

        public async Task<IDataResult<GetByIdBlacklistResponse>> GetByIdAsync(GetByIdBlacklistRequest request)
        {
            var blacklist = await _blacklistRepository.GetByIdAsync(predicate: blacklist => blacklist.Id == request.Id);

            if (blacklist == null)
            {
                return new ErrorDataResult<GetByIdBlacklistResponse>("Blacklist not found");
            }

            var response = _mapper.Map<GetByIdBlacklistResponse>(blacklist);

            return new SuccessDataResult<GetByIdBlacklistResponse>(response, "Showed Successfully");
        }

        public async Task<IDataResult<UpdateBlacklistResponse>> UpdateAsync(UpdateBlacklistRequest request)
        {
            var blacklist = await _blacklistRepository.GetByIdAsync(predicate: blacklist => blacklist.Id == request.Id);

            if (blacklist == null)
            {
                return new ErrorDataResult<UpdateBlacklistResponse>("Blacklist not found");
            }

            _mapper.Map(request, blacklist); 

            await _blacklistRepository.UpdateAsync(blacklist);

            var response = _mapper.Map<UpdateBlacklistResponse>(blacklist);

            return new SuccessDataResult<UpdateBlacklistResponse>(response, "Updated Successfully");
        }
    }
}
