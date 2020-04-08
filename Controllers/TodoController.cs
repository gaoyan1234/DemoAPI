using DemoAPI.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DemoAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TodoController : ControllerBase
    {
        [HttpPost]
        public ActionResult Add([FromBody]TodoModel todoModel)
        {
            try
            {
                EFDataContext eFDataContext = new EFDataContext();
                TodoEntity todoEntity = new TodoEntity();
                todoEntity.Title = todoModel.Title;
                todoEntity.Completed =(todoModel.Completed != null)?(bool)todoModel.Completed:false;
                eFDataContext.TodoEntity.Add(todoEntity);
                eFDataContext.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }

        [HttpGet]
        public ActionResult<List<TodoModel>> Get()
        {
            try
            {
                EFDataContext eFDataContext = new EFDataContext();
                return Ok(eFDataContext.TodoEntity.ToList());
            }
            catch (Exception ex)
            {
                return BadRequest();
            }
        }
    }
}