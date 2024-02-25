using AutoMapper;
using Business.Abstracts;
using Business.Requests.Employees;
using Business.Responses.Employees;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class EmployeeManager : IEmployeeService
    {
        private readonly IEmployeeRepository _employeeRepository;
        private readonly IMapper _mapper;

        public EmployeeManager(IEmployeeRepository employeeRepository, IMapper mapper)
        {
            _employeeRepository = employeeRepository;
            _mapper = mapper;
        }

        public AddEmployeeResponse Add(AddEmployeeRequest request)
        {
            Employee employee = _mapper.Map<Employee>(request);

            _employeeRepository.Add(employee);

            AddEmployeeResponse response = _mapper.Map<AddEmployeeResponse>(employee);

            return response;
        }

        public DeleteEmployeeResponse Delete(DeleteEmployeeRequest request)
        {
            Employee deleteToEmployee = _employeeRepository.GetById(predicate: employee => employee.Id == request.Id);

            if (deleteToEmployee != null)
            {
                var deletedEmployee = _employeeRepository.Delete(deleteToEmployee);

                var response = _mapper.Map<DeleteEmployeeResponse>(deletedEmployee);
                
                return response;
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public List<GetAllEmployeeResponse> GetAll()
        {
            List<Employee> employees = _employeeRepository.GetAll();

            List<GetAllEmployeeResponse> responses = _mapper.Map<List<GetAllEmployeeResponse>>(employees);

            return responses;
        }

        public GetEmployeeByIdResponse GetById(GetEmployeeByIdRequest request)
        {
            Employee employee = _employeeRepository.GetById(predicate: employee => employee.Id == request.Id);

            if (employee != null)
            {
                GetEmployeeByIdResponse response = _mapper.Map<GetEmployeeByIdResponse>(employee);

                return response;
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }

        public UpdateEmployeeResponse Update(UpdateEmployeeRequest request)
        {
            Employee updateToEmployee = _employeeRepository.GetById(predicate: employee => employee.Id == request.Id);

            if (updateToEmployee != null)
            {
                _mapper.Map(request, updateToEmployee);

                _employeeRepository.Update(updateToEmployee);

                var updatedEmployee = _mapper.Map<UpdateEmployeeResponse>(updateToEmployee);

                return updatedEmployee;
            }
            else
            {
                throw new Exception("Employee not found");
            }
        }
    }
}
