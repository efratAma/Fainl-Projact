using System;
using System.Collections.Generic;
using System.Text;
using DAL.Api;
using FullStack.api;
namespace DAL.Services
{
    public class ProjectServiceDal : IProjectDal
    {
        dbClass data;
        public void AddProject(Project project)
        {
            data.Projects.Add(project);
        }
    }
}
