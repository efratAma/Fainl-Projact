using BL.Api;
using BL.Models;
using FullStack.api;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FullStack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProjectController : ControllerBase
    {


        IProjectServiceBl _projectServiceBl;

            public ProjectController(IProjectServiceBl projectServiceBl)
            {
                _projectServiceBl = projectServiceBl;
            }

            [HttpPut("AddProject")]
            public IActionResult AddProject([FromBody] ProjectBl projectBl)
            {
                if (_projectServiceBl.AddProjectBl(projectBl))
                {
                    return Ok("project added successfully");
                }
                return BadRequest("this project is alredy exsist");
            }

            [HttpDelete("RemoveProject")]
            public IActionResult RemoveProject([FromBody] ProjectBl projectBl)
            {
                if (_projectServiceBl.RemoveProjectBl(projectBl))
                {
                    return Ok("project removed successfully");
                }
                return BadRequest("this project is not exsist");
            }
            [HttpGet("GetAllProjects")]
            public IActionResult GetAllProjects()
            {
            List<Project> projects = _projectServiceBl.GetAllProjects();
            if (projects != null && projects.Count > 0)
            {
                return Ok(projects);
            }
            return NotFound("No projects found");
            }


    }
}
