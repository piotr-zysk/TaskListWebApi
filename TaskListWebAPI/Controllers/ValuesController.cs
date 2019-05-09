using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TaskListWebAPI.Model;
using TaskListWebAPI.Repositories;
using System.Web.Http;

namespace TaskListWebAPI.Controllers
{
    [EnableCors("SiteCorsPolicy")]
    [Route("api")]
    [ApiController]  
    public class ValuesController : ControllerBase
    {
        private ITaskRepository _taskRepository;

        public ValuesController(ITaskRepository taskRepository)
        {
            this._taskRepository = taskRepository;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<TaskItem>> Get()
        {
            return Ok(_taskRepository.GetAll());
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return Ok(_taskRepository.Get(id));
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] TaskItem value)
        {
            if (!ModelState.IsValid)
            {
                string errorMessages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));

                return BadRequest(errorMessages);
            }

            _taskRepository.Add(value);
            
            return Created("", value);  //dodaj uri                    
            //return StatusCode((int)System.Net.HttpStatusCode.InternalServerError);
        }

        // PUT api/values/5
        [HttpPut]
        public IActionResult Put([FromBody] TaskItem value)
        {
            if (!ModelState.IsValid)
            {
                string errorMessages = string.Join("; ", ModelState.Values
                                        .SelectMany(x => x.Errors)
                                        .Select(x => x.ErrorMessage));

                return BadRequest(errorMessages);
            }

            _taskRepository.Update(value);

            return Ok(value);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _taskRepository.Delete(id);
        }
    }
}
