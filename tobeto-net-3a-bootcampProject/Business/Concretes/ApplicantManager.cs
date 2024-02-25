using AutoMapper;
using Business.Abstracts;
using Business.Requests.Applicants;
using Business.Responses.Applicants;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class ApplicantManager : IApplicantService
    {
        private readonly IApplicantRepository _applicantRepository;
        private readonly IMapper _mapper;

        public ApplicantManager(IApplicantRepository applicantRepository, IMapper mapper)
        {
            _applicantRepository = applicantRepository;
            _mapper = mapper;
        }

        public AddApplicantResponse Add(AddApplicantRequest request)
        {
            Applicant applicant = _mapper.Map<Applicant>(request);

            _applicantRepository.Add(applicant);

            AddApplicantResponse response = _mapper.Map<AddApplicantResponse>(applicant);

            return response;
        }

        public DeleteApplicantResponse Delete(DeleteApplicantRequest request)
        {
            Applicant deleteToApplicant = _applicantRepository.GetById(predicate: applicant => applicant.Id == request.Id);

            if (deleteToApplicant != null)
            {
                var deletedApplicant = _applicantRepository.Delete(deleteToApplicant);

                var response = _mapper.Map<DeleteApplicantResponse>(deletedApplicant);

                return response;
            }
            else
            {
                throw new Exception("Applicant not found");
            }

        }

        public List<GetAllApplicantResponse> GetAll()
        {
            List<Applicant> applicants = _applicantRepository.GetAll();

            List<GetAllApplicantResponse> responses = _mapper.Map<List<GetAllApplicantResponse>>(applicants);

            return responses;
        }

        public GetApplicantByIdResponse GetById(GetApplicantByIdRequest request)
        {
            Applicant applicant = _applicantRepository.GetById(predicate: applicant => applicant.Id == request.Id);

            if (applicant != null)
            {
                GetApplicantByIdResponse response = _mapper.Map<GetApplicantByIdResponse>(applicant);

                return response;
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public UpdateApplicantResponse Update(UpdateApplicantRequest request)
        {
            Applicant updateToApplicant = _applicantRepository.GetById(predicate: applicant => applicant.Id == request.Id);

            if (updateToApplicant != null)
            {
                _mapper.Map(request, updateToApplicant);

                _applicantRepository.Update(updateToApplicant);

                var updatedApplicant = _mapper.Map<UpdateApplicantResponse>(updateToApplicant);

                return updatedApplicant;
            }
            else
            {
                throw new Exception("Applicant not found");
            }
        }
    }
}
