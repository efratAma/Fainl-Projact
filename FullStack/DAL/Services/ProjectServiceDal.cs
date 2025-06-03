using System;
using System.Collections.Generic;
using System.Text;
using DAL.Api;
using FullStack.api;
namespace DAL.Services
{
    public class ProjectServiceDal : IProjectDal
    {
        dbClass dbClass;
        public ProjectServiceDal(dbClass dbClass)
        {
            this.dbClass = dbClass;          
        }
        public void AddProject(Project project)
        {
            dbClass.Projects.Add(project);
        }
        public void RemoveProject(Project project)
        {
            dbClass.Projects.Remove(project);
            dbClass.SaveChanges();
        }
    }
}
