using JobManagementService.Business.Abstract;
using JobManagementService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementService.Business.Concrete
{
    public class JobService : IJobService
    {
        private IJobRepository _jobRepository;

        public JobService(IJobRepository jobRepository) 
        {
            _jobRepository = jobRepository;
        }

        //public List<TbJob> GetAllJobs()
        //{
        //    return _jobRepository.GetAllJobs();
        //}
        public async Task<List<TbJob>> GetAllJobs()
        {
            return await _jobRepository.GetAllJobs();
        }

        //public List<TbJobType> GetAllJobsTypes()
        //{
        //    return _jobRepository.GetAllJobsTypes();
        //}
        public async Task<List<TbJobType>> GetAllJobsTypes()
        {
            return await _jobRepository.GetAllJobsTypes();
        }

        //public TbJob GetJobById(int id)
        //{
        //    return _jobRepository.GetJobById(id);
        //}
        public async Task<TbJob> GetJobById(int id)
        {
            return await _jobRepository.GetJobById(id);
        }

        //public TbJob CreateJob(TbJob job)
        //{
        //    return _jobRepository.CreateJob(job);
        //}
        public async Task<TbJob> CreateJob(TbJob job)
        {
            return await _jobRepository.CreateJob(job);
        }

        //public TbJob UpdateJob(TbJob job)
        //{
        //    return _jobRepository.UpdateJob(job);   
        //}
        public async Task<TbJob> UpdateJob(TbJob job)
        {
            return await _jobRepository.UpdateJob(job);
        }

        //public void DeleteJob(int id)
        //{
        //    _jobRepository.DeleteJob(id);    
        //}
        public async Task DeleteJob(int id)
        {
            await _jobRepository.DeleteJob(id);
        }
    }
}
