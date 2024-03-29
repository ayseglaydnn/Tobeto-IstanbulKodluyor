﻿using AutoMapper;
using Azure;
using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Responses.Applicants;
using Business.Rules;
using Core.Utilities.Results;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ApplicantManager : IApplicantService
    {
        private readonly IApplicantRepository _applicantRepository;
        private readonly IMapper _mapper;
        private readonly ApplicantBusinessRules _applicantBusinessRules;

        public ApplicantManager(IApplicantRepository applicantRepository, IMapper mapper, ApplicantBusinessRules applicantBusinessRules)
        {
            _applicantRepository = applicantRepository;
            _mapper = mapper;
            _applicantBusinessRules = applicantBusinessRules;
        }

        public IDataResult<AddApplicantResponse> Add(AddApplicantRequest request)
        {
            Applicant applicant = _mapper.Map<Applicant>(request);

            _applicantBusinessRules.CheckIfEmailRegistered(request.Email);

            _applicantRepository.Add(applicant);

            AddApplicantResponse response = _mapper.Map<AddApplicantResponse>(applicant);

            return new SuccessDataResult<AddApplicantResponse>(response, "Added Successfully");
        }

        public IDataResult<DeleteApplicantResponse> Delete(DeleteApplicantRequest request)
        {
            Applicant deleteToApplicant = _applicantRepository.GetById(predicate: applicant => applicant.Id == request.Id);

            _applicantBusinessRules.CheckIfApplicantExists(deleteToApplicant);

            var deletedApplicant = _applicantRepository.Delete(deleteToApplicant);

            var response = _mapper.Map<DeleteApplicantResponse>(deletedApplicant);

            return new SuccessDataResult<DeleteApplicantResponse>(response, "Deleted Successfully");

        }

        public IDataResult<List<GetAllApplicantResponse>> GetAll()
        {
            List<Applicant> applicants = _applicantRepository.GetAll();

            List<GetAllApplicantResponse> responses = _mapper.Map<List<GetAllApplicantResponse>>(applicants);

            return new SuccessDataResult<List<GetAllApplicantResponse>>(responses, "Listed Successfully");
        }

        public IDataResult<GetApplicantByIdResponse> GetById(GetApplicantByIdRequest request)
        {
            Applicant applicant = _applicantRepository.GetById(predicate: applicant => applicant.Id == request.Id);

            _applicantBusinessRules.CheckIfApplicantExists(applicant);

            GetApplicantByIdResponse response = _mapper.Map<GetApplicantByIdResponse>(applicant);

            return new SuccessDataResult<GetApplicantByIdResponse>(response, "Showed Successfully");

        }

        public IDataResult<UpdateApplicantResponse> Update(UpdateApplicantRequest request)
        {
            Applicant updateToApplicant = _applicantRepository.GetById(predicate: applicant => applicant.Id == request.Id);

            _applicantBusinessRules.CheckIfApplicantExists(updateToApplicant);

            _mapper.Map(request, updateToApplicant);

            _applicantRepository.Update(updateToApplicant);

            var response = _mapper.Map<UpdateApplicantResponse>(updateToApplicant);

            return new SuccessDataResult<UpdateApplicantResponse>(response, "Updated Successfully");

        }
    }
}
