using BL.Api;
using BL.Models;
using DAL.Api;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Services
{
    public class ProjectServiceBl: IProjectServiceBl
    {
        private readonly IProjectDal _projectDal;

        public ProjectServiceBl(IProjectDal projectDal)
        {
            this._projectDal = projectDal;
            
        }

        public bool AddProjectBl(ProjectBl projectBl)
        {
            Project p = _projectDal.GetProjectById(projectBl.Id);
            if (p == null)
            {
                var project = ConvertToProjectDal(projectBl);
                _projectDal.AddProject(project);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveProjectBl(ProjectBl projectBl)
        {
            Project p = _projectDal.GetProjectById(projectBl.Id);
            if (p != null)
            {
                _projectDal.RemoveProject(p);
                return true;
            }
            return false;
        }

        public Project ConvertToProjectDal(ProjectBl projectBl)
        {
            return new Project
            {
                Id = projectBl.Id,
                ProjactName = projectBl.ProjactName,
                NumberOfApartments = projectBl.NumberOfApartments,
                City = projectBl.City,
                ZipCode = projectBl.ZipCode
             
            };
        }
        public List<Project> GetAllProjects()
        {
            return _projectDal.GetAllProjects();
        }
    }
}
