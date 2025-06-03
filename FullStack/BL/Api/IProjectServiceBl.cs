using BL.Models;
using FullStack.api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Api
{
    public interface IProjectServiceBl
    {

        bool AddProjectBl(ProjectBl projectBl);

        bool RemoveProjectBl(ProjectBl projectBl);
        Project ConvertToProjectDal(ProjectBl projectBl);



    }
}
