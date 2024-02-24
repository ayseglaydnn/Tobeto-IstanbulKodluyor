using Business.Abstracts;
using Business.Requests.Applications;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicationsController : BaseController
    {
        private readonly IApplicationService _applicationService;

        public ApplicationsController(IApplicationService applicationService)
        {
            _applicationService = applicationService;
        }

        [HttpPost("Add")]
        public async Task<IActionResult> AddAsync(CreateApplicationRequest request)
        {
            return HandleDataResult(await _applicationService.AddAsync(request));
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> DeleteApplication(int id)
        {
            return HandleDataResult(await _applicationService.DeleteAsync(new DeleteApplicationRequest { Id = id }));
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            return HandleDataResult(await _applicationService.GetAllAsync());
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetApplicationById(int id)
        {
            return HandleDataResult(await _applicationService.GetByIdAsync(new GetByIdApplicationRequest { Id = id }));
        }

        [HttpPut("Update/{id}")]
        public async Task<IActionResult> UpdateApplication(int id, UpdateApplicationRequest request)
        {
            request.Id = id;
            return HandleDataResult(await _applicationService.UpdateAsync(request));
        }
    }
}
