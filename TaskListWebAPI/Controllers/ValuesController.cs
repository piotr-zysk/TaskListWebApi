using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using TaskListWebAPI.Model;
using TaskListWebAPI.Repositories;

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
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
