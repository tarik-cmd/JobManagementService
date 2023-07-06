using JobManagementService.Business.Abstract;
using JobManagementService.Data;
using JobManagementService.Data.Entity;
using JobManagementService.Data.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JobManagementService.Business.Concrete
{
    public class JobRepository : IJobRepository
    {
        //public List<TbJob> GetAllJobs()
        //{
        //    using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
        //    {
        //        return jobManagementDbContext.Jobs.ToList();
        //    }
        //}
        public async Task<List<TbJob>> GetAllJobs()
        {
            using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
            {
                return await jobManagementDbContext.Jobs.ToListAsync();
            }
        }

        //public List<TbJobType> GetAllJobsTypes()
        //{
        //    using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
        //    {
        //        return jobManagementDbContext.JobTypes.ToList();
        //    }
        //}

        public async Task<List<TbJobType>> GetAllJobsTypes()
        {
            using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
            {
                return await jobManagementDbContext.JobTypes.ToListAsync();
            }
        }

        //public TbJob GetJobById(int id)
        //{
        //    using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
        //    {
        //        return jobManagementDbContext.Jobs.Find(id);
        //    }
        //}

        public async Task<TbJob> GetJobById(int id)
        {
            using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
            {
                return await jobManagementDbContext.Jobs.FindAsync(id);
            }
        }

        //public TbJob CreateJob(TbJob job)
        //{
        //    using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
        //    {
        //        jobManagementDbContext.Jobs.Add(job);
        //        jobManagementDbContext.SaveChanges();
        //        return job;
        //    }
        //}

        public async Task<TbJob> CreateJob(TbJob job)
        {
            using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
            {
                jobManagementDbContext.Jobs.Add(job);
                await jobManagementDbContext.SaveChangesAsync();
                return job;
            }
        }

        //public TbJob UpdateJob(TbJob job)
        //{
        //    using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
        //    {
        //        jobManagementDbContext.Jobs.Update(job);
        //        jobManagementDbContext.SaveChanges();
        //        return job;
        //    }
        //}

        public async Task<TbJob> UpdateJob(TbJob job)
        {
            using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
            {
                jobManagementDbContext.Jobs.Update(job);
                await jobManagementDbContext.SaveChangesAsync();
                return job;
            }
        }

        //public void DeleteJob(int id)
        //{
        //    using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
        //    {
        //        var deletedJob = GetJobById(id);
        //        jobManagementDbContext.Jobs.Remove(deletedJob);
        //        jobManagementDbContext.SaveChanges();
        //    }
        //}

        public async Task DeleteJob(int id)
        {
            using (var jobManagementDbContext = new JobManagementService.Data.DbContext.JobManagementDbContext())
            {
                var deletedJob = await GetJobById(id);
                jobManagementDbContext.Jobs.Remove(deletedJob);
                await jobManagementDbContext.SaveChangesAsync();
            }
        }
    }
}
