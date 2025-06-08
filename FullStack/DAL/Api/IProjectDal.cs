using FullStack.api;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Api
{
    public interface IProjectDal
    {
         void AddProject(Project project);
        void RemoveProject(Project project);
        List<Project> GetAllProjects();
        Project GetProjectById(int id);
    }
}
