using AutoMapper;
using Business.Abstracts;
using Business.Requests.Instructors;
using Business.Responses.Instructors;
using DataAccess.Abstracts;
using Entities.Concretes;


namespace Business.Concretes
{
    public class InstructorManager : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;
        private readonly IMapper _mapper;

        public InstructorManager(IInstructorRepository instructorRepository, IMapper mapper)
        {
            _instructorRepository = instructorRepository;
            _mapper = mapper;
        }

        public AddInstructorResponse Add(AddInstructorRequest request)
        {
            Instructor instructor = _mapper.Map<Instructor>(request);

            _instructorRepository.Add(instructor);

            AddInstructorResponse response = _mapper.Map<AddInstructorResponse>(request);

             return response;
        }

        public DeleteInstructorResponse Delete(DeleteInstructorRequest request)
        {
            Instructor deleteToInstructor = _instructorRepository.GetById(predicate: instructor => instructor.Id == request.Id);

            if (deleteToInstructor != null)
            {
                var deletedInstructor = _instructorRepository.Delete(deleteToInstructor);

                var response = new DeleteInstructorResponse { DeletedTime = deletedInstructor.DeletedDate, UserName = deletedInstructor.UserName, Id = deletedInstructor.Id };
                
                return response;
            }
            else
            {
                throw new Exception("Instructor not found");
            }
        }

        public List<GetAllInstructorResponse> GetAll()
        {
            List<Instructor> instructors = _instructorRepository.GetAll();

            var responses = _mapper.Map<List<GetAllInstructorResponse>>(instructors);

            return responses;
        }

        public GetInstructorByIdResponse GetById(GetInstructorByIdRequest request)
        {
            Instructor instructor = _instructorRepository.GetById(predicate: instructor => instructor.Id == request.Id);

            if (instructor != null)
            {
                GetInstructorByIdResponse response = _mapper.Map<GetInstructorByIdResponse>(instructor);

                return response;
            }
            else
            {
                throw new Exception("Instructor not found");
            }
        }

        public UpdateInstructorResponse Update(UpdateInstructorRequest request)
        {
            Instructor updateToInstructor = _instructorRepository.GetById(predicate: instructor => instructor.Id == request.Id);

            if (updateToInstructor != null)
            {
                _mapper.Map(request, updateToInstructor);

                _instructorRepository.Update(updateToInstructor);

                var updatedInstructor = _mapper.Map<UpdateInstructorResponse>(updateToInstructor);

                return updatedInstructor;
            }
            else
            {
                // Handle Instructor not found error
                throw new Exception("Instructor not found");
            }
        }
    }
}
