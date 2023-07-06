using JobManagementService.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobManagementService.Business.Abstract
{
    public interface IJobService
    {
        //List<TbJob> GetAllJobs();
        Task<List<TbJob>> GetAllJobs();

        //List<TbJobType> GetAllJobsTypes();
        Task<List<TbJobType>> GetAllJobsTypes();

        //TbJob GetJobById(int id);
        Task<TbJob> GetJobById(int id);

        //TbJob CreateJob(TbJob job);
        Task<TbJob> CreateJob(TbJob job);

        //TbJob UpdateJob(TbJob job);
        Task<TbJob> UpdateJob(TbJob job);

        //void DeleteJob(int id); 
        Task DeleteJob(int id);
    }
}
