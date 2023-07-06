using JobManagementService.Business.Abstract;
using JobManagementService.Data.Entity;
using Microsoft.AspNetCore.Mvc;

namespace JobManagementService.API.Controllers
{
    //--https://localhost:5001/api/job
    [Route("api/[controller]")]    
    [ApiController]
    public class JobController : Controller
    {
       private IJobService _jobService;

       public JobController(IJobService jobService)
       {
            _jobService = jobService;
       }

        //[HttpGet]
        //public List<TbJob> GetAllJobs() 
        //{
        //     return _jobService.GetAllJobs();    
        //}

        //[HttpGet]
        //[Route("GetAllJobs")]
        //public IActionResult GetAllJobs() 
        //{
        //     var jobs = _jobService.GetAllJobs();    
        //     return Ok(jobs);  // 200 + Data 
        //}

        [HttpGet]
        [Route("GetAllJobs")]
        public async Task<IActionResult> GetAllJobs()
        {
            var jobs = await _jobService.GetAllJobs();
            return Ok(jobs);  // 200 + Data 
        }


        //[HttpGet]
        //public List<TbJobType> GetAllJobsTypes()
        //{
        //     return _jobService.GetAllJobsTypes();
        //}

        //[HttpGet]
        //[Route("GetAllJobsTypes")]
        //public IActionResult GetAllJobsTypes()
        //{
        //    var jobTypes = _jobService.GetAllJobsTypes();
        //    return Ok(jobTypes);
        //}

        [HttpGet]
        [Route("GetAllJobsTypes")]
        public async Task<IActionResult> GetAllJobsTypes()
        {
            var jobTypes = await _jobService.GetAllJobsTypes();
            return Ok(jobTypes);
        }



        //[HttpGet("{id}")]
        //public TbJob GetJobById(int id)
        //{
        //     return _jobService.GetJobById(id);  
        //}

        //[Route("GetJobById/{id}")]
        //[Route("[action]/{id}")]
        //public IActionResult GetJobById(int id)
        //{
        //    var job = _jobService.GetJobById(id);
        //    if (job != null) 
        //    { 
        //        return Ok(job); // 200 + Data
        //    }
        //    return NotFound(); // 404

        //}

        [Route("[action]/{id}")]
        public async Task<IActionResult> GetJobById(int id)
        {
            var job = await _jobService.GetJobById(id);
            if (job != null)
            {
                return Ok(job); // 200 + Data
            }
            return NotFound(); // 404

        }



        //[HttpPost]
        //public TbJob CreateJob([FromBody] TbJob job)
        //{
        //     return _jobService.CreateJob(job);
        //}

        //[HttpPost]
        //[Route("CreateJob")]
        //public IActionResult CreateJob([FromBody] TbJob job)
        //{
        //    var createdJob = _jobService.CreateJob(job);    
        //    return Ok(createdJob); // 200 + Data
        //    //return CreatedAtAction("Get", new { id = createdJob.Id }, createdJob); // 201 + Data
        //}

        [HttpPost]
        [Route("CreateJob")]
        public async Task<IActionResult> CreateJob([FromBody] TbJob job)
        {
            var createdJob = await _jobService.CreateJob(job);
            return Ok(createdJob); // 200 + Data
            //return CreatedAtAction("Get", new { id = createdJob.Id }, createdJob); // 201 + Data
        }


        //[HttpPut]
        //public TbJob UpdateJob([FromBody] TbJob job)
        //{
        //     return _jobService.UpdateJob(job);
        //}

        //[HttpPut]
        //[Route("UpdateJob")]
        //public IActionResult UpdateJob([FromBody] TbJob job)
        //{
        //     if (_jobService.GetJobById(job.Id) != null) 
        //     {
        //         return Ok(_jobService.UpdateJob(job)); // 200 + Data
        //     } 
        //     return NotFound(); // 404 
        //}

        [HttpPut]
        [Route("UpdateJob")]
        public async Task<IActionResult> UpdateJob([FromBody] TbJob job)
        {
            if (_jobService.GetJobById(job.Id) != null)
            {
                return Ok(await _jobService.UpdateJob(job)); // 200 + Data
            }
            return NotFound(); // 404 

        }


        //[HttpDelete("{id}")]
        //public void DeleteJob(int id)
        //{
        //    _jobService.DeleteJob(id);
        //}

        //[HttpDelete("{id}")]
        //[Route("DeleteJob/{id}")]
        //public IActionResult DeleteJob(int id)
        //{
        //    if (_jobService.GetJobById(id) != null) 
        //    { 
        //        _jobService.DeleteJob(id);
        //        return Ok();
        //    }
        //    return NotFound();
        //}

        //[HttpDelete("{id}")]
        [HttpDelete("DeleteJob/{id}")]
        //[Route("DeleteJob/{id}")]
        public async Task<IActionResult> DeleteJob(int id)
        {
            if (_jobService.GetJobById(id) != null)
            {
                await _jobService.DeleteJob(id);
                return Ok();
            }
            return NotFound();
        }
    }
}
